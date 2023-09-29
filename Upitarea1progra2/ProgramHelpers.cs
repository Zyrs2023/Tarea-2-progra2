using System;

internal static class ProgramHelpers
{
    public static void Ejercicio3()
    {
        // Pedir al usuario la cantidad de artículos comprados
        Console.Write("Ingrese la cantidad de artículos comprados: ");
        int cantidadArticulos = int.Parse(Console.ReadLine());

        // Definir los precios por artículo
        const double precioPorArticuloMenosDe10 = 20.0;
        const double precioPorArticuloMasDe10 = 15.0;

        double precioPorArticulo;
        double total;

        // Determinar el precio por artículo y calcular el total
        if (cantidadArticulos <= 10)
        {
            precioPorArticulo = precioPorArticuloMenosDe10;
        }
        else
        {
            precioPorArticulo = precioPorArticuloMasDe10;
        }

        total = cantidadArticulos * precioPorArticulo;

        // Mostrar el precio por artículo y el total
        Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
        Console.WriteLine($"Total a pagar: ${total}");
    }
}