namespace Proiect3
{
    internal class BankData
    {
        public string Age { get; set; }
        public string Job { get; set; }
        public string MaritalStatus { get; set; }
        public string Education { get; set; }
        public string IsDefault { get; set; }
        public string Balance { get; set; }
        public string Housing { get; set; }
        public string Loan { get; set; }
        //with what was the client contacted
        public string Contact { get; set; }
        //the last day the client was contacted
        public string Day { get; set; }
        //the last month the client was contacted
        public string Month { get; set; }
        //duration of the call in seconds
        public string Duration { get; set; }
        //number of calls to a client
        public string Campaign { get; set; }
        //number of days that passed by after the client was last contacted from a previous campaign
        public string Pdays { get; set; }
        //number of contacts preformed before this campaign
        public string Previous { get; set; }
        //outcome of the previous campaign
        public string Poutcome { get; set; }
        //result of this campaign
        public string Outcome { get; set; }

        public override string ToString()
        {
            return Age + " " + Job + " " + MaritalStatus + " " + Education + " " + IsDefault + " " + Balance + " " + Housing + " " + 
                Loan + " " + Contact + " " + Day + " " + Month + " " + Duration + " " + Campaign + " " + Pdays + " " +
                Previous + " " + Poutcome + " " + Outcome;
        }
    }
}