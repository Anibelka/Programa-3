using System;
using System.Net.NetworkInformation;

class SumayProducto
{
    static void Main(string[] args)
    {
        decimal numero1 = Numero("Ingrese el primer número: ");
        decimal numero2 = Numero("Ingrese el segundo número: ");
        decimal numero3 = Numero("Ingrese el tercer número: ");
        decimal numero4 = Numero("Ingrese el cuarto número: ");

        decimal suma = numero1 + numero2 + numero3 + numero4;
        decimal promedio = suma / 4;

        Console.WriteLine("La suma de los cuatro números es: " + suma);
        Console.WriteLine("El promedio de los cuatro números es: " + promedio);

        Console.ReadLine();
    }

    static decimal Numero(string mensaje)
    {
        decimal num;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            esValido = decimal.TryParse(Console.ReadLine(), out num);

            if (!esValido)
            {
                Console.WriteLine("\n" + "El valor ingresado no es válido." + "\n" + "Por favor, ingrese un número." + "\n");
            }
        } while (!esValido);

        return num;
    }
}