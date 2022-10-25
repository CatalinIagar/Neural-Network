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
            dataPanel.setForm(this.generateBtn);

            this.Controls.Add(dataPanel);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (NeuralNetwork.NeuralNetwork.Instance.isGenerated == false)
            {
                GenerateNetwork generateNetwork = new GenerateNetwork();
                generateNetwork.Show();
            }
            else
            {
                _ = MessageBox.Show("Ai facut deja o retea", "kaka",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            }
        }
    }
}
