namespace MIS221PA5
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers)
        {
            this.trainers = trainers;
        }

        public void GetAllTrainers()
        {
            Trainer.SetCount(0);
            Console.ForegroundColor = ConsoleColor.Green;       //console color extra
            System.Console.WriteLine("Please enter the trainer ID or stop to stop: ");
            string userInput = Console.ReadLine();
            while (userInput.ToUpper() != "STOP")
            {
                trainers[Trainer.GetCount()] = new Trainer();
                trainers[Trainer.GetCount()].SetTrainerID(int.Parse(userInput));
                System.Console.WriteLine("Please enter the trainer name: ");
                trainers[Trainer.GetCount()].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the trainer mailing address: ");
                trainers[Trainer.GetCount()].SetMailingAddress(Console.ReadLine());
                System.Console.WriteLine("Please enter the trainer email address: ");
                trainers[Trainer.GetCount()].SetTrainerEmailAddress(Console.ReadLine());
                Trainer.IncCount();
                System.Console.WriteLine("Please enter the trainer ID or stop to stop: ");
                Console.ResetColor();
                userInput = Console.ReadLine();
            }
        }

        public void GetAllTrainersFromFile()
        {
            StreamReader inFile = new StreamReader("trainers.txt");
            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3], bool.Parse(temp[4]));
                Trainer.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();

        }
        public void AddTrainer()
        {
            Console.ForegroundColor = ConsoleColor.Green;       //console color extra
            System.Console.WriteLine("Please enter the Trainer's ID:");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the Trainer's name: ");
            myTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date the session will be taking place: ");
            myTrainer.SetMailingAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter the time the training session will be taking place: ");
            myTrainer.SetTrainerEmailAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter the cost of the training session: ");
            Console.ResetColor();

            trainers[Trainer.GetCount()] = myTrainer;
            Trainer.IncCount();
            Save();
        }


        private void Save()
        {
            StreamWriter outFile = new StreamWriter("trainers.txt");

            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                outFile.WriteLine(trainers[i].ToFile());
            }
            outFile.Close();
        }

        public int FindTrainer(string searchVal)
        {
            int findIndex = -1;
            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                if (trainers[i].GetTrainerID() == int.Parse(searchVal))
                {
                    findIndex = i;
                }
            }
            return findIndex;
        }
        public void UpdateTrainer()
        {
            System.Console.WriteLine("What is Trainer ID that you would like to update:");
            string searchVal = Console.ReadLine();
            int foundIndex = FindTrainer(searchVal);
            if (foundIndex != -1)
            {
                string TrainerUserChoice = UpdateTrainerOption();
                switch (TrainerUserChoice)
                {
                    case "1":
                        {
                            System.Console.WriteLine("Please enter the updated trainer's ID:");
                            trainers[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));
                        }
                        break;
                    case "2":
                        {
                            System.Console.WriteLine("Please enter the updated trainer name:");
                            trainers[foundIndex].SetTrainerName(Console.ReadLine());
                        }
                        break;
                    case "3":
                        {
                            System.Console.WriteLine("Please enter the updated trainers mailing address:");
                            trainers[foundIndex].SetMailingAddress(Console.ReadLine());
                        }
                        break;
                    case "4":
                        {
                            System.Console.WriteLine("Please enter the updated email for the trainer:");
                            trainers[foundIndex].SetTrainerEmailAddress(Console.ReadLine());
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;       //console color extra
                        System.Console.WriteLine("Invalid Menu Choice");
                        Console.ResetColor();
                        break;
                }
            }
        }
        public string UpdateTrainerOption()
        {
            Console.ForegroundColor = ConsoleColor.Green;       //console color extra
            System.Console.WriteLine("What would you like to change about the customer data?");
            System.Console.WriteLine("1. Trainer ID");
            System.Console.WriteLine("2. Trainer's Name");
            System.Console.WriteLine("3. Trainers Mailing Address");
            System.Console.WriteLine("4. Trainers Email Address");
            string TrainerUserChoice = Console.ReadLine();
            return TrainerUserChoice;
            Console.ResetColor();
        }
        public void DeleteTrainer()
        {
            Console.ForegroundColor = ConsoleColor.Green;       //console color extra
            System.Console.WriteLine("What is Trainer ID that you would like to delete:");
            Console.ResetColor();
            string searchVal = Console.ReadLine();
            int foundIndex = FindTrainer(searchVal);
            if (foundIndex != -1)
            {
                trainers[foundIndex].SetIsDeleted(true);
                Save();
            }
        }
    }
}


