using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public class Cuadrado :Forma
    {
        public override decimal CalcularSuperficie()
        {
            return this.Lado * this.Lado;
        }
    }
}
