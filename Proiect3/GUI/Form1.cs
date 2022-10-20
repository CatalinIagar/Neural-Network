using System;
using System.Windows.Forms;

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
