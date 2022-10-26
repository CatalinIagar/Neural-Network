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
        public NeuronLayer(int inputCount, string type, int prevCount)
        {
            this.nOfNeurons = inputCount;
            this.layerType = type;
            for (int i = 0; i < inputCount; i++)
            {
                Neuron neuron = new Neuron();
                Array.Resize(ref neuron.inputValue, prevCount);
                Array.Resize(ref neuron.weight, prevCount);
                Random random = new Random();
                double maximum = 1;
                double minimum = -1;
                for(int j = 0; j < prevCount; j++)
                {
                    neuron.weight[j] = random.NextDouble() * (maximum - minimum) + minimum;
                }
                neurons.Add(neuron);
            }
        }

        public List<double> getDeltas()
        {
            List<double> deltas = new List<double>();
            foreach(Neuron neuron in neurons)
            {
                deltas.Add(neuron.delta);
            }
            return deltas;
        }

        public void calculateOutput()
        {
            if(layerType == Help.INPUT)
            {
                foreach(Neuron neuron in neurons)
                {
                    neuron.output = neuron.inputValue[0];
                }
            }
            else
            {
                foreach(Neuron neuron in neurons)
                {
                    calculateInputValue(neuron);
                    calculateActivationValue(neuron);
                    calculateOutputValue(neuron);
                }
            }
        }

        private void calculateOutputValue(Neuron neuron)
        {
            neuron.output = neuron.activation;
        }

        private void calculateActivationValue(Neuron neuron)
        {
            double numarator = 1f;
            double numitor = 1 + Math.Exp(-1 * neuron.input);
            double act = numarator / numitor;

            neuron.activation = act;
        }

        private void calculateInputValue(Neuron neuron)
        {
            double sum = 0;
            for (int i = 0; i < neuron.inputValue.Length; i++)
            {
                sum += neuron.inputValue[i] * neuron.weight[i];
            }
            neuron.input = sum;
        }
    }
}