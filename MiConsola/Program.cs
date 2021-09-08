using MiConsola.MisClases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MiConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            //var forma =  FormasFactory.ConstruirForma();
            //forma.CalcularSuperficie();
            
            List<Forma> listaFormas = new List<Forma>();
            for (int i = 1; i <= 101; i++)
            {
                listaFormas.Add(FormasFactory.Recepcionar( i, Forma.TipoForma.Cuadrado) );
            }
            
            
            int q = 0;
            bool hayMayoraA100 = false;
            foreach (var forma in listaFormas)
            {
                if (forma.Lado <= 10)
                    q++;
                if (forma.Lado > 100)
                    hayMayoraA100 = true;
            }

            var listaSoloLosMenorsA10 = listaFormas
                .Where(edu => edu.Lado <= 10 && edu.Id <= 1000)
                ;
            var existeMayorA100 = listaFormas.Any(item => item.Lado > 100);
            List<int> listaEnteros = new List<int>();
            var suma = listaFormas.Sum(o=>o.Lado);
            listaEnteros.Sum();
            Console.WriteLine($"Cantidad de Cuadrados {q}");
            q = 0;
            foreach (var forma in listaFormas)
            {
                if (forma.Lado <= 30 && forma.Lado > 10)
                    q++;
            }

            int numero = 8;

            numero.EsPar();

            bool esPar = (numero % 2 == 0);

            Console.WriteLine($"Cantidad de Cuadrados {q}");
            Console.ReadKey();

            //try
            //{

            //    Operacion suma = Operacion.CrearOperacion("+");
            //    suma.Numero1 = 10;
            //    suma.Numero2 = 20;

            //    Operacion resta = Operacion.CrearOperacion("-");
            //    resta.Numero1 = 10;
            //    resta.Numero2 = 20;


            //    Operacion estoEsUnaOperacion = new Resta();
            //    estoEsUnaOperacion.Numero2 = 20;
            //    estoEsUnaOperacion.Numero1 = 10;
                
            //    //((Suma)estoEsUnaOperacion).Saludar();




            //    Console.WriteLine(suma.Calcular());
            //    Console.WriteLine(resta.Calcular());
            //    Console.WriteLine(estoEsUnaOperacion.Calcular());
            //    Console.ReadKey();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadKey();
            //}
        }
    }
}

