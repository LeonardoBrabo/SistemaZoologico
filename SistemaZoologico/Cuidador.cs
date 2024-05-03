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

        public void AlimentarAnimal(IAnimal criatura, string comidaAnimal ) {

            if (criatura is Animal animal)
            {
                if(animal.getComida().Equals(comidaAnimal))
                {
                    Console.WriteLine(animal.comer() + " El cuidador le dio de comer");

                }
                else
                {
                    Console.WriteLine("Comida Equivocada, el animal no come");
                }
            }
            else if (criatura is Planta planta) {

                
                if (planta.getComida().Equals(comidaAnimal))
                {
                    Console.WriteLine(planta.comer() + " El cuidador le dio de comer");

                }
                else
                {
                    if (planta.getTipoCarnivoro())
                    {
                        Console.WriteLine("Oh no, la planta carnivora se comio al cuidador!!!");

                        //TODO: Codigo para sacar al cuidador de la lista de de Cuidadores.
                        


                    }
                    else {

                        Console.WriteLine("Comida Equivocada, la planta no come");
                    }
                    
                }



                
                
            }
        
        }
    }
}
