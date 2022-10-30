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
    public partial class TestPanel : UserControl
    {
        private TestPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        private static TestPanel instance = null;
        public static TestPanel Instance
        {
            get
            {
                if (instance == null) instance = new TestPanel();
                return instance;
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            NeuralNetwork.NeuralNetwork.Instance.TestData();
            dataGridView1.DataSource = NetworkData.Instance.GetTestingData();
            dataGridView1.Invalidate();
        }

        internal void SetPrecision(double score)
        {
            customProgressBar1.Value = (int)score;
        }
    }
}
