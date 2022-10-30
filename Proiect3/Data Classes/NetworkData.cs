using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Classes
{
    internal class NetworkData
    {
        private readonly List<BankDataNormalised> trainingData = new List<BankDataNormalised>();
        private readonly List<BankDataTest> testingData = new List<BankDataTest>();
        private NetworkData()
        {

        }
        private static NetworkData instance;
        public static NetworkData Instance
        {
            get
            {
                if (instance == null) instance = new NetworkData();
                return instance;
            }
        }

        public Object GetTrainingData()
        {
            return this.trainingData;
        }
        public Object GetTestingData()
        {
            return this.testingData;
        }

        public void AddTrainingData(BankDataNormalised data)
        {
            this.trainingData.Add(data);
        }
        public void AddTestingData(BankDataNormalised data)
        {
            BankDataTest newData = new BankDataTest
            {
                Age = data.Age,
                Job = data.Job,
                MaritalStatus = data.MaritalStatus,
                Education = data.Education,
                IsDefault = data.IsDefault,
                Balance = data.Balance,
                Housing = data.Housing,
                Loan = data.Loan,
                Contact = data.Contact,
                Day = data.Day,
                Month = data.Month,
                Duration = data.Duration,
                Campaign = data.Campaign,
                Pdays = data.Pdays,
                Previous = data.Previous,
                Poutcome = data.Poutcome,
                Outcome = data.Outcome,
                CurrentOutcome = 0,
                Error = 0
            };
            this.testingData.Add(newData);
        }

        public int GetTrainingCount()
        {
            return trainingData.Count;
        }

        public int GetTestingCount()
        {
            return testingData.Count;
        }
    }
}
