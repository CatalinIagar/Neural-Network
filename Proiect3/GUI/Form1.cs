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
        public Form1()
        {
            InitializeComponent();

            dataBtn.Click += (sender, e) => LoadDataPanel(sender, e);
            this.MaximizeBox = false;

        }

        private void LoadDataPanel(object sender, EventArgs e)
        {
            DataPanel dataPanel = DataPanel.Instance;

            this.Controls.Add(dataPanel);
        }

        
    }
}
