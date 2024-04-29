using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Ave : Animal
    {
        public Ave(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void Volar() { Console.WriteLine($"El {getEspecie()} esta volando"); }

        public override string comer()
        {
            return "soy un ave y " + base.comer();
        }
    }
    
}
