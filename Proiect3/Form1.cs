using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect3.Classes;
using System.IO;

namespace Proiect3
{
    public partial class Form1 : Form
    {

        List<BankData> dataList = new List<BankData>();
        List<String> inputs = new List<string>();
        public Form1()
        {
            InitializeComponent();

            ReadFromFile();
        }

        private void ReadFromFile()
        {
            using (var reader = new StreamReader(@"C:\Faculta\Ai\Proiect3\Proiect3\resources\bank.csv"))
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                foreach(var value in values)
                {
                    inputs.Add(value);
                }

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(';');

                    BankData data = new BankData
                    {
                        age = Convert.ToDouble(values[0]),
                        job = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Job), values[1])),
                        relation = Convert.ToDouble(Enum.Parse(typeof(DataEnums.MaritalStatus), values[2])),
                        education = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Education), values[3])),
                        isDefault = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Default), values[4])),
                        balance = Convert.ToDouble(values[5]),
                        housing = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Housing), values[6])),
                        loan = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Loan), values[7])),
                        contact = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Contact), values[8])),
                        day = Convert.ToDouble(values[9]),
                        month = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Month), values[10])),
                        duration = Convert.ToDouble(values[11]),
                        campaign = Convert.ToDouble(values[12]),
                        pdays = Convert.ToDouble(values[13]),
                        previus = Convert.ToDouble(values[14]),
                        poutcome = Convert.ToDouble(Enum.Parse(typeof(DataEnums.PrevoisOutcome), values[15])),
                        outcome = Convert.ToDouble(Enum.Parse(typeof(DataEnums.Outcome), values[16])),
                    };

                    dataList.Add(data);
                    Console.WriteLine("GG BA CA O INTRAT");
                }
            }
        }
    }
}
