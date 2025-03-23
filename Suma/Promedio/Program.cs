using System;

namespace Suma_Promedio
{
    class Numeros
    {
        public int[] numeros { get; set; }
        public int suma { get; private set; }
        public double promedio { get; private set; }

        public Numeros(int[] numeros)
        {
            this.numeros = numeros;
            Sumar_Promedio();
        }

        public void Sumar_Promedio()
        {   
            suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }

            promedio = (double)suma / numeros.Length;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"La suma de los numeros es: {suma}");
            Console.WriteLine($"El promedio de los numeros es: {promedio}");
        }
    }

    class Program
    {
       static void Main(string[] args)
       {
            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 numeros enteros");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Numeros misNumeros = new Numeros(numeros);
            misNumeros.MostrarInfo();
       }
    }
}