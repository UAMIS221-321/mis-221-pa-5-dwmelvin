namespace MIS221PA5
{
    public class TrainerReport
    {
        Trainer[] trainers;

        public TrainerReport(Trainer[] trainers)
        {
            this.trainers = trainers;
        }

        public void PrintAllTrainers()
        {
            System.Console.WriteLine(Trainer.GetCount());
            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                System.Console.WriteLine(trainers[i].ToString());
            }
        }
    }
}