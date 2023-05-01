using MIS221PA5;

Transaction[] transactions = new Transaction[50];
Trainer[] trainers = new Trainer[50];
Listing[] listings = new Listing[50];
ListingReport listingReport = new ListingReport(listings);
ListingUtility listingUtility = new ListingUtility(listings);
TrainerUtility trainerUtility = new TrainerUtility(trainers);
TrainerReport trainerBooking = new TrainerReport(trainers);
TrainerReport trainerReport = new TrainerReport(trainers);
TransactionUtility transactionUtility = new TransactionUtility(transactions, listingReport, listingUtility, trainerUtility, trainerReport, listings);
TransactionReport transactionReport = new TransactionReport(transactions);


trainerUtility.GetAllTrainersFromFile();
listingUtility.GetAllListingsFromFile();
transactionUtility.GetAllTransactionsFromFile();
listingReport.PrintAllListings();
trainerReport.PrintAllTrainers();
transactionReport.PrintAllTransactions();
Menu(trainers, trainerUtility, trainerReport, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);

static void Menu(Trainer[] trainers, TrainerUtility trainerUtility, TrainerReport report, Listing[] listings, ListingUtility listingUtility, ListingReport listingReport, Transaction[] transactions, TransactionUtility transactionUtility, TransactionReport transactionReport)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkBlue;    //console color extra
    Console.WriteLine("Train Like A Champion - Personal Fitness");
    Console.WriteLine("========================================");
    Console.WriteLine("1. View Trainer Data");
    Console.WriteLine("2. View Listing Data");
    Console.WriteLine("3. Generate Reports");
    Console.WriteLine("4. Exit Program");
    Console.WriteLine("========================================");
    Console.Write("Choose an option: ");
    Console.ResetColor();
    string userChoice = Console.ReadLine();
    while (userChoice != "4")
    {
        switch (userChoice)
        {
            case "1":
                TrainerSubMenu(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "2":
                ListingSubMenu(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "3":
                TransactionSubMenu(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "4":
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;     //console color extra
                System.Console.WriteLine("Invalid Menu Choice");
                Console.ResetColor();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;

        }
    }
}
static void PauseAction(Trainer[] trainers, TrainerUtility trainerUtility, TrainerReport report, Listing[] listings, ListingUtility listingUtility, ListingReport listingReport, Transaction[] transactions, TransactionUtility transactionUtility, TransactionReport transactionReport)
{
    Console.ForegroundColor = ConsoleColor.Green;       //console color extra
    System.Console.WriteLine("Press any key to continue... ");
    Console.ResetColor();
    Console.ReadKey();
    Menu(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
}



static void ListingSubMenu(Trainer[] trainers, TrainerUtility trainerUtility, TrainerReport report, Listing[] listings, ListingUtility listingUtility, ListingReport listingReport, Transaction[] transactions, TransactionUtility transactionUtility, TransactionReport transactionReport)
{
    Console.ForegroundColor = ConsoleColor.Blue;        //console color extra
    System.Console.WriteLine("What would you like to do with the listing data?");
    Console.ResetColor();
    System.Console.WriteLine("1. Print All Sessions");
    System.Console.WriteLine("2. Add a Session");
    System.Console.WriteLine("3. Edit a Session");
    System.Console.WriteLine("4. Delete a Session");
    System.Console.WriteLine("5. Exit");
    System.Console.WriteLine("Enter choice here:");
    string subMenuChoice = Console.ReadLine();
    while (subMenuChoice != "5")
    {
        switch (subMenuChoice)
        {
            case "1":
                for (int i = 0; i < Listing.GetCount(); i++)
                {
                    System.Console.WriteLine(listings[i].ToString());
                }
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "2":
                listingUtility.AddListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "3":
                listingUtility.UpdateListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);

                break;
            case "4":
                listingUtility.DeleteListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;        //console color extra
                System.Console.WriteLine("Not a valid option");
                Console.ResetColor();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
        }
    }
    subMenuChoice = Console.ReadLine();
}


static void TrainerSubMenu(Trainer[] trainers, TrainerUtility trainerUtility, TrainerReport report, Listing[] listings, ListingUtility listingUtility, ListingReport listingReport, Transaction[] transactions, TransactionUtility transactionUtility, TransactionReport transactionReport)
{
    Console.ForegroundColor = ConsoleColor.Blue;        //console color extra
    System.Console.WriteLine("What would you like to do with the listing data?");
    Console.ResetColor();
    System.Console.WriteLine("What would you like to do with the trainer data?");
    System.Console.WriteLine("1. Print All Trainer Data");
    System.Console.WriteLine("2. Add a trainer");
    System.Console.WriteLine("3. Edit a trainer's data");
    System.Console.WriteLine("4. Remove a trainer");
    System.Console.WriteLine("5. Exit");
    System.Console.WriteLine("Enter choice here:");
    string subMenuChoice = Console.ReadLine();
    while (subMenuChoice != "5")
    {
        switch (subMenuChoice)
        {
            case "1":
                for (int i = 0; i < Trainer.GetCount(); i++)
                {
                    System.Console.WriteLine(trainers[i].ToString());
                }
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "2":
                trainerUtility.AddTrainer();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "3":
                listingUtility.UpdateListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "4":
                trainerUtility.DeleteTrainer();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;        //console color extra
                System.Console.WriteLine("Not a valid option");
                Console.ResetColor();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
        }
    }
    subMenuChoice = Console.ReadLine();
}

static void TransactionSubMenu(Trainer[] trainers, TrainerUtility trainerUtility, TrainerReport report, Listing[] listings, ListingUtility listingUtility, ListingReport listingReport, Transaction[] transactions, TransactionUtility transactionUtility, TransactionReport transactionReport)
{
    Console.ForegroundColor = ConsoleColor.Blue;        //console color extra
    System.Console.WriteLine("What would you like to do with the listing data?");
    Console.ResetColor();    
    System.Console.WriteLine("1. Print All Transactions");
    System.Console.WriteLine("2. Cancel a session");
    System.Console.WriteLine("3. Mark a session complete");
    System.Console.WriteLine("4. Delete a Session");
    System.Console.WriteLine("5. Exit");
    System.Console.WriteLine("Enter choice here:");
    string subMenuChoice = Console.ReadLine();
    while (subMenuChoice != "5")
    {
        switch (subMenuChoice)
        {
            case "1":
                for (int i = 0; i < Transaction.GetCount(); i++)
                {
                    System.Console.WriteLine(transactions[i].ToString());
                }
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "2":
                listingUtility.AddListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            case "3":
                listingUtility.UpdateListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);

                break;
            case "4":
                listingUtility.DeleteListing();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;        //console color extra
                System.Console.WriteLine("Not a valid option");
                Console.ResetColor();
                PauseAction(trainers, trainerUtility, report, listings, listingUtility, listingReport, transactions, transactionUtility, transactionReport);
                break;
        }
    }
    subMenuChoice = Console.ReadLine();
}