using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Pez : Animal
    {
        
        public Pez(string nombre, string especie, string comida) :base(nombre, especie, comida) { }

        public void Nadar() { Console.WriteLine($"El {getEspecie()} está nadando"); }

        public override string comer()
        {
            return "soy un pez y "+base.comer();
        }

    }
}
