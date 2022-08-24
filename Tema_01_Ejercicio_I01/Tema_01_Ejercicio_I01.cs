using System;

namespace Tema_01_Ejercicio_I01
{
    internal class Tema_01_Ejercicio_I01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I1: Máximo, mínimo y promedio";

            /*
            Consigna:

            Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */


            int numero;
            int max = 0;
            int min = 0;
            float promedio = 0;
            int cantNumeros = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar número: ");

                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    min = numero;
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }

                //En esta linea, "promedio" funciona como acumulador.
                promedio = promedio + numero;

                cantNumeros++;
            }

            promedio = promedio / cantNumeros;


            Console.WriteLine($"El número máximo es: {max}, el número mínimo es: {min} y el promedio entre todos los números es: {promedio}");
        }
    }
}