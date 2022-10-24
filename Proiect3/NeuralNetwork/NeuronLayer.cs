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
    public class NeuronLayer
    {
        public List<Neuron> neurons = new List<Neuron>();
        public int nOfNeurons;
        public string layerType;
        public NeuronLayer(int inputCount, string type)
        {
            this.nOfNeurons = inputCount;
            this.layerType = type;
            for (int i = 0; i < inputCount; i++)
            {
                Neuron neuron = new Neuron();
                Array.Resize(ref neuron.inputValue, inputCount);
                Array.Resize(ref neuron.weight, inputCount);
                Random random = new Random();
                double maximum = 1;
                double minimum = -1;
                for(int j = 0; j < inputCount; j++)
                {
                    neuron.weight[j] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                }
                neurons.Add(neuron);
            }
        }

        public void calculateOutput()
        {
            if(layerType == Help.INPUT)
            {
                foreach(Neuron neuron in neurons)
                {
                    neuron.output = neuron.input;
                }
            }
            else
            {
                calculateInputValue();
                calculateActivationValue();
                calculateOutputValue();
            }
        }

        private void calculateOutputValue()
        {
            foreach(Neuron neuron in neurons)
            {
                neuron.output = neuron.activation;
            }
        }

        private void calculateActivationValue()
        {
            foreach(Neuron neuron in neurons)
            {
                double numarator = 1f;
                double numitor = 1 + Math.Exp(-1);
                double act = numarator / numitor;

                neuron.activation = act;
            }
        }

        private void calculateInputValue()
        {
            foreach (Neuron neuron in neurons)
            {
                double sum = 0;
                for (int i = 0; i < nOfNeurons; i++)
                {
                    sum += neuron.inputValue[i] * neuron.weight[i];
                }
                neuron.input = sum;
            }
        }
    }
}