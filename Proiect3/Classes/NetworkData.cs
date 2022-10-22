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
        private readonly List<BankDataNormalised> testingData = new List<BankDataNormalised>();
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
            this.testingData.Add(data);
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
