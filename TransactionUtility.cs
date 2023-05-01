namespace MIS221PA5
{
    public class TransactionUtility
    {
        private Transaction[] transactions;
        private ListingReport listingReport;
        private ListingUtility listingUtility;
        private TrainerUtility trainerUtility;
        private TrainerReport trainerReport;
        private Listing[] listings;
        public TransactionUtility(Transaction[] transactions, ListingReport listingReport, ListingUtility listingUtility, TrainerUtility trainerUtility, TrainerReport trainerReport, Listing[] listings)
        {
            this.transactions = transactions;
            this.listingReport = listingReport;
            this.listingUtility = listingUtility;
            this.trainerUtility = trainerUtility;
            this.trainerReport = trainerReport;
            this.listings = listings;
            listingUtility.GetAllListings();
        }
        public void GetAllTransactionsFromFile()
        {
            StreamReader inFile = new StreamReader("transactions.txt");
            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                transactions[Transaction.GetCount()] = new Transaction();
                Transaction.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void BookSession(Listing[] listings)
        {
            Transaction newTransaction = new Transaction();
            listingReport.PrintAllListings();
            System.Console.WriteLine("Please enter the session ID: ");
            string userInput = (Console.ReadLine());
            newTransaction.SetSessionID(int.Parse(userInput));
            System.Console.WriteLine("Please enter name: ");
            newTransaction.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Please enter email: ");
            newTransaction.SetCustomerEmail(Console.ReadLine());
            Listing listingBooking = listings[listingUtility.FindListing(userInput)];
            newTransaction.SetTrainingDate(listingBooking.GetDateOfSession());
            newTransaction.SetTrainerID(Trainer.GetTrainerID());
            string trainerName = listingBooking.GetTraineeName();
            Trainer trainerBooking = trainerUtility.FindTrainer(int.Parse(trainerName));
            newTransaction.SetTrainerID(trainerReport.GetTrainerID());
            newTransaction.SetStatus("booked");
            transactions[Transaction.GetCount()] = newTransaction;
            Transaction.IncCount();
            Save();
        }
        private void Save()
        {
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for (int i = 0; i < Transaction.GetCount(); i++)
            {
                outFile.WriteLine(transactions[i].ToFile());
            }
        }
    }
}
