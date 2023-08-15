using Microsoft.EntityFrameworkCore;

namespace Calc.Models
{
    public class CalculatorDBContext : DbContext
    {
        public DbSet<Calculation> CalculationHistory { get; set; }

        public CalculatorDBContext(DbContextOptions<CalculatorDBContext> options) : base (options)
        {

        }

        // tried to get unique id while creating the model here....
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Calculation>().Property(c => c.CalculationID).ValueGeneratedOnAdd();
        //}

    }
}
