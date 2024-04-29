using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Animal : IAnimal
    {
        protected string nombre;
        protected string especie;
        protected string comida;

        public Animal(string nombre, string especie, string comida)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
        }

        public string getNombre() {return this.nombre; }
        public string getEspecie() { return this.especie; }
        public string getComida() { return this.comida;}

        public void setComida(string nuevaComida) { this.comida = nuevaComida; }

        public virtual string comer() { return $"estoy comiendo {comida}"; }
        
    }
}
