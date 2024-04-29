using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    internal class Zoologico
    {
        private List<IAnimal> listaAnimalesDelZoo;
        private List<Cuidador> listaDeCuidadores;

        public Zoologico()
        {
            listaAnimalesDelZoo = new List<IAnimal>();
            listaDeCuidadores = new List<Cuidador>();
        }

        public void AgregarAnimal(IAnimal animal)
        {
            this.listaAnimalesDelZoo.Add(animal);
        }

        public void AgregarCuidador(Cuidador cuidador)
        {
            this.listaDeCuidadores.Add(cuidador);

        }

        public void AsignarCuidadorAnimal(IAnimal animaloPlanta, Cuidador cuidador)
        {
            //a la lista de animales a cargo del cuidador, añado el animal o planta pasado por parametro.
            cuidador.getAnimalesACargo().Add(animaloPlanta);

        }

        public void MostrarListaCuidadores() {
            Console.WriteLine("Lista de Los cuidadores disponibles en el zoologico");
            foreach (Cuidador cuidador in listaDeCuidadores)
            {
                Console.Write(cuidador.getNombreCuidador()+", ");
            }
            Console.WriteLine(" ");
        }

        public void MostrarListaAnimales() {
            Console.WriteLine("Lista de los animales que hay en el zoologico");
            foreach (IAnimal criatura in listaAnimalesDelZoo)
            {

                if (criatura is Animal animal)
                {

                    Console.WriteLine($"{animal.getNombre()} que es un {animal.getEspecie()}");

                }
                else if (criatura is Planta planta) {

                    Console.WriteLine($"{planta.getNombre()} que es una {planta.getTipo()}");

                }
                    

            }

        }
    }
}
