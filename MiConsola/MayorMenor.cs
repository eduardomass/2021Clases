using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    class MayorMenor
    {
        public void Generar()
        {
            int numeroActual = 0;
            string queEligio = "";
            bool esteBien = false;
            do
            {
                Dado dado = new Dado()
                {
                    NumeroMayorDado = 10
                };
                //dado.NumeroMayorDado = 10;
                dado.Tirar();

                Console.WriteLine("Elije mayor o menor de " + numeroActual + "?????? ");
                //Console.WriteLine(String.Format( "Elije mayor o menor de {0} ?????? ", numeroActual));
                //Console.WriteLine(String.Format("Elije mayor o menor de {0}  : {1} ?????? ", numeroActual, dado.Numero));
                //Console.WriteLine(String.Format("{1} {0}  {2}", "hola", "que", 12345));
                Console.WriteLine($"El valor del numero actual es : {numeroActual}");
                Console.WriteLine("Elija mayor o menor : ");
                queEligio = Console.ReadLine().ToUpper();

                bool salioMayor = (dado.Numero >= numeroActual);
                bool salioMenor = (dado.Numero <= numeroActual);
                bool eligioMayor = queEligio == "MAYOR";
                bool eligioMenor = queEligio == "MENOR";

                esteBien = (salioMayor && eligioMayor) || (salioMenor && eligioMenor);




                numeroActual = dado.Numero;

            } while (esteBien);
            Console.WriteLine($"Usted Perdio, salido  {numeroActual}");
            Console.ReadKey();
        }
    }
}
