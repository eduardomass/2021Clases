using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public class Forma
    {

        public enum TipoForma
        {
            Cuadrado,
            Triangulo,
            Rectangulo
        }


        public int Lado { get; set; }

        public int Id { get; set; }

        public virtual decimal CalcularSuperficie()
        {
            return 0;
        }
    }
}
