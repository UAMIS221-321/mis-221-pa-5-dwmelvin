namespace MIS221PA5
{
    public class Transaction
    {
        private int sessionID;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private int trainerID;
        private string trainerName;
        private string isDeleted;
        static int count;
        public Transaction()
        {
        }
        public Transaction(int sessionID, string customerName, string customerEmail, string trainingDate, int trainerID, string trainerName, string isDeleted)
        {
            this.sessionID = sessionID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.isDeleted = isDeleted;
        }

        public int GetSessionID()
        {
            return sessionID;
        }
        public void SetSessionID(int sessionID)
        {
            this.sessionID = sessionID;
        }
        public string GetCustomerName()
        {
            return customerName;
        }
        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public string GetCustomerEmail()
        {
            return customerEmail;
        }
        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }
        public string GetTrainingDate()
        {
            return trainingDate;
        }
        public void SetTrainingDate(string trainingDate)
        {
            this.trainingDate = trainingDate;
        }
        public int GetTrainerID()
        {
            return trainerID;
        }
        public void SetTrainerID(int trainerID)
        {
            this.trainerID = trainerID;
        }
        public string GetTrainerName()
        {
            return trainerName;
        }
        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }
        public string GetStatus()
        {
            return isDeleted;
        }
        public void SetStatus(string isDeleted)
        {
            this.isDeleted = isDeleted;
        }
        static public void SetCount(int count)
        {
            Transaction.count = count;
        }
        static public void IncCount()
        {
            Transaction.count++;
        }
        static public int GetCount()
        {
            return Transaction.count;
        }
        public override string ToString()
        {
            return "Transaction ID: " + sessionID + " Customer Name: " + customerName + " Customer Email: " + customerEmail + " Training Date: " + trainingDate + " Trainer ID: " + trainerID + " Trainer Name: " + trainerName + " Status: " + isDeleted;
        }
        public string ToFile()
        {
            return $"{sessionID}#{customerName}#{customerEmail}#{trainingDate}#{trainerID}#{trainerName}#{isDeleted}";
        }
    }
}