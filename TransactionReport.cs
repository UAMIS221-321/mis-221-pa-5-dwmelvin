namespace MIS221PA5
{
    public class TransactionReport
    {
        Transaction[] transactions;

        public TransactionReport(Transaction[] transactions)
        {
            this.transactions = transactions;
        }

        public void PrintAllTransactions()
        {
        System.Console.WriteLine(Transaction.GetCount());
            for (int i = 0; i < Transaction.GetCount(); i++)
            {
                System.Console.WriteLine(transactions[i].ToString());
            }
        }
    }
}

