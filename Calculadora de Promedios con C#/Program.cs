using System;


namespace Calculadora_de_Promedios_con_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables para almacenar información
            string alumno = "";
            double promedio = 0;
            int contador  = 0; 
            string valorIngresado = "0";
            double calificacion = 0;
            double sumaDeCalificaciones = 0;

            // Mensaje de bienvenida
            Console.WriteLine("Bienvendio al programa 'Promediador'\nPor favor ingrese el nombre del alumno");
            alumno = Console.ReadLine();

            // Bucle principal hasta que se ingrese "fin"
            while (!valorIngresado.Equals("fin"))
            {
                // Solicitar calificaciones al usuario
                Console.WriteLine($"Gracias, ahora vamos a ingresar la siguiente calificacione de {alumno}");
                Console.WriteLine("Puede ingresar la calificacion y presionar enter, o terminar escribiendo 'fin'");
                valorIngresado = Console.ReadLine().ToLower();

                // Comprobar si se ingresa "fin" para mostrar el promedio
                if (valorIngresado.Equals("fin"))
                {
                    Console.Clear();
                    Console.WriteLine($"Ha terminado el calculo, la calificacion de {alumno} es {promedio}");
                }

                // Comprobar si el valor ingresado es una calificación válida entre 0 y 10
                if (double.TryParse(valorIngresado, out calificacion) && calificacion >= 0 && calificacion <= 10)
                {
                    Console.Clear();
                    sumaDeCalificaciones = sumaDeCalificaciones + calificacion;
                    contador += 1;
                    promedio = sumaDeCalificaciones / contador;
                    Console.WriteLine($"Se han ingresado {contador} calificaciones.");
                }
                else
                {
                    // Mensaje de error si el valor ingresado no es válido
                    if (!(valorIngresado.Equals("fin")))
                    {
                        Console.Clear();
                        Console.WriteLine($"Se han ingresado {contador} calificaciones.");
                        Console.WriteLine("El valor ingresado no se registro, por favor solo ingrese numero entre 0 y 10 o escirba 'fin' para salir y entregar el promedio");  
                    }
                }
            }
            Console.Read();
        }
    }
}


