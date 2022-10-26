using System;
using System.Windows.Forms;
using Proiect3.Classes;

namespace Proiect3
{
    public partial class GenerateNetwork : Form
    {
        public int[] ReturnValue { get; set; }
        RoundButton rb;
        public GenerateNetwork(RoundButton rb)
        {
            InitializeComponent();

            this.rb = rb;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.ReturnValue = new int[6];

            this.KeyPress += new KeyPressEventHandler(CheckReturnKeyPress);

            int count = typeof(BankDataNormalised).GetProperties().Length;

            this.hidden1NeuronsInput.Minimum = (count - 1) * 2;
            this.hidden1NeuronsInput.Maximum = (count - 1) * 10;

            this.hidden2NeuronsInput.Minimum = (count - 1) * 2;
            this.hidden2NeuronsInput.Maximum = (count - 1) * 10;

            this.hidden3NeuronsInput.Minimum = (count - 1) * 2;
            this.hidden3NeuronsInput.Maximum = (count - 1) * 10;
        }

        private void CheckReturnKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter) GenerateNetowrkClick();
        }

        private void LayersInput_ValueChanged(object sender, EventArgs e)
        {
            if(layersInput.Value == 3)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = true;
                hidden3Lbl.Visible = true;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = true;
                hidden3NeuronsInput.Visible = true;
            }
            if(layersInput.Value == 2)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = true;
                hidden3Lbl.Visible = false;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = true;
                hidden3NeuronsInput.Visible = false;
            }
            if (layersInput.Value == 1)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = false;
                hidden3Lbl.Visible = false;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = false;
                hidden3NeuronsInput.Visible = false;
            }
        }
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            GenerateNetowrkClick();
        }

        private void GenerateNetowrkClick()
        {
            int nLayers = (int)layersInput.Value;
            int[] nNeurons = new int[0];

            int i = 0;
            foreach(Control control in this.Controls)
            {
                if (control.Name.Contains("NeuronsInput")) 
                {
                    NumericUpDown nr = control as NumericUpDown;
                    i++;
                    Array.Resize(ref nNeurons, i);
                    nNeurons[i - 1] = (int)nr.Value;
                }
                if (i == nLayers) break;
            }

            NeuralNetwork.NeuralNetwork.Instance.GenerateNetwork(nLayers, nNeurons);
            rb.Visible = true;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
