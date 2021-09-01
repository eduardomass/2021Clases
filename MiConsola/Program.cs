using MiConsola.MisClases;
using System;
using System.Collections;

namespace MiConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "HOLA";
            string b = "hola";
            if (a == b)
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("no son");


            if (string.Equals(a, b, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("no son");

            if (a.ToUpper().Equals(b.ToUpper()))
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("no son");

            Console.ReadKey();
            return;
            //ArrayList listaNombres = new ArrayList();
            //string nombre;
            //do
            //{
            //    Console.Write("Decime tu nombre : ");
            //    nombre = Console.ReadLine();
            //    if (!nombre.Equals(""))
            //    {
            //        listaNombres.Add(nombre);
            //    }
            //} while (!nombre.Equals(""));

            //foreach (string item in listaNombres)
            //{
            //    foreach (var letra in item.ToCharArray())
            //    {
            //        Console.WriteLine(letra);
            //    }
            //    Console.WriteLine(item);
            //}
            //Dado dado1 = new Dado();
            //Dado dado2 = new Dado();
            //Dado dado3 = new Dado(3);

            //dado1.Tirar();
            //dado2.Tirar();
            //dado3.Tirar();

            //bool a = dado1.Numero == dado2.Numero;
            do
            {


            
            Partida partida1 = new Partida();
            partida1.ComenzarPartida(7);
            if (partida1.Perdi())
            {
                Console.WriteLine("Perdiste");
            }
            else
            {
                Console.WriteLine("Ganaste");
            }

            } while (Console.ReadLine() == "");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}



//Console.Write("Decime tu nombre : ");
//string nombre = Console.ReadLine();
//while (nombre != "")
//{
//    Console.WriteLine("Tu nombre es : " + nombre);
//    Console.Write("Decime tu nombre : ");
//    nombre = Console.ReadLine();
//}
//for (; true;)
//{
//    Console.Write("Decime tu nombre : ");
//    string nombre = Console.ReadLine();
//    if (nombre.Equals(""))
//        break;
//    Console.WriteLine("Tu nombre es : " + nombre);

//}
//string nombre;
//do
//{
//    Console.Write("Decime tu nombre : ");
//    nombre = Console.ReadLine();
//    if (!nombre.Equals(""))
//    {
//        Console.WriteLine("Tu nombre es : " + nombre);
//    }
//} while (!nombre.Equals(""));