using System;

class EjercicioCarta01
{
    static void Main(string[] args)
    {
        int contador = 0;
        int suma = 0;
        int nroCarta;

        while (contador < 5)
        {
            Console.Write($"Ingrese el nro de la {contador + 1}° carta: ");
            nroCarta = int.Parse(Console.ReadLine());

            suma += nroCarta; // variable que oficia de acumulador
            contador++; // variable que oficia de contador
        }

        Console.WriteLine($"La suma de las primeras cinco cartas es {suma}");
    }
}
