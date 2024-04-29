using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Cuidador //luego heredar de animal para que se lo pueda morfar la planta jeje.
    {
        private string nombreCuidador;

        private List<IAnimal> animalesACargo;

        public Cuidador(string nombre) {
            this.nombreCuidador = nombre;
            animalesACargo = new List<IAnimal>();
        }

       public string getNombreCuidador() {  return nombreCuidador; }

        public void setNombreCuidador(string nuevoNombre) {
            this.nombreCuidador = nuevoNombre;
        }

       public List<IAnimal> getAnimalesACargo()
        {
            return animalesACargo;
        }

        public void VerAnimalesACargo() {

           //puede contener tanto animales como la plantacarnivora. pero para acceder
            //TODO:


          
        }

    }
}
