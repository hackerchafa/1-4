using System;

namespace Inversa
{
    class Inversa
    {
        public int[] array { get; set; }
        public int numeros { get; private set; }

        public Inversa(int[] array, int numeros)
        {
            this.array = array;
            this.numeros = numeros;
        }

        public void inversa()
        {
            Console.WriteLine("\nNumeros ingresados: ");

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\nNumeros en orden inverso: ");

            for (int i = numeros - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
    class Program 
    {
        static void Main(string[] args)
        {
            int numeros = 5;
            int[] array = new int[5];

            Console.WriteLine("Ingrese 5 numeros");

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("\nIngresa el numero {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Inversa miInversa = new Inversa(array, numeros);
            miInversa.inversa();
        }
    }
}