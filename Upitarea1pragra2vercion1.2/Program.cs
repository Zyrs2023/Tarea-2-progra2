using System;

namespace Upitarea1progra2
{
    class Program
    {
        static int cantidadEstudiantes; // Variable global para la cantidad de estudiantes

        static void Main(string[] args)
        {
            Menu(); // Llama a la función principal del programa
        }

        // Función principal del menú
        public static void Menu()
        {
            int opcion = 0;

            do
            {
                // Mostrar opciones del menú
                Console.WriteLine("1-Ejercicio 1");
                Console.WriteLine("2-Ejercicio 2");
                Console.WriteLine("3-Ejercicio 3");
                Console.WriteLine("4-Salir");
                Console.WriteLine("Digite una opcion");

                opcion = int.Parse(Console.ReadLine()); // Leer la opción ingresada por el usuario

                // Lógica para ejecutar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1(); // Llama a la función del Ejercicio 1
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2(); // Llama a la función del Ejercicio 2
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3(); // Llama a la función del Ejercicio 3
                        break;
                    default:
                        break;
                }

            } while (opcion != 4); // El bucle se ejecuta hasta que el usuario elige salir (opción 4)
        }

        // Función para el Ejercicio 1
        public static void Ejercicio1()
        {
            float precioCamisa;
            int cantidadCamisas;

            // Leer precio y cantidad de camisas
            Console.WriteLine("Digite el precio de la camisa: ");
            precioCamisa = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas: ");
            cantidadCamisas = int.Parse(Console.ReadLine());

            float totalPagar = CalcularTotalPagar(precioCamisa, cantidadCamisas); // Llama a la función para calcular el total a pagar
            Console.WriteLine($"Total a pagar : {totalPagar}");
        }

        // Función para el Ejercicio 2
        public static void Ejercicio2()
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            cantidadEstudiantes = int.Parse(Console.ReadLine());

            string[] carnet = new string[cantidadEstudiantes];
            string[] nombre = new string[cantidadEstudiantes];
            double[] promedioFinal = new double[cantidadEstudiantes];

            // Loop para ingresar datos de los estudiantes
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nIngrese los datos del estudiante {i + 1}:");
                carnet[i] = LeerDato("Carnet"); // Llama a la función para leer el carnet
                nombre[i] = LeerDato("Nombre"); // Llama a la función para leer el nombre
                promedioFinal[i] = CalcularPromedioEstudiante(); // Llama a la función para calcular el promedio final del estudiante
            }

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                string condicion = ObtenerCondicion(promedioFinal[i]); // Llama a la función para obtener la condición del estudiante
                Console.WriteLine($"\nEstudiante {i + 1} - Carnet: {carnet[i]}, Nombre: {nombre[i]}");
                Console.WriteLine($"Promedio Final: {promedioFinal[i]:F2}");
                Console.WriteLine($"Condición: {condicion}");
            }
        }

        // Función para el Ejercicio 3
        public static void Ejercicio3()
        {
            Console.Write("Ingrese la cantidad de productos a comprar: ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            double precioPorProducto = (cantidadProductos <= 10) ? 20.0 : 15.0; // Operador ternario para determinar el precio por producto
            double total = cantidadProductos * precioPorProducto;

            // Mostrar resultados
            Console.WriteLine($"Precio por producto: ${precioPorProducto}");
            Console.WriteLine($"Total a pagar: ${total}");
        }

        // Función para calcular el total a pagar en el Ejercicio 1
        public static float CalcularTotalPagar(float precio, int cantidad)
        {
            float total = 0f;

            if (cantidad == 1)
            {
                total = cantidad * precio;
            }
            else if (cantidad > 1 && cantidad < 6)
            {
                total = (cantidad * precio) * 0.85f; // Descuento del 15%
            }
            else if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.8f; // Descuento del 20%
            }

            return total;
        }

        // Función para leer datos del usuario
        public static string LeerDato(string nombreDato)
        {
            Console.Write($"{nombreDato}: ");
            return Console.ReadLine();
        }

        // Función para calcular el promedio final del estudiante en el Ejercicio 2
        public static double CalcularPromedioEstudiante()
        {
            double quizTotal = 0;
            double tareaTotal = 0;
            double examenTotal = 0;

            // Loop para ingresar calificaciones de quices, tareas y exámenes
            for (int i = 0; i < 3; i++)
            {
                quizTotal += double.Parse(LeerDato($"Quiz {i + 1}"));
                tareaTotal += double.Parse(LeerDato($"Tarea {i + 1}"));
                examenTotal += double.Parse(LeerDato($"Examen {i + 1}"));
            }

            // Calcular porcentajes y retornar el promedio final
            double porcentajeQuices = (quizTotal / 30) * 25;
            double porcentajeTareas = (tareaTotal / 90) * 30;
            double porcentajeExamenes = (examenTotal / 300) * 45;

            return porcentajeQuices + porcentajeTareas + porcentajeExamenes;
        }

        // Función para obtener la condición del estudiante en función de su promedio final
        public static string ObtenerCondicion(double promedioFinal)
        {
            if (promedioFinal >= 70)
            {
                return "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                return "Aplazado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
