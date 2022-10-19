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

        public Object getData()
        {
            return this.dataList;
        }

        public Object getNormData()
        {
            return this.normalizedData;
        }

        public void ReadFromFile()
        {
            using (var reader = new StreamReader(@"C:\Faculta\Ai\Proiect3\Proiect3\resources\bank.csv"))
            {
                PropertyInfo[] properties = typeof(BankData).GetProperties();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');


                    BankData data = new BankData();
                    int i = 0;
                    foreach (PropertyInfo property in properties)
                    {
                        property.SetValue(data, values[i]);
                        i++;
                    }

                    dataList.Add(data);
                }
                Console.WriteLine("Data read succes");
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
                    Outcome = System.Convert.ToDouble(Enum.Parse(typeof(DataEnums.Outcome), data.Outcome)),
                };
                normalizedData.Add(newData);
            }
        }

        public void Normalize()
        {
            double[] max = new double[17];
            double[] min = new double[17];

            max[0] = normalizedData.Max(r => r.Age);
            min[0] = normalizedData.Min(r => r.Age);
            max[1] = normalizedData.Max(r => r.Job);
            min[1] = normalizedData.Min(r => r.Job);
            max[2] = normalizedData.Max(r => r.MaritalStatus);
            min[2] = normalizedData.Min(r => r.MaritalStatus);
            max[3] = normalizedData.Max(r => r.Education);
            min[3] = normalizedData.Min(r => r.Education);
            max[4] = normalizedData.Max(r => r.IsDefault);
            min[4] = normalizedData.Min(r => r.IsDefault);
            max[5] = normalizedData.Max(r => r.Balance);
            min[5] = normalizedData.Min(r => r.Balance);
            max[6] = normalizedData.Max(r => r.Housing);
            min[6] = normalizedData.Min(r => r.Housing);
            max[7] = normalizedData.Max(r => r.Loan);
            min[7] = normalizedData.Min(r => r.Loan);
            max[8] = normalizedData.Max(r => r.Contact);
            min[8] = normalizedData.Min(r => r.Contact);
            max[9] = normalizedData.Max(r => r.Day);
            min[9] = normalizedData.Min(r => r.Day);
            max[10] = normalizedData.Max(r => r.Month);
            min[10] = normalizedData.Min(r => r.Month);
            max[11] = normalizedData.Max(r => r.Duration);
            min[11] = normalizedData.Min(r => r.Duration);
            max[12] = normalizedData.Max(r => r.Campaign);
            min[12] = normalizedData.Min(r => r.Campaign);
            max[13] = normalizedData.Max(r => r.Pdays);
            min[13] = normalizedData.Min(r => r.Pdays);
            max[14] = normalizedData.Max(r => r.Previous);
            min[14] = normalizedData.Min(r => r.Previous);
            max[15] = normalizedData.Max(r => r.Poutcome);
            min[15] = normalizedData.Min(r => r.Poutcome);
            max[16] = normalizedData.Max(r => r.Outcome);
            min[16] = normalizedData.Min(r => r.Outcome);

            PropertyInfo[] properties = typeof(BankDataNormalised).GetProperties();

            foreach (var data in normalizedData)
            {
                int i = 0;
                foreach (PropertyInfo property in properties)
                {
                    double value = (double)property.GetValue(data, null);
                    property.SetValue(data, (value - min[i]) / (max[i] - min[i]));
                    i++;
                }
            }
        }
    }
}