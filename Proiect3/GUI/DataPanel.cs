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
            dataGridView1.Visible = true;
            CurrentData.Instance.ReadFromFile();
            loadBtn.Enabled = false;
            convertBtn.Visible = true;
            ShowData(CurrentData.Instance.getData());
        }

        
        private void ShowData(Object list)
        {
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
        

        private void nrmBtn_Click(object sender, EventArgs e)
        {
            CurrentData.Instance.Normalize();
            ShowData(CurrentData.Instance.getNormData());
            this.nrmBtn.Enabled = false;
            dataBtn.Visible = true;
            nrmDataBtn.Visible = true;
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            ShowData(CurrentData.Instance.getData());
        }

        private void nrmDataBtn_Click(object sender, EventArgs e)
        {
            ShowData(CurrentData.Instance.getNormData());
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0) MessageBox.Show("Client's age");
            if (e.ColumnIndex == 1) MessageBox.Show("Client's job");
            if (e.ColumnIndex == 2) MessageBox.Show("Client's marital status");
            if (e.ColumnIndex == 3) MessageBox.Show("Client's Education");
            if (e.ColumnIndex == 4) MessageBox.Show("Has credit in default?");
            if (e.ColumnIndex == 5) MessageBox.Show("Client's balance");
            if (e.ColumnIndex == 6) MessageBox.Show("Has housing loan?");
            if (e.ColumnIndex == 7) MessageBox.Show("Has personal loan?");
            if (e.ColumnIndex == 8) MessageBox.Show("Contact communication type");
            if (e.ColumnIndex == 9) MessageBox.Show("Last contact day of month");
            if (e.ColumnIndex == 10) MessageBox.Show("Last contact month of year");
            if (e.ColumnIndex == 11) MessageBox.Show("Last contact duration, in seconds");
            if (e.ColumnIndex == 12) MessageBox.Show("Number of contacts performed during this campaign and for this client");
            if (e.ColumnIndex == 13) MessageBox.Show("Number of days that passed by after the client was last contacted from a previous campaign");
            if (e.ColumnIndex == 14) MessageBox.Show("Number of contacts performed before this campaign and for this client");
            if (e.ColumnIndex == 15) MessageBox.Show("Outcome of the previous marketing campaign");
            if (e.ColumnIndex == 16) MessageBox.Show("Has the client subscribed a term deposit?");
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            this.convertBtn.Enabled = false;
            CurrentData.Instance.ConvertData();
            ShowData(CurrentData.Instance.getNormData());
            this.nrmBtn.Visible = true;
        }
    }
}