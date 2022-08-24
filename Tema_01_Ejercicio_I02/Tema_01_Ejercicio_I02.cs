using System;

namespace Tema_01_Ejercicio_I02
{
    internal class Tema_01_Ejercicio_I02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I2: Error al cubo";

            /*
            Consigna:

            Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            IMPORTANTE: Utilizar el método Pow de la clase Math para calcular las potencias.
            */


            int numero;
            double cuadradoDelNumero;
            double cuboDelNumero;

            Console.Write("Ingrese un número: ");

            numero = int.Parse(Console.ReadLine());


            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");

                numero = int.Parse(Console.ReadLine());
            }

            cuadradoDelNumero = Math.Pow(numero, 2);
            cuboDelNumero = Math.Pow(numero, 3);


            Console.WriteLine($"{numero} elevado al cuadrado es: {cuadradoDelNumero}\nY elevado al cubo es: {cuboDelNumero}");
        }
    }
}
