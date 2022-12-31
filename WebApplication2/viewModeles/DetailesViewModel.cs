using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace WebApplication2.viewModeles
{
    public class DetailesViewModel 
    {
        
        public DateTime CreatedAt { get; set; } = new DateTime();
        public double OfficeRentprice { get; set; }
        public double EmployeeSalary { get; set; }
        public double TaxPrice { get; set; }
        public double OfficeSupplyPrice { get; set; }
        public double SoldSWPrice { get; set; }
        public List<double>? Dr { get; set; }
        public List<double>? Cr { get; set; }
        public List<double>? AccountNumber { get; set; }

    }
}
