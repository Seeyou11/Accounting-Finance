using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.viewModeles;

namespace WebApplication2.Controllers
{
    public class AccountingController : Controller
    {
        private readonly IAcRepository _acRepository;

        public AccountingController(IAcRepository acRepository)
        {
            _acRepository = acRepository;
        }
        public IActionResult Detailes(int Id)
        {
            AccountingFinance model = _acRepository.GetAccountingFinance(Id);
            List<double> Dr = new()
            {
                model.OfficeRentprice,
                model.EmployeeSalary,
                model.TaxPrice,
                model.OfficeSupplyPrice,
                model.SoldSWPrice
            };

            List<double> Cr = new()
            {
                model.OfficeRentprice,
                model.EmployeeSalary,
                model.TaxPrice,
                model.OfficeSupplyPrice,
                model.SoldSWPrice
            };


            List<double> AccountNumber = new()
            {
                model.OfficeRentprice,
                model.EmployeeSalary,
                model.TaxPrice,
                model.OfficeSupplyPrice,
                model.SoldSWPrice
            };

            DetailesViewModel detailesViewModel = new()
            {

                Dr = Dr,
                Cr = Cr,
                AccountNumber = AccountNumber

            };
            return View(detailesViewModel);
        }
    }
}
