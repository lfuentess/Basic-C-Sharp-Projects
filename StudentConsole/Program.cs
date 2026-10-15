using StudentConsole.DataContext;
using StudentConsole.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentDbContext())
        {
            //Ensure that the database and tables are created automatically
            context.Database.EnsureCreated();

            Console.WriteLine("Student System");
            Console.WriteLine("Enter the student firstname:");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Enter the student lastname:");
            string? lastName = Console.ReadLine();
            Console.WriteLine("Enter the student email:");
            string? email = Console.ReadLine();

            //Create the student instance
            var StudentNew = new Student 
            {
                FirstName = firstName, 
                LastName = lastName, 
                Email = email
            };

            //Add to DbSet and save changes to the database
            context.Students.Add(StudentNew);
            context.SaveChanges();

            Console.WriteLine("The student successfully added!");

            //Display all currently registered students
            Console.WriteLine("Student list in database");
            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"- {student.FirstName} - {student.LastName} - {student.Email}");
            }

            Console.WriteLine("Press enter to leave.");
            Console.ReadLine();
        }
    }
}