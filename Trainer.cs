namespace MIS221PA5
{
    public class Trainer
    {
        private int trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;
        private bool isDeleted;
        static int count;

        public Trainer()
        {
        }
        public Trainer(int trainerID, string trainerName, string mailingAddress, string trainerEmailAddress, bool isDeleted)
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
            this.isDeleted = isDeleted;

        }


        public void SetIsDeleted(bool isDeleted)
        {
            this.isDeleted = isDeleted;
        }
        public bool GetIsDeleted()
        {
            return isDeleted;
        }

        public void SetTrainerID(int trainerID)
        {
            this.trainerID = trainerID;
        }
        public int GetTrainerID()
        {
            return trainerID;
        }

        static public void SetCount(int count)
        {
            Trainer.count = count;
        }
        static public void IncCount()
        {
            Trainer.count++;
        }
        static public int GetCount()
        {
            return Trainer.count;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }
        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }
        public string GetMailingAddress()
        {
            return mailingAddress;
        }
        public void SetMailingAddress(string mailingAddress)
        {
            this.mailingAddress = mailingAddress;
        }
        public string GetTrainerEmailAddress()
        {
            return trainerEmailAddress;
        }
        public void SetTrainerEmailAddress(string trainerEmailAddress)
        {
            this.trainerEmailAddress = trainerEmailAddress;
        }
        public string ToFile()
        {
            return $"{trainerID}#{trainerName}#{mailingAddress}#{trainerEmailAddress}#{isDeleted}";
        }
        public override string ToString()
        {
            return " Trainer ID: " + trainerID + " Trainer Name: " + trainerName + " Mailing Address: " + mailingAddress + " Trainer Email Address: " + trainerEmailAddress;
        }
    }

}