namespace SistemaZoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mamifero Elefante = new Mamifero("Trompita", "Elefante", "Mani");
            Ave Halcon = new Ave("HawkEyes", "Halcon", "semillas");
            Pez Tiburon = new Pez("Sharkboy", "Tiburon", "Carne cruda");
            Planta Plantita = new Planta("Filomena", "Planta Carnivora", true);

            Cuidador empleado1 = new Cuidador("Gustavo");

            Cuidador empleado2 = new Cuidador("Andrea");


            Zoologico temaiken = new Zoologico();

            temaiken.AgregarAnimal(Elefante);
            temaiken.AgregarAnimal(Halcon);
            temaiken.AgregarAnimal(Tiburon);
            temaiken.AgregarAnimal(Plantita);

            temaiken.AgregarCuidador(empleado1);
            temaiken.AgregarCuidador(empleado2);

            temaiken.AsignarCuidadorAnimal(Elefante, empleado1);
            temaiken.AsignarCuidadorAnimal(Plantita, empleado1);
            temaiken.AsignarCuidadorAnimal(Halcon, empleado2);
            temaiken.AsignarCuidadorAnimal(Tiburon, empleado2);

            temaiken.MostrarListaCuidadores();
            temaiken.MostrarListaAnimales();

        }
    }

    
    
}
