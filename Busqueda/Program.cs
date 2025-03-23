using System;

namespace Busqueda
{
    class Busqueda
    {
        public string[] nombres { get; set; }
        public string nombreBuscar { get; private set; }

        public Busqueda(string[] nombres, string nombreBuscar)
        {
            this.nombres = nombres;
            this.nombreBuscar = nombreBuscar;
            Buscar();
        }

        public void Buscar()
        {
            bool encontrado = false;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == nombreBuscar)
                {
                    Console.WriteLine("El nombre {0} se encuentra en la posicion {1}", nombreBuscar, i + 1);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El nombre {0} no se encuentra en la lista", nombreBuscar);
            }
        }

    }

    class Program 
    {
        static void Main(string[] args)
        {
            string[] nombres = new string [5];

            Console.WriteLine("Escribe 5 nombres");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Nombre {0}", i + 1);
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("\nIngrese el nombre a buscar");
            string nombreBuscar = Console.ReadLine();

            Busqueda miBusqueda = new Busqueda(nombres, nombreBuscar);
        }
    }
}