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

using Proiect3.Classes;

namespace Proiect3
{
    public partial class DataPanel : UserControl
    {
        readonly List<BankData> dataList = new List<BankData>();
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
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    /*BankData data = new BankData
                    {
                        Age = Convert.ToDouble(values[0]),
                        Job = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Job), values[1])),
                        MaritalStatus = Convert.ToDouble(Enum.Parse(typeof(DataEnums.MaritalStatus), values[2])),
                        Education = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Education), values[3])),
                        IsDefault = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Default), values[4])),
                        Balance = Convert.ToDouble(values[5]),
                        Housing = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Housing), values[6])),
                        Loan = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Loan), values[7])),
                        Contact = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Contact), values[8])),
                        Day = Convert.ToDouble(values[9]),
                        Month = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Month), values[10])),
                        Duration = Convert.ToDouble(values[11]),
                        Campaign = Convert.ToDouble(values[12]),
                        Pdays = Convert.ToDouble(values[13]),
                        Previous = Convert.ToDouble(values[14]),
                        Poutcome = Convert.ToDouble(Enum.Parse(typeof(DataEnums.PrevoisOutcome), values[15])),
                        Outcome = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Outcome), values[16])),
                    };*/

                    BankData data = new BankData
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
                    };

                    dataList.Add(data);
                }
                Console.WriteLine("Data read succes");
                ShowData();
            }
        }
        private void ShowData()
        {
            dataGridView1.DataSource = dataList;
        }
    }
}
