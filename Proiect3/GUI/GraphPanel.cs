using Proiect3.NeuralNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Proiect3.NeuralNetwork;

using ZedGraph;

namespace Proiect3.GUI
{
    public partial class GraphPanel : UserControl
    {
        GraphPane graph;
        PointPairList pointPairs = new PointPairList();
        private GraphPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            graph = zedGraphControl1.GraphPane;
            graph.AddCurve("Epoch Error", pointPairs, Color.Red, SymbolType.None);

            graph.XAxis.Title.Text = "Epochs (0.01 = 1 epoch)";
            graph.YAxis.Title.Text = "Error";
        }
        private static GraphPanel instance = null;
        public static GraphPanel Instance
        {
            get
            {
                if (instance == null) instance = new GraphPanel();
                return instance;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.startBtn.Enabled = false;

            ResetNetwork();

            NeuralNetwork.NeuralNetwork.Instance.shouldStart = true;

            NeuralNetwork.NeuralNetwork.Instance.learningRate = (double)learningValue.Value;
            NeuralNetwork.NeuralNetwork.Instance.epoch = (int)epochValue.Value;
            NeuralNetwork.NeuralNetwork.Instance.targetError = (double)errorValue.Value;

            this.learningValue.Enabled = false;
            this.epochValue.Enabled = false;
            this.errorValue.Enabled = false;

            progressBar.Maximum = (int)epochValue.Value - 1;
            progressBar.Minimum = 0;

            NeuralNetwork.NeuralNetwork.Instance.worker.RunWorkerAsync();
        }

        private void ResetNetwork()
        {
            pointPairs.Clear();
            Random random = new Random();
            double maximum = 1;
            double minimum = -1;
            foreach (NeuronLayer layer in NeuralNetwork.NeuralNetwork.Instance.layers)
            {
                foreach(Neuron neuron in layer.neurons)
                {
                    for(int i = 0; i < neuron.weight.Length; i++)
                    {
                        neuron.weight[i] = random.NextDouble() * (maximum - minimum) + minimum;
                    }
                }
            }
        }

        internal void UpdateProgressBar(int progressPercentage, object userState)
        {
            double value = (double)userState;
            this.currentErrorValue.Value = (decimal)value;

            if(progressPercentage == -1)
            {
                string message = "This thing actually worked :)";
                string caption = "Target error reached";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                RestartUI();
            }
            else
            {
                progressBar.Value = progressPercentage;


                PointPair pointPair = new PointPair(progressPercentage * 0.01, value);
                pointPairs.Add(pointPair);

                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();

                if (progressPercentage == (int)epochValue.Value - 1) RestartUI();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            RestartUI();
        }

        public void RestartUI()
        {
            NeuralNetwork.NeuralNetwork.Instance.shouldStart = false;
            this.startBtn.Enabled = true;
            this.learningValue.Enabled = true;
            this.epochValue.Enabled = true;
            this.errorValue.Enabled = true;
        }
    }
}
