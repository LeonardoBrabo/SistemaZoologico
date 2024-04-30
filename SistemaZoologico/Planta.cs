using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Planta : IAnimal
    {
        private string nombre;
        private string tipo;
        private bool tipoCarnivoro;
        private string comida;

        public Planta(string nombre, string tipo, bool tipoCarnivoro,string comida) {

            this.nombre = nombre;
            this.tipo = tipo;
            this.tipoCarnivoro = tipoCarnivoro;
            this.comida = comida;
        }

        public string getNombre() { return nombre; }
        public string getTipo() { return tipo; } 
        public bool getTipoCarnivoro() { return tipoCarnivoro; }
        public string getComida() { return comida; }

        public void setNombre(string nombre) { this.nombre = nombre; }

        public void setComida(string comida) { this.comida = comida; }

        public void Fotosintesis() {
            Console.WriteLine($"la {getTipo()} está haciendo la fotosintesis");
        }

        public string comer() //depues va a poder recibir algun tipo de animal(incluso un cuidador) si es carnivoro se lo saca de la lista, sino lo rechaza.
        {   
            return "La planta carnivora está comiendo!" ;
        }
    }
}
