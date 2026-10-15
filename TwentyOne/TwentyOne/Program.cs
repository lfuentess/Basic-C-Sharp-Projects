using System;
using Casino;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //write in file
            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\lfuen\\Logs\\log.txt", text);

            //read from file
            //string text = File.ReadAllText("C:\\Users\\lfuen\\Logs\\log.txt");


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | "); 
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimal.");
            }

            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", playerName);
            string anwser = Console.ReadLine().ToLower();

            if (anwser == "yes" || anwser == "yeah" || anwser == "y" || anwser == "ya")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance> 0)
                {
                    try 
                    { 
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex) 
                    { 
                        Console.WriteLine("An error occurred. Please contact your Sytem Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TwentyOneGame;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) values " +
                " (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TwentyOneGame;" +
                                        "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                                        "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection( connectionString))
            {
                SqlCommand command  = new SqlCommand(queryString,connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage= reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"].ToString());
                    Exceptions.Add(exception);

                }
                connection.Close();

            }
            return Exceptions;
        }
    }
}
