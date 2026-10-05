using System;

namespace AprobacionCurso
{
    internal class Program
    {
        // Arreglos globales para guardar estudiantes y notas
        static string[] estudiantes = new string[3];
        static float[] notas = new float[3];

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE APROBACION DE CURSO");
            Console.WriteLine("==============================");
            Console.WriteLine();

            SolicitarDatos();
            MostrarResultados();

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        // Metodo para solicitar los nombres y las notas
        static void SolicitarDatos()
        {
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante #" + (i + 1));

                Console.Write("Digite el nombre del estudiante: ");
                estudiantes[i] = Console.ReadLine();

                bool notaValida = false;

                while (notaValida == false)
                {
                    Console.Write("Digite la nota final (0 a 100): ");

                    if (float.TryParse(Console.ReadLine(), out notas[i]))
                    {
                        if (notas[i] >= 0 && notas[i] <= 100)
                        {
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: debe ingresar un numero.");
                    }
                }

                Console.WriteLine();
            }
        }

        // Metodo para mostrar los resultados
        static void MostrarResultados()
        {
            Console.WriteLine();
            Console.WriteLine("RESULTADOS DEL CURSO");
            Console.WriteLine("====================");
            Console.WriteLine();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante: " + estudiantes[i]);
                Console.WriteLine("Nota final: " + notas[i]);
                Console.WriteLine("Resultado: " + ObtenerResultado(notas[i]));
                Console.WriteLine("------------------------------");
            }
        }

        // Funcion que devuelve si el estudiante aprobo o reprobo
        static string ObtenerResultado(float nota)
        {
            if (nota >= 70)
            {
                return "APROBADO";
            }
            else
            {
                return "REPROBADO";
            }
        }
    }
}