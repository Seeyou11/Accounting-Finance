namespace WebApplication2.Models
{
    //AccountingFinanceRepository
    public interface IAcRepository
    {
        AccountingFinance GetAccountingFinance(int Id);
        IEnumerable<AccountingFinance> GetAllAccounts();
        AccountingFinance Add(AccountingFinance accountingFinance);
        AccountingFinance Delete(int Id);
        AccountingFinance Update(AccountingFinance accountingFinance);
    }
}
