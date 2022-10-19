using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using Proiect3.Classes;
using System.Collections;

namespace Proiect3
{
    public partial class DataPanel : UserControl
    {
        readonly List<BankData> dataList = new List<BankData>();
        List<BankDataNormalised> normalizedData = new List<BankDataNormalised>();
        private DataPanel() 
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private static DataPanel instance = null;
        public static DataPanel Instance
        {
            get
            {
                if (instance == null) instance = new DataPanel();
                return instance;
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        private void ReadFromFile()
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

                    /*BankData data = new BankData
                    {
                        Age = values[0],
                        Job = values[1],
                        MaritalStatus = values[2],
                        Education = values[3],
                        IsDefault = values[4],
                        Balance = values[5],
                        Housing = values[6],
                        Loan = values[7],
                        Contact = values[8],
                        Day = values[9],
                        Month = values[10],
                        Duration = values[11],
                        Campaign = values[12],
                        Pdays = values[13],
                        Previous = values[14],
                        Poutcome = values[15],
                        Outcome = values[16]
                    };*/

                    dataList.Add(data);
                }
                Console.WriteLine("Data read succes");
                this.loadBtn.Enabled = false;
                ShowData(dataList);
            }
        }
        private void ShowData(Object list)
        {
            dataGridView1.DataSource = list;
        }

        private void convertBtn_Click(object sender, EventArgs e)
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
            this.convertBtn.Enabled = false;

            ShowData(normalizedData);
        }

        private void Normalize()
        {
            double[] max = new double[17];
            double[] min = new double[17];
        }

        private void nrmBtn_Click(object sender, EventArgs e)
        {
            Normalize();
        }
    }
}
