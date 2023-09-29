using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upitarea1progra2
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("1-Ejercicio 1");
                Console.WriteLine("2-Ejercicio 2");
                Console.WriteLine("3-Ejercicio 3");
                Console.WriteLine("4-Salir");
                Console.WriteLine("Digite una opcion");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        break;
                    default:
                        break;

                }

            } while (opcion != 4);
        }
        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio de la camisa: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar : {cantidad * precio}");
            }
            else if (cantidad > 1 && cantidad < 6)
            {
                total = (cantidad * precio) * 0.15f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar : {total} con descuento de 15%");
            }
            else if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.2f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar : {total} con descuento de 20%");
            }
        }
        public static void Ejercicio2()
        {
            int cantidadEstudiantes;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            cantidadEstudiantes = int.Parse(Console.ReadLine());

            // Declaración de arreglos para almacenar los datos de los estudiantes
            string[] carnet = new string[cantidadEstudiantes];
            string[] nombre = new string[cantidadEstudiantes];
            double[] quiz = new double[cantidadEstudiantes];
            double[] tarea = new double[cantidadEstudiantes];
            double[] examen = new double[cantidadEstudiantes];

            // Leer los datos de cada estudiante
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nIngrese los datos del estudiante {i + 1}:");
                Console.Write("Carnet: ");
                carnet[i] = Console.ReadLine();
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Quiz 1: ");
                quiz[i] = double.Parse(Console.ReadLine());
                Console.Write("Quiz 2: ");
                quiz[i] += double.Parse(Console.ReadLine());
                Console.Write("Quiz 3: ");
                quiz[i] += double.Parse(Console.ReadLine());
                Console.Write("Tarea 1: ");
                tarea[i] = double.Parse(Console.ReadLine());
                Console.Write("Tarea 2: ");
                tarea[i] += double.Parse(Console.ReadLine());
                Console.Write("Tarea 3: ");
                tarea[i] += double.Parse(Console.ReadLine());
                Console.Write("Examen 1: ");
                examen[i] = double.Parse(Console.ReadLine());
                Console.Write("Examen 2: ");
                examen[i] += double.Parse(Console.ReadLine());
                Console.Write("Examen 3: ");
                examen[i] += double.Parse(Console.ReadLine());
            }

            // Calcular y mostrar el promedio final y la condición de cada estudiante
            Console.WriteLine("\nResultados:");
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                double porcentajeQuices = (quiz[i] / 30) * 25;
                double porcentajeTareas = (tarea[i] / 90) * 30;
                double porcentajeExamenes = (examen[i] / 300) * 45;

                double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;
                string condicion = "";

                if (promedioFinal >= 70)
                {
                    condicion = "Aprobado";
                }
                else if (promedioFinal >= 50)
                {
                    condicion = "Aplazado";
                }
                else
                {
                    condicion = "Reprobado";
                }

                Console.WriteLine($"\nEstudiante {i + 1} - Carnet: {carnet[i]}, Nombre: {nombre[i]}");
                Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices}%");
                Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas}%");
                Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes}%");
                Console.WriteLine($"Promedio Final: {promedioFinal:F2}");
                Console.WriteLine($"Condición: {condicion}");
            }
        }
        public static void Ejercicio3()
        {
            Console.Write("Ingrese la cantidad de productos a comprar: ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            double precioPorProducto;

            if (cantidadProductos <= 10)
            {
                precioPorProducto = 20.0;
            }
            else
            {
                precioPorProducto = 15.0;
            }

            double total = cantidadProductos * precioPorProducto;

            Console.WriteLine($"Precio por producto: ${precioPorProducto}");
            Console.WriteLine($"Total a pagar: ${total}");
        }

    }
} 
