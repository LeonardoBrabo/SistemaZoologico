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

        public Planta(string nombre, string tipo, bool tipoCarnivoro) {

            this.nombre = nombre;
            this.tipo = tipo;
            this.tipoCarnivoro = tipoCarnivoro;
        }

        public string getNombre() { return nombre; }
        public string getTipo() { return tipo; } 
        public bool getTipoCarnivoro() { return tipoCarnivoro; } //cambiar para que luego sea un bool de carnivoro


        public string comer() //depues va a poder recibir algun tipo de animal(incluso un cuidador) si es carnivoro se lo saca de la lista, sino lo rechaza.
        {   
            return "La planta carnivora está comiendo!" ;
        }
    }
}
