//namespace WebApplication2.Models
//{
//    public class MockAcRepository : IAcRepository
//    {
//        private List<AccountingFinance> _accounts;

//        public MockAcRepository()
//        {
//            _accounts = new List<AccountingFinance>();
//            {
//                new AccountingFinance()
//                {   Id = 1,
//                    OfficeRentprice = 1,
//                    EmployeeSalary = 2,
//                    TaxPrice = 3,
//                    OfficeSupplyPrice = 4,
//                    SoldSWPrice = 5
//                };
//                 new AccountingFinance()
//                 {
//                     Id = 2,
//                     OfficeRentprice = 3,
//                     EmployeeSalary = 4,
//                     TaxPrice = 5,
//                     OfficeSupplyPrice = 6,
//                     SoldSWPrice = 99
//                 };
//                new AccountingFinance()
//                {
//                    Id =3,
//                    OfficeRentprice = 7,
//                    EmployeeSalary = 8,
//                    TaxPrice = 9,
//                    OfficeSupplyPrice = 10,
//                    SoldSWPrice = 111
//                }; 
//            };
//        }

//        public AccountingFinance Add(AccountingFinance accountingFinance)
//        {
//            _accounts.Add(accountingFinance);
//            return accountingFinance;
//        }

//        public AccountingFinance Delete(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public AccountingFinance GetAccountingFinance(int Id)
//        {
//            return _accounts.FirstOrDefault(a => a.Id == Id);
//        }


//        public IEnumerable<AccountingFinance> GetAllAccounts()
//        {
//            return _accounts;
//        }

//        public AccountingFinance Update(AccountingFinance accountingChanges)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
