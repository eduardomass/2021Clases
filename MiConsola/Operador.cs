using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public class Operacion
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public virtual int Calcular()
        {
            throw new Exception("No es posible hacer esta operacion debido a que no hicimos una clase abstracta y esto se puede implmentar mal");
        }

        public static Operacion CrearOperacion(string operdor)
        {
            if (operdor == "+")
                return new Suma();
            if (operdor == "-")
                return new Resta();
            return new Operacion();
        }

    }
}
