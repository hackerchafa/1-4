using System;

namespace Ordenamiento
{
    class Ordenamiento
    {
        public int[] array { get; set; }
        public int cantidad { get; set; }

        public Ordenamiento(int[] array, int cantidad)
        {
            this.array = array;
            this.cantidad = cantidad;
            BubbleSort(array);
        }

        public void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void mostrarInfo()
        {
            Console.WriteLine($"\nNumeros ordenados: ");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros deseas ordenar?");
            int cantidad = int.Parse(Console.ReadLine());

            int[] array = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingresa el numero {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Ordenamiento miOrdenamiento = new Ordenamiento(array, cantidad);
            miOrdenamiento.mostrarInfo();
        }
    }
}