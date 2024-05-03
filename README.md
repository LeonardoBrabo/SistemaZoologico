# SistemaZoologico
Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores. El sistema debe permitir la creación y gestión de diferentes tipos de animales, incluyendo mamíferos, aves, peces y una planta carnívora. Cada animal debe tener un nombre, una especie y un tipo de comida asociado. Los mamíferos deben ser capaces de amamantar, las aves deben poder volar y los peces deben poder nadar. Además, se requiere la capacidad de crear una planta carnívora que se alimente de otros seres vivos.

Los cuidadores serán responsables de alimentar a los animales. Cada cuidador debe tener un nombre y ser capaz de alimentar a los animales bajo su cuidado con la comida adecuada. Esto incluye tanto a los animales convencionales como a la planta carnívora.

El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores. Esto implica la capacidad de agregar, eliminar y actualizar la información de los animales y cuidadores. Además, el zoológico debe ser capaz de mostrar la lista de animales y cuidadores disponibles.

El sistema debe ser implementado en C# y ejecutarse por consola. Los alumnos deberán utilizar herencia, polimorfismo, interfaces y métodos virtuales para garantizar la flexibilidad y extensibilidad del sistema. Además, se debe implementar la inyección de dependencias para permitir que los cuidadores alimenten a cualquier tipo de animal, incluida la planta carnívora.

### Lista de Implementaciones:

- [x]  Creación de Animales, diferentes , inclusive mamíferos, aves y peces.
- [x]  cada animal debe tener un nombre, una especie y un tipo de comida asociado.
- [x]  Los mamíferos debe ser capaces de amamantar, las aves de volar y los peces de nadar.//se crea un método del zoo que se llame mostrar animal, que muestre el nombre y lo que es capaz de hacer.
- [x]  el zoológico debe tener la capacidad de agregar, eliminar y actualizar  la información de los animales y los cuidadores.
    - [x]  agregar animales y cuidadores. de su lista
    - [x]  eliminar animales y cuidadores de su lista
    - [X]  actualizar la información de los animales y de los cuidadores de su lista.
- [x]  Un Método Alimentar, para que el cuidador alimente a los animales de sus lista de animales asignados, verificar si la comida ingresada es del tipo que quiere el animal , si no puede comer.
- [x]  EXTRA si al dar de comer a la planta carnivora el alimento equivocado ésta se come al cuidador, y se quita al cuidador de la lista del cuidadores del zoo
- [ ]  EXTRA MUY EXTRA: menús interactivos para ingresar los datos, y elegir opciones.
