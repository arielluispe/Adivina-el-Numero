using System;

namespace DivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 10); // Genera un número aleatorio entre 1 y 100
            Console.WriteLine("Adivina el número secreto:");

            int intentos = 0;
            bool adivinado = false;

            while (!adivinado)
            {
                int respuesta = int.Parse(Console.ReadLine());
                intentos++;

                if (respuesta == numeroSecreto)
                {
                    adivinado = true;
                    Console.WriteLine("¡Felicidades, adivinaste el número secreto en " + intentos + " intentos!");
                }
                else if (respuesta < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor que tu respuesta.");
                }
                else
                {
                    Console.WriteLine("El número secreto es menor que tu respuesta.");
                }
            }
        }
    }
}
