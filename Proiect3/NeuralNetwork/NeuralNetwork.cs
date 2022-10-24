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
        public bool isGenerated = false;
        public List<NeuronLayer> layers = new List<NeuronLayer>();

        public int inputCount = typeof(BankDataNormalised).GetProperties().Length - 1;
        public int outputCount = 1;


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
            NeuronLayer inputLayer = new NeuronLayer(inputCount, Help.INPUT);
            layers.Add(inputLayer);
            for(int i = 0; i < nLayers; i++)
            {
                NeuronLayer hiddenLayer = new NeuronLayer(nNeurons[i], Help.HIDDEN);
                layers.Add(hiddenLayer);
            }
            NeuronLayer outputLayer = new NeuronLayer(outputCount, Help.OUTPUT);
            layers.Add(outputLayer);
        }
    }
}
