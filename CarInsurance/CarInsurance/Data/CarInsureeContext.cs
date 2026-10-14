using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class CarInsureeContext : DbContext
    {
        public CarInsureeContext(DbContextOptions<CarInsureeContext> options) : base(options)
        {
            
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
