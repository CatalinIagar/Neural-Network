using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.ComponentModel;


using Proiect3.Classes;
using Proiect3.GUI;

namespace Proiect3.NeuralNetwork
{
    internal class NeuralNetwork
    {

        public double learningRate = 0.0001;
        public int epoch = 100;
        public double targetError = 0.01;
        public bool isGenerated = false;
        public bool shouldStart = false;
        public List<NeuronLayer> layers = new List<NeuronLayer>();

        public int inputCount = typeof(BankDataNormalised).GetProperties().Length - 1;
        public int outputCount = 1;
        public int nOfHiddenLayers;

        public BackgroundWorker worker = new BackgroundWorker();
        private NeuralNetwork()
        {
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.WorkerReportsProgress = true;
        }
        private static NeuralNetwork instance = null;
        public static NeuralNetwork Instance
        {
            get
            {
                if (instance == null) instance = new NeuralNetwork();
                return instance;
            }
        }
        public void GenerateNetwork(int nLayers, int[] nNeurons)
        {
            isGenerated = true;
            NeuronLayer inputLayer = new NeuronLayer(inputCount, Help.INPUT, 1);
            layers.Add(inputLayer);
            this.nOfHiddenLayers = nLayers;
            for (int i = 0; i < nLayers; i++)
            {
                NeuronLayer hiddenLayer = new NeuronLayer(nNeurons[i], Help.HIDDEN, layers[i].nOfNeurons);
                layers.Add(hiddenLayer);
            }
            NeuronLayer outputLayer = new NeuronLayer(outputCount, Help.OUTPUT, layers[nLayers].nOfNeurons);
            layers.Add(outputLayer);
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<double> mse = new List<double>();
            List<BankDataNormalised> trainingData = (List<BankDataNormalised>)NetworkData.Instance.GetTrainingData();
            for (int i = 0; i < epoch; i++)
            {
                foreach (BankDataNormalised data in trainingData)
                {
                    LoadDataIntoNetowrk(data);
                    FeedForward();
                    double error = CalculateError();
                    mse.Add(error);
                    BackPropagation();

                }

                double epochError = CalculateEpochError(mse);

                if (epochError < targetError)
                {
                    shouldStart = false;
                    worker.ReportProgress(-1, epochError);
                }

                if (shouldStart == false) break;

                worker.ReportProgress(i, epochError);
            }
        }

        public void TestData()
        {
            List<BankDataTest> dataList = (List<BankDataTest>)NetworkData.Instance.GetTestingData();
            foreach (BankDataTest data in dataList)
            {
                LoadTestDataIntoNetowrk(data);
                FeedForward();
                data.CurrentOutcome = layers[layers.Count - 1].neurons[0].output;
                data.Error = Math.Abs(data.Outcome - data.CurrentOutcome);
            }
        }

        private void worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            GraphPanel.Instance.UpdateProgressBar(e.ProgressPercentage, e.UserState);
        }
        private double CalculateEpochError(List<double> mse)
        {
            double error = 0;
            foreach (double value in mse)
            {
                error += value;
            }
            error /= mse.Count;
            return error;
        }

        private void BackPropagation()
        {
            for (int i = layers.Count - 1; i >= 1; i--)
            {
                if (layers[i].layerType == Help.OUTPUT)
                {
                    foreach (Neuron neuron in layers[i].neurons)
                    {
                        double delta = (neuron.output - neuron.targetOutput) * neuron.activation * (1 - neuron.activation);
                        neuron.delta = delta;
                        for (int k = 0; k < neuron.weight.Length; k++)
                        {
                            double deltaWeight = this.learningRate * layers[i - 1].neurons[k].output * delta;
                            neuron.weight[k] -= deltaWeight;
                        }
                    }
                }
                if (layers[i].layerType == Help.HIDDEN)
                {
                    for (int j = 0; j < layers[i].nOfNeurons; j++)
                    {
                        double deltaS = 0;
                        List<double> deltaLayer = layers[i + 1].getDeltas();
                        for (int k = 0; k < layers[i + 1].neurons.Count; k++)
                        {
                            deltaS += layers[i + 1].neurons[k].weight[j] * deltaLayer[k];
                        }
                        double delta = deltaS * layers[i].neurons[j].activation * (1 - layers[i].neurons[j].activation);
                        layers[i].neurons[j].delta = delta;

                        for (int k = 0; k < layers[i].neurons[j].weight.Length; k++)
                        {
                            double deltaWeight = this.learningRate * layers[i - 1].neurons[k].output * delta;
                            layers[i].neurons[j].weight[k] -= deltaWeight;
                        }
                    }
                }
            }
        }

        private double CalculateError()
        {
            double sum = 0;
            for (int i = 0; i < outputCount; i++)
            {
                sum += Math.Pow((getTargetOutput() - getOutput()), 2);
            }
            sum = sum / (2 * outputCount);
            return sum;
        }

        public double getOutput()
        {
            return layers[nOfHiddenLayers + 1].neurons[outputCount - 1].output;
        }

        public double getTargetOutput()
        {
            return layers[nOfHiddenLayers + 1].neurons[outputCount - 1].targetOutput;
        }

        private void FeedForward()
        {
            layers[0].calculateOutput();
            TransferData(layers[0], layers[1]);

            for (int i = 1; i <= nOfHiddenLayers; i++)
            {
                layers[i].calculateOutput();
                TransferData(layers[i], layers[i + 1]);
            }

            layers[nOfHiddenLayers + 1].calculateOutput();
        }

        private void TransferData(NeuronLayer leftLayer, NeuronLayer rightLayer)
        {
            for (int i = 0; i < rightLayer.neurons.Count; i++)
            {
                for (int j = 0; j < rightLayer.neurons[i].inputValue.Length; j++)
                {
                    rightLayer.neurons[i].inputValue[j] = leftLayer.neurons[j].output;
                }
            }
        }

        private void LoadDataIntoNetowrk(BankDataNormalised data)
        {
            PropertyInfo[] properties = typeof(BankDataNormalised).GetProperties();
            foreach (NeuronLayer layer in layers)
            {
                if (layer.layerType == Help.INPUT)
                {
                    int i = 0;
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name == "Outcome") break;
                        layer.neurons[i].inputValue[0] = (double)property.GetValue(data, null);
                        i++;
                    }
                }
                if (layer.layerType == Help.OUTPUT)
                {
                    layer.neurons[0].targetOutput = data.Outcome;
                }
            }
        }

        private void LoadTestDataIntoNetowrk(BankDataTest data)
        {
            PropertyInfo[] properties = typeof(BankDataTest).GetProperties();
            foreach (NeuronLayer layer in layers)
            {
                if (layer.layerType == Help.INPUT)
                {
                    int i = 0;
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name == "Outcome") break;
                        layer.neurons[i].inputValue[0] = (double)property.GetValue(data, null);
                        i++;
                    }
                }
                if (layer.layerType == Help.OUTPUT)
                {
                    layer.neurons[0].targetOutput = data.Outcome;
                }

            }
        }
    }
}
