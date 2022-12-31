using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.viewModeles;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAcRepository _acRepository;

        public HomeController(IAcRepository acRepository)
        {
            _acRepository = acRepository;
        }
        public IActionResult Index()
              
        {
            var model = _acRepository.GetAllAccounts();
            ViewData["PageTitle"] = "Accounting Finance Details";
            return View(model);
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
                AccountNumber = AccountNumber,
                CreatedAt = model.CreatedAt,
                OfficeRentprice = model.OfficeRentprice,
                EmployeeSalary = model.EmployeeSalary,
                TaxPrice = model.TaxPrice,
                OfficeSupplyPrice = model.OfficeSupplyPrice,
                SoldSWPrice = model.SoldSWPrice
            };
            

            return View(detailesViewModel);
                
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            AccountingFinance accountingFinance = _acRepository.GetAccountingFinance(id);
            AccountEditViewModel accountEditViewModel = new()
            {
                //edit bemnadergbet gize yalewn detailes yametalnal 
                Id = accountingFinance.Id,
                CreatedAt = accountingFinance.CreatedAt,
                OfficeRentprice = accountingFinance.OfficeRentprice,
                EmployeeSalary = accountingFinance.EmployeeSalary,
                TaxPrice = accountingFinance.TaxPrice,
                OfficeSupplyPrice = accountingFinance.OfficeSupplyPrice,
                SoldSWPrice = accountingFinance.SoldSWPrice
            };
            return View(accountEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(AccountingFinance model)
        {
            if (ModelState.IsValid)
            {
                AccountingFinance accountingFinancee = _acRepository.GetAccountingFinance(model.Id);
                accountingFinancee.CreatedAt = model.CreatedAt;
                accountingFinancee.OfficeRentprice = model.OfficeRentprice;
                accountingFinancee.EmployeeSalary = model.EmployeeSalary;
                accountingFinancee.TaxPrice = model.TaxPrice;
                accountingFinancee.OfficeSupplyPrice = model.OfficeSupplyPrice;
                accountingFinancee.SoldSWPrice = model.SoldSWPrice;

                _acRepository.Update(accountingFinancee);
                return RedirectToAction("Index");

            }
            return View(model);
        }

        [HttpPost]
        public   IActionResult Create(AccountingFinance accountingFinance)
        {
            if (ModelState.IsValid)
            {

                    AccountingFinance accountingFinance1 = new()
                    {
                        Id = accountingFinance.Id,
                        CreatedAt = accountingFinance.CreatedAt,
                        OfficeRentprice = accountingFinance.OfficeRentprice,
                        EmployeeSalary = accountingFinance.EmployeeSalary,
                        TaxPrice = accountingFinance.TaxPrice,
                        OfficeSupplyPrice = accountingFinance.OfficeSupplyPrice,
                        SoldSWPrice = accountingFinance.SoldSWPrice
                    };
                          _acRepository.Add(accountingFinance1);
                        return RedirectToAction("index", new {id = accountingFinance1.Id});
                
                   

    }
            return View();
        }

        //public IActionResult Create(AccountingFinance accountingFinance)
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}