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
        public List<int> neurons = new List<int>();
        public int nOfNeurons;
        public string layerType;
        public NeuronLayer(int inputCount, string type)
        {
            this.nOfNeurons = inputCount;
            this.layerType = type;
            for (int i = 0; i < inputCount; i++)
            {
                int a = i;
                neurons.Add(a);
            }
        }
    }
}