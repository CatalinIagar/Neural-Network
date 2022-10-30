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

namespace Proiect3.GUI
{
    public partial class InputPanel : UserControl
    {
        private InputPanel()
        {
            InitializeComponent();
        }
        private static InputPanel instance = null;
        public static InputPanel Instance
        {
            get
            {
                if (instance == null) instance = new InputPanel();
                return instance;
            }
        }

        private void InputPanel_Load(object sender, EventArgs e)
        {
            jobValue.DataSource = Enum.GetValues(typeof(DataEnums.Job));
            maritalValue.DataSource = Enum.GetValues(typeof(DataEnums.MaritalStatus));
            educationValue.DataSource = Enum.GetValues(typeof(DataEnums.Education));
            defaultValue.DataSource = Enum.GetValues(typeof(DataEnums.Default));
            housingValue.DataSource = Enum.GetValues(typeof(DataEnums.Housing));
            loanValue.DataSource = Enum.GetValues(typeof(DataEnums.Loan));
            contactValue.DataSource = Enum.GetValues(typeof(DataEnums.Contact));
            monthValue.DataSource = Enum.GetValues(typeof(DataEnums.Month));
            poutValue.DataSource = Enum.GetValues(typeof(DataEnums.PrevoisOutcome));
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            BankData data = new BankData
            {
                Age = ageValue.Text,
                Job = jobValue.Text,
                MaritalStatus = maritalValue.Text,
                Education = educationValue.Text,
                IsDefault = defaultValue.Text,
                Balance = balanceValue.Text,
                Housing = housingValue.Text,
                Loan = loanValue.Text,
                Contact = contactValue.Text,
                Day = dayValue.Text,
                Month = monthValue.Text,
                Duration = durationValue.Text,
                Campaign = campaignValue.Text,
                Pdays = pdaysValue.Text,
                Previous = prevValue.Text,
                Poutcome = poutValue.Text

            };
            double result = InputData.Instance.GetResult(data);
            resultLbl.Text = result.ToString();
        }
    }
}
