using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Mamifero : Animal
    {
        public Mamifero(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void Amamantar(string especieAnimal) {
            Console.WriteLine($"El {especieAnimal} está amamantando");
        }

        public override string comer()
        {
            return "Soy un animal mamifero y "+base.comer();
        }

    }
}
