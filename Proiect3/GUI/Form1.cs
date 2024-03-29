﻿using Proiect3.GUI;
using System;
using System.Windows.Forms;

namespace Proiect3
{
    public partial class Form1 : Form
    {
        GraphPanel graphPanel;
        DataPanel dataPanel;
        TestPanel testPanel;
        InputPanel inputPanel;
        public Form1()
        {
            InitializeComponent();

            dataBtn.Click += (sender, e) => LoadDataPanel(sender, e);
            this.MaximizeBox = false;

        }

        private void LoadGraphPanel()
        {
            graphPanel = GraphPanel.Instance;

            this.Controls.Remove(dataPanel);
            this.Controls.Remove(testPanel);
            this.Controls.Remove(inputPanel);
            this.Controls.Add(graphPanel);
        }

        private void LoadDataPanel(object sender, EventArgs e)
        {
            dataPanel = DataPanel.Instance;
            dataPanel.SetForm(this.generateBtn);

            this.Controls.Remove(graphPanel);
            this.Controls.Remove(testPanel);
            this.Controls.Remove(inputPanel);
            this.Controls.Add(dataPanel);
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (NeuralNetwork.NeuralNetwork.Instance.isGenerated == false)
            {
                GenerateNetwork generateNetwork = new GenerateNetwork(this.testBtn, this.inputBtn);
                var result = generateNetwork.ShowDialog();
                if (result == DialogResult.OK) LoadGraphPanel();
            }
            else
            {
                LoadGraphPanel();
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            testPanel = TestPanel.Instance;

            this.Controls.Remove(graphPanel);
            this.Controls.Remove(dataPanel);
            this.Controls.Remove(inputPanel);
            this.Controls.Add(testPanel);
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            inputPanel = InputPanel.Instance;

            this.Controls.Remove(graphPanel);
            this.Controls.Remove(dataPanel);
            this.Controls.Remove(testPanel);
            this.Controls.Add(inputPanel);
        }
    }
}
