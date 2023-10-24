using System;


namespace Calculadora_de_Promedios_con_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string alumno = "";
            double promedio = 0;
            int contador  = 0;
            string valorIngresado = "0";
            double calificacion = 0;

            Console.WriteLine("Bienvendio al programa 'Promediador'\nPor favor ingrese el nombre del alumno");
            alumno = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Gracias, ahora vamos a ingresar las calificaciones de {alumno}");
            Console.WriteLine("Puede ingresar la calificacion y presionar enter, o terminar escribiendo 'fin'");

            valorIngresado = Console.ReadLine().ToLower();


            if (!valorIngresado.Equals("fin"))
            {
                Console.Clear();
                Console.WriteLine($"Ha terminado el calculo, la calificacion de {alumno} es {promedio}");
            }


            if (double.TryParse(valorIngresado, out calificacion))
            {

            }






            Console.Read();




        }
    }
}

















//string ingreso = "0";
//int contador = 0;
//int total = 0;
//int numeroActual = 0;

//while (ingreso != "fin")
//{
//    Console.WriteLine("El número actual es {0}", numeroActual);
//    Console.WriteLine("La cantidad de calificaciones ingresadas es de {0}", contador);
//    Console.WriteLine("Cuando desee finalizar la carga de datos, escriba 'fin'");
//    Console.WriteLine("Por favor ingrese la siguiente calificación");

//    ingreso = Console.ReadLine();

//    if (ingreso.Equals("fin"))
//    {
//        Console.WriteLine("----------------------------------------");
//        double promedio = (double)total / (double)contador;
//        Console.WriteLine("El promedio obtenido por el alumno fue {0}", promedio);
//    }

//    if (int.TryParse(ingreso, out numeroActual) && numeroActual > 0 && numeroActual < 11)
//    {
//        total += numeroActual;
//    }
//    else
//    {
//        if (!(ingreso.Equals("fin")))
//        {
//            Console.WriteLine("Por favor ingrese un número entre 1 y 10");

//        }
//        continue;
//    }
//    contador++;

//}
//Console.Read();