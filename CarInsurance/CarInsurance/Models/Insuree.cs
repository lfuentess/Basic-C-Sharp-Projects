using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        public required int CarYear { get; set; }
        public required string CarMake { get; set; }
        public required string CarModel { get; set; }
        public bool DUI { get; set; }
        public required int SpeedingTickets { get; set; }
        public string? CoverageType { get; set; }
        public decimal? Quote {  get; set; }

        public Insuree() { }
        public Insuree (Guid id, string firstName, string lastName, string emailAddress, DateOnly dateOfBirth,
                      int carYear, string carMake, string carModel, bool dui, int speedingTickets,
                      string coverageType, decimal quote)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            DateOfBirth = dateOfBirth;
            CarYear = carYear;
            CarMake = carMake;
            CarModel = carModel;
            DUI = dui;
            SpeedingTickets = speedingTickets;
            CoverageType = coverageType;
            Quote = quote;
        }
        public decimal CalculateQuote(Insuree insuree)
        {
            decimal valueQuote = 50m; //Start with a base of $50 / month.
            var ageUser = DateTime.Now.Year - insuree.DateOfBirth.Year;

            //If the user is 18 or under, add $100 to the monthly total.
            if (ageUser <= 18)  
            {
                valueQuote += 100;
            } else if (ageUser >=19 && ageUser<=25) //If the user is from 19 to 25, add $50 to the monthly total.
            {
                valueQuote += 50;
            }
            else if (ageUser>=26)//If the user is 26 or older, add $25 to the monthly total. 
            {
                valueQuote += 25;
            }

            //If the car's year is before 2000, add $25 to the monthly total.
            if (insuree.CarYear < 2000)
            {
                valueQuote += 25;
            }else if (insuree.CarYear > 2015)//If the car's year is after 2015, add $25 to the monthly total.
            {
                valueQuote += 25;
            }

            //If the car's Make is a Porsche, add $25 to the price. 
            if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake == "Porsche")
            {
                valueQuote += 25;
                if (!string.IsNullOrEmpty(insuree.CarModel ) && insuree.CarModel == "911 Carrera") //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                {
                    valueQuote += 25;
                }
            }

            //Add $10 to the monthly total for every speeding ticket the user has.
            if (insuree.SpeedingTickets > 0)
            {
                valueQuote += (insuree.SpeedingTickets * 10);
            }

            //If the user has ever had a DUI, add 25% to the total.
            if (insuree.DUI)
            {
                valueQuote += (valueQuote * 25) / 100;
            }

            //If it's full coverage, add 50% to the total.
            if (insuree.CoverageType == "full")
            {
                valueQuote += (valueQuote * 50) / 100;
            }

            return valueQuote;
;
        }
    }
}
