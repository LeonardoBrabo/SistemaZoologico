namespace SistemaZoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación de animales y plantas
            Mamifero Elefante = new Mamifero("Trompita", "Elefante", "Mani");
            Ave Halcon = new Ave("HawkEyes", "Halcon", "semillas");
            Pez Tiburon = new Pez("Sharkboy", "Tiburon", "Carne cruda");
            Planta Plantita = new Planta("Filomena", "Planta Carnivora", true,"Minerales");


            //creación de cuidadores
            Cuidador empleado1 = new Cuidador("Gustavo");
            Cuidador empleado2 = new Cuidador("Andrea");

            //creación de un zoologico.
            Zoologico temaiken = new Zoologico();

            //se agregan animales a la lista de animales del zoo.
            temaiken.AgregarAnimal(Elefante);
            temaiken.AgregarAnimal(Halcon);
            temaiken.AgregarAnimal(Tiburon);
            temaiken.AgregarAnimal(Plantita);

            //se agregan cuiadores a la lista de cuidadores del zoo
            temaiken.AgregarCuidador(empleado1);
            temaiken.AgregarCuidador(empleado2);

            //asignación de animales a cada cuiadador
            temaiken.AsignarCuidadorAnimal(Elefante, empleado1);
            temaiken.AsignarCuidadorAnimal(Plantita, empleado1);
            temaiken.AsignarCuidadorAnimal(Halcon, empleado2);
            temaiken.AsignarCuidadorAnimal(Tiburon, empleado2);

            //mostrar las lista de cuidadores y de Animales del zoo
            temaiken.MostrarListaCuidadores();
            temaiken.MostrarListaAnimales();

            // prueba de los métodos propios de cada criatura dentro del zoo
            //temaiken.PresentarAnimal(Elefante);
            //temaiken.PresentarAnimal(Halcon);
            //temaiken.PresentarAnimal(Tiburon);
            //temaiken.PresentarAnimal(Plantita);

            //quitar animales de la lista de animales zoo

            //temaiken.QuitarAnimal("Willy"); //uno que no existe
            //temaiken.QuitarAnimal("Trompita"); //uno que si
            //temaiken.MostrarListaAnimales();

            //quitar cuidadores de la lista de cuidadores del zoo

            //temaiken.QuitarCuidador("Ernesto"); //uno que no existe
            //temaiken.QuitarCuidador("Gustavo"); //uno que si existe
            //temaiken.MostrarListaCuidadores();

            //Actualizar el nombre de un Cuidador
            temaiken.ActualizarCuidador("Sancho","Pedrito");

            temaiken.MostrarListaCuidadores();

            temaiken.ActualizarCuidador("Gustavo", "Pedrito");

            temaiken.MostrarListaCuidadores();


        }
    }

    
    
}
