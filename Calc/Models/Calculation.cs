using System.ComponentModel.DataAnnotations;

namespace Calc.Models
{
    public class Calculation
    {
        [Key]
        public int CalculationID { get; set; }
        public decimal A { get; set; }
        public decimal B { get; set; }
        public decimal Result { get; set; }
        public string? Operation { get; set; }
    }
}
