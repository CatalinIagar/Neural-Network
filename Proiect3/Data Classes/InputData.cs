using Proiect3.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Classes
{
    internal class InputData
    {
        private InputData()
        {

        }
        private static InputData instance;
        public static InputData Instance
        {
            get
            {
                if (instance == null) instance = new InputData();
                return instance;
            }
        }

        internal double GetResult(BankData data)
        {
            BankDataNormalised normalised = new BankDataNormalised
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
            };

            normalised = Normalize(normalised);
            return NeuralNetwork.NeuralNetwork.Instance.testInputData(normalised);
        }

        public BankDataNormalised Normalize(BankDataNormalised normalised)
        {

            PropertyInfo[] properties = typeof(BankDataNormalised).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var (max, min) = CurrentData.Instance.GetMinMax(property);
                double value = (double)property.GetValue(normalised, null);
                property.SetValue(normalised, (value - min) / (max - min));
                if (property.Name == "Outcome")
                {
                    break;
                }
            }
            return normalised;
        }
    }
}
