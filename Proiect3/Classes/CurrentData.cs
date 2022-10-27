using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Proiect3.Classes
{
    internal class CurrentData
    {
        private readonly List<BankData> dataList = new List<BankData>();
        private readonly List<BankDataNormalised> normalizedData = new List<BankDataNormalised>();
        private CurrentData()
        {

        }
        private static CurrentData instance;
        public static CurrentData Instance
        {
            get
            {
                if (instance == null) instance = new CurrentData();
                return instance;
            }
        }
        public Object GetData()
        {
            return this.dataList;
        }
        public Object GetNormData()
        {
            return this.normalizedData;
        }

        public int GetDataCount()
        {
            return dataList.Count;
        }

        public int GetNormDataCount()
        {
            return normalizedData.Count;
        }
        public void ReadFromFile()
        {
            using (var reader = new StreamReader(@"C:\Faculta\Ai\Proiect3\Proiect3\resources\bank - Copy.csv"))
            {
                PropertyInfo[] properties = typeof(BankData).GetProperties();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');


                    BankData data = new BankData();
                    int i = 0;
                    foreach (PropertyInfo property in properties)
                    {
                        property.SetValue(data, values[i]);
                        i++;
                    }
                    dataList.Add(data);
                }
            }
        }
        public void ConvertData()
        {
            foreach (BankData data in dataList)
            {
                BankDataNormalised newData = new BankDataNormalised
                {
                    Age = System.Convert.ToDouble(data.Age),
                    Job = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Job), data.Job)),
                    MaritalStatus = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.MaritalStatus), data.MaritalStatus)),
                    Education = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Education), data.Education)),
                    IsDefault = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Default), data.IsDefault)),
                    Balance = System.Convert.ToDouble(data.Balance),
                    Housing = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Housing), data.Housing)),
                    Loan = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Loan), data.Loan)),
                    Contact = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Contact), data.Contact)),
                    Day = System.Convert.ToDouble(data.Day),
                    Month = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Month), data.Month)),
                    Duration = System.Convert.ToDouble(data.Duration),
                    Campaign = System.Convert.ToDouble(data.Campaign),
                    Pdays = System.Convert.ToDouble(data.Pdays),
                    Previous = System.Convert.ToDouble(data.Previous),
                    Poutcome = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.PrevoisOutcome), data.Poutcome)),
                    Outcome = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Outcome), data.Outcome))
                };
                normalizedData.Add(newData);
            }
        }
        public (double max, double min) GetMinMax(PropertyInfo property)
        {
            double min = (double)property.GetValue(normalizedData[0], null);
            double max = (double)property.GetValue(normalizedData[0], null);
            foreach (var data in normalizedData)
            {
                double value = (double)property.GetValue(data, null);
                if (min > value) min = value;
                if (value > max) max = value;
            }
            return (max, min);
        }
        public void Normalize()
        {

            PropertyInfo[] properties = typeof(BankDataNormalised).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var (max, min) = GetMinMax(property);
                foreach(var data in normalizedData)
                {
                    double value = (double)property.GetValue(data, null);
                    property.SetValue(data, (value - min) / (max - min));

                    if(property.Name == "Outcome")
                    {
                        if((double)property.GetValue(data, null) == 0)
                        {
                            property.SetValue(data, 0.001);
                        }
                        else
                        {
                            property.SetValue(data, 0.999);
                        }
                    }
                }
            }

            SplitData();
        }

        private void SplitData()
        {
            Random random = new Random();
            foreach(var data in normalizedData)
            {
                int number = random.Next(1, 100);
                if (number <= 70) NetworkData.Instance.AddTrainingData(data);
                if (number > 70) NetworkData.Instance.AddTestingData(data);
            }
        }
    }
}