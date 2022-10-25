using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using Proiect3.Classes;

namespace Proiect3.NeuralNetwork
{
    internal class NeuralNetwork
    {

        public double learningRate;
        public int epoch = 1;
        public bool isGenerated = false;
        public List<NeuronLayer> layers = new List<NeuronLayer>();

        public int inputCount = typeof(BankDataNormalised).GetProperties().Length - 1;
        public int outputCount = 1;
        public int nOfHiddenLayers;


        private NeuralNetwork()
        {

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
            for(int i = 0; i < nLayers; i++)
            {
                NeuronLayer hiddenLayer = new NeuronLayer(nNeurons[i], Help.HIDDEN, layers[i].nOfNeurons);
                layers.Add(hiddenLayer);
            }
            NeuronLayer outputLayer = new NeuronLayer(outputCount, Help.OUTPUT, layers[nLayers].nOfNeurons);
            layers.Add(outputLayer);
        }

        public void TrainNetowrk()
        {
            List<double> mse = new List<double>();
            List <BankDataNormalised> trainingData = (List<BankDataNormalised>)NetworkData.Instance.GetTrainingData();
            for (int i = 0; i < epoch; i++)
            {
                foreach(BankDataNormalised data in trainingData)
                {
                    LoadDataIntoNetowrk(data);
                    FeedForward();
                    double error = CalculateError();
                    mse.Add(error);
                    Console.WriteLine(error);
                    //BackPropagation();
                }
                //double epochError = CalculateEpochError(mse);
                //Console.WriteLine(epochError);
            }   
        }

        private double CalculateError()
        {
            double sum = 0;
            for(int i = 0; i < outputCount; i++)
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

        private void TransferData(NeuronLayer leftLayer ,NeuronLayer rightLayer)
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
            foreach(NeuronLayer layer in layers)
            {
                if(layer.layerType == Help.INPUT)
                {
                    int i = 0;
                    foreach(PropertyInfo property in properties)
                    {
                        if (property.Name == "Outcome") break;
                        layer.neurons[i].inputValue[0] = (double)property.GetValue(data, null);
                        i++;
                    }
                }
                if(layer.layerType == Help.OUTPUT)
                {
                    layer.neurons[0].targetOutput = data.Outcome;
                }
            }
        }

        /*private async Task<double> CalculateErrorAsync()
        {
            for(int i = 0; i < epoch; i++)
            {
                Task<double> calculateError = CalculateErrorAsync();
                
                currentError = await calculateError;

                Console.WriteLine(currentError);
            }
            return -1;
        }*/
    }
}
