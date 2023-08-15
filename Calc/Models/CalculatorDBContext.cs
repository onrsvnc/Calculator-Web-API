using Microsoft.EntityFrameworkCore;

namespace Calc.Models
{
    public class CalculatorDBContext : DbContext
    {
        public DbSet<Calculation> CalculationHistory { get; set; }

        public CalculatorDBContext(DbContextOptions<CalculatorDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculation>()
                .Property(c => c.A)
                .HasColumnType("decimal(18, 2)"); 

            modelBuilder.Entity<Calculation>()
                .Property(c => c.B)
                .HasColumnType("decimal(18, 2)"); 

            modelBuilder.Entity<Calculation>()
                .Property(c => c.Result)
                .HasColumnType("decimal(18, 2)"); 

            modelBuilder.Entity<Calculation>()
                .Property(c => c.Operation)
                .HasMaxLength(10); 

            modelBuilder.Entity<Calculation>()
                .Property(c => c.CalculationID)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }

    }
}
