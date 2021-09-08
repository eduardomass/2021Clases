using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public class Resta : Operacion
    {
        public override int Calcular()
        {
            return this.Numero1 - this.Numero2;
        }

        public void Saludar()
        {
            Console.WriteLine("Saludos de resta!");
        }
    }
}
