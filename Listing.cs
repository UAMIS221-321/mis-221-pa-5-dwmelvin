namespace MIS221PA5
{
    public class Listing
    {
        private int listingID;
        private string traineeName;
        private string dateOfSession;
        private string timeOfSession;
        private string costOfSession;
        private string locationOfSession;
        private string sessionAvailable;
        private bool isDeleted;
        static private int count;
        public Listing()
        {

        }
        public Listing(int listingID, string traineeName, string dateOfSession, string timeOfSession, string costOfSession, string locationOfSession, bool isDeleted)
        {
            this.listingID = listingID;
            this.traineeName = traineeName;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.locationOfSession = locationOfSession;
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

        public void SetListingID(int listingID)
        {
            this.listingID = listingID;
        }
        public int GetListingID()
        {
            return listingID;
        }
        public string GetTraineeName()
        {
            return traineeName;
        }
        public void SetTraineeName(string traineeName)
        {
            this.traineeName = traineeName;
        }
        public string GetDateOfSession()
        {
            return dateOfSession;
        }
        public void SetDateOfSession(string dateOfSession)
        {
            this.dateOfSession = dateOfSession;
        }
        public string GetTimeOfSession()
        {
            return timeOfSession;
        }
        public void SetTimeOfSession(string timeOfSession)
        {
            this.timeOfSession = timeOfSession;
        }
        public string GetCostOfSession()
        {
            return costOfSession;
        }
        public void SetCostOfSession(string costOfSession)
        {
            this.costOfSession = costOfSession;
        }
        public string GetLocationOfSession()
        {
            return locationOfSession;
        }
        public void SetLocationOfSession(string locationOfSession)
        {
            this.locationOfSession = locationOfSession;
        }
        public string GetSessionAvailable()
        {
            return sessionAvailable;
        }
        public void SetSessionAvailable(string sessionAvailable)
        {
            this.sessionAvailable = sessionAvailable;
        }
        static public void SetCount(int count)
        {
            Listing.count = count;
        }
        static public void IncCount()
        {
            Listing.count++;
        }
        static public int GetCount()
        {
            return Listing.count;
        }
        public override string ToString()
        {
            return " Listing ID: " + listingID + " Trainer Name: " + traineeName + " Date of Session: " + dateOfSession + " Time of Session: " + timeOfSession + " Cost of Session: " + costOfSession + " Session Cancelled: " + isDeleted + "Session Available" + sessionAvailable;
        }
        public string ToFile()
        {
            return $"{listingID}#{traineeName}#{dateOfSession}#{timeOfSession}#{costOfSession}#{isDeleted}#{sessionAvailable}";
        }
    }
}
