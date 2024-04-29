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

        public void PresentarAnimal(IAnimal animaloPlanta) {

            if (animaloPlanta is Animal animal) {   //preguntamos si la criatura es un animal o planta... Si es animal:

                Console.WriteLine
               ($"Les presentamos a {animal.getNombre()} que es un/una {animal.getEspecie()}, le gusta comer {animal.getComida()} ");
                Console.WriteLine();

                Console.WriteLine("Miren lo que está haciendo!!!"); //preguntamos si el animal es un... y los parseamos para llamar a sus métodos.
                if (animal is Mamifero mamifero) mamifero.Amamantar();
                else if (animal is Pez pecesito) pecesito.Nadar();
                else if (animal is Ave avecita) avecita.Volar();
              
            
            }else if (animaloPlanta is Planta planta) //si es planta
            {
                Console.WriteLine
               ($"Les presentamos a {planta.getNombre()} que es un/una {planta.getTipo()}, le gusta comer {planta.getComida()} ");
                Console.WriteLine("Miren lo que está haciendo!!!");
                planta.Fotosintesis();

            }
        
        }

        public void QuitarCuidador(string nombreCuidador)
        {
            bool encontrado = false;
            for(int i = 0; i < listaDeCuidadores.Count(); i++)
            {
                //con el metido indexOf, busco el indice del cuidador que quiero eliminar.
                if (listaDeCuidadores[i].getNombreCuidador().Equals(nombreCuidador))
                {
                    listaDeCuidadores.RemoveAt(i);
                    Console.WriteLine($"El cuidador {nombreCuidador} ha sido eliminado de la lista de cuidadores");
                    encontrado = true;
                }

            }
            if (!encontrado) Console.WriteLine("El cuidador no se encuentra en la lista de cuidadores");

        }

        public void QuitarAnimal(string nombreCriatura) {

            bool encontrado = false;
            for (int i = 0; i < listaAnimalesDelZoo.Count(); i++)
            {
                if (listaAnimalesDelZoo[i] is Animal animal)
                {
                    if (animal.getNombre().Equals(nombreCriatura)) {
                        listaAnimalesDelZoo.RemoveAt(i);
                        Console.WriteLine($"El animal {animal.getNombre()} se ha eliminado de la lista");
                        encontrado = true;
                    }

                }else if (listaAnimalesDelZoo[i] is Planta planta)
                {
                    if (planta.getNombre().Equals(nombreCriatura))
                    {
                        listaAnimalesDelZoo.RemoveAt(i);
                        Console.WriteLine($"La planta {planta.getNombre()} se ha eliminado de la lista");
                        encontrado = true;
                    }

                }

            }

            if (!encontrado) { Console.WriteLine("El animal o la planta no se encuentran en la lista."); }
        
        }
    }
}
