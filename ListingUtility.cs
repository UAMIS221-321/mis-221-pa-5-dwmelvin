namespace MIS221PA5
{
    public class ListingUtility
    {
        public Listing[] listings = new Listing[50];

        public ListingUtility(Listing[] listings)
        {
            this.listings = listings;
        }

        public void GetAllListings()
        {
            Listing.SetCount(0);
            Console.ForegroundColor = ConsoleColor.DarkBlue;        //console color extra
            System.Console.WriteLine("Please enter the Listing ID or stop to stop: ");
            Console.ResetColor();
            string userInput = Console.ReadLine();
            while (userInput.ToUpper() != "STOP")
            {
                listings[Listing.GetCount()] = new Listing();
                listings[Listing.GetCount()].SetListingID(int.Parse(userInput));
                System.Console.WriteLine("Please enter the trainers name: ");
                listings[Listing.GetCount()].SetTraineeName(Console.ReadLine());
                System.Console.WriteLine("Please enter the date the session will be taking place: ");
                listings[Listing.GetCount()].SetDateOfSession(Console.ReadLine());
                System.Console.WriteLine("Please enter the time the session will take place : ");
                listings[Listing.GetCount()].SetTimeOfSession(Console.ReadLine());
                System.Console.WriteLine("Please enter the time the cost of the session: ");
                listings[Listing.GetCount()].SetCostOfSession(userInput);
                System.Console.WriteLine("Please enter the time the location of the session: ");
                listings[Listing.GetCount()].SetLocationOfSession(Console.ReadLine());
                Listing.IncCount();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine("Please enter the Listing ID or stop to stop: ");
                Console.ResetColor();
                userInput = Console.ReadLine();
            }
        }
        public void GetAllListingsFromFile()
        {
            StreamReader inFile = new StreamReader("listing.txt");
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4], temp[5], bool.Parse(temp[6]));
                Listing.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void AddListing()
        {
            Console.ForegroundColor = ConsoleColor.Green;        //console color extra
            System.Console.WriteLine("Please enter the Trainer's ID:");
            Listing myListing = new Listing();
            myListing.SetListingID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the Trainer's name: ");
            myListing.SetTraineeName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date the session will be taking place: ");
            myListing.SetDateOfSession(Console.ReadLine());
            System.Console.WriteLine("Please enter the time the training session will be taking place: ");
            myListing.SetTraineeName(Console.ReadLine());
            System.Console.WriteLine("Please enter the cost of the training session: ");
            myListing.SetCostOfSession(Console.ReadLine());
            System.Console.WriteLine("Please enter the location the session will be taking place: ");
            Console.ResetColor();
            myListing.SetLocationOfSession(Console.ReadLine());
            listings[Listing.GetCount()] = myListing;
            Listing.IncCount();
            Save();
        }


        private void Save()
        {
            StreamWriter outFile = new StreamWriter("input.txt");

            for (int i = 0; i < Listing.GetCount(); i++)
            {
                outFile.WriteLine(listings[i].ToFile());
            }
            outFile.Close();
        }

        public int FindListing(string searchVal)
        {
            int findIndex = -1;
            for (int i = 0; i < Listing.GetCount(); i++)
            {
                if (listings[i].GetListingID() == int.Parse(searchVal))
                {
                    findIndex = i;
                }
            }
            return findIndex;
        }
        public void UpdateListing()
        {
            Console.ForegroundColor = ConsoleColor.Green;        //console color extra
            System.Console.WriteLine("What is listing ID that you would like to update:");
            Console.ResetColor();
            string searchVal = Console.ReadLine();
            int foundIndex = FindListing(searchVal);
            if (foundIndex != -1)
            {
                string listingUserChoice = UpdateListingOption();
                switch (listingUserChoice)
                {
                    case "1":
                        {
                            System.Console.WriteLine("Please enter the updated name of who signed up for the training session:");
                            listings[foundIndex].SetTraineeName(Console.ReadLine());
                            Save();
                        }
                        break;
                    case "2":
                        {
                            System.Console.WriteLine("Please enter the updated session date:");
                            listings[foundIndex].SetDateOfSession(Console.ReadLine());
                            Save();
                        }
                        break;
                    case "3":
                        {
                            System.Console.WriteLine("Please enter the updated session time:");
                            listings[foundIndex].SetTimeOfSession(Console.ReadLine());
                            Save();
                        }
                        break;
                    case "4":
                        {
                            System.Console.WriteLine("Please enter the updated cost of the session:");
                            listings[foundIndex].SetCostOfSession(Console.ReadLine());
                            Save();
                        }
                        break;
                    case "5":
                        {
                            System.Console.WriteLine("Please enter the updated location of the session:");
                            listings[foundIndex].SetLocationOfSession(Console.ReadLine());
                            Save();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;        //console color extra
                        System.Console.WriteLine("Invalid Menu Choice");
                        Console.ResetColor();
                        break;
                }
            }
        }
        public string UpdateListingOption()
        {
            Console.ForegroundColor = ConsoleColor.Green;       //console color extra
            System.Console.WriteLine("What would you like to change about the customer data?");
            Console.ResetColor();
            System.Console.WriteLine("1. Customer Name");
            System.Console.WriteLine("2. Date Of Session");
            System.Console.WriteLine("3. Time Of Session");
            System.Console.WriteLine("4. Cost of Session");
            System.Console.WriteLine("5. Location Of Session");
            string listingUserChoice = Console.ReadLine();
            return listingUserChoice;
        }
        public void DeleteListing()
        {
            Console.ForegroundColor = ConsoleColor.Red;       //console color extra
            System.Console.WriteLine("What is Listing ID that you would like to delete:");
            Console.ResetColor();
            string searchVal = Console.ReadLine();
            int foundIndex = FindListing(searchVal);
            if (foundIndex != -1)
            {
                listings[foundIndex].SetIsDeleted(true);
                Save();
            }
        }
    }
}


