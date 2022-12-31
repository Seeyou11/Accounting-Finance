using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class AccountingFinance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = new DateTime();
        [Required]
        public double OfficeRentprice { get; set; }
        [Required]
        public double EmployeeSalary { get; set; }
        [Required]
        public double TaxPrice { get; set; }
        [Required]
        public double OfficeSupplyPrice { get; set; }
        [Required]
        public double SoldSWPrice { get; set; }

    }
}
