using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class SQLACRepository : IAcRepository
    {
        private readonly AccountDBContext context;
        public SQLACRepository(AccountDBContext context)
        {
            this.context = context;
        }
        public AccountingFinance Add(AccountingFinance accountingFinance)
        {
            context.AccountingFinances.Add(accountingFinance);
            context.SaveChanges();
            return accountingFinance;
        }



        public AccountingFinance Delete(int Id)
        {
            AccountingFinance accountingFinance = context.AccountingFinances.Find(Id);
            if (accountingFinance != null)
            {
                context.AccountingFinances.Remove(accountingFinance);
                context.SaveChanges();
            }
            return accountingFinance;
        }

        public AccountingFinance GetAccountingFinance(int Id)
        {
            return context.AccountingFinances.Find(Id);
        }

        //public AccountingFinance GetAccountingFinance(DateTime CreatedAt)
        //{
        //   var data = (AccountingFinance)context.AccountingFinances.Where(date=> EntityFunctions.TruncateTime(date.CreatedAt) == CreatedAt);
        //    return data;
        //}


        public IEnumerable<AccountingFinance> GetAllAccounts()
        {
            return context.AccountingFinances;
        }

        public AccountingFinance Update(AccountingFinance accountingChanges)
        {
            context.Entry(accountingChanges).State = EntityState.Modified;
            context.SaveChanges();
            return accountingChanges;
        }
    }
}
