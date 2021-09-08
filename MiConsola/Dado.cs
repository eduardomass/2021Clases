using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public class Dado
    {
        private int numero;
        public int NumeroMayorDado { get; set; } = 6;

        //public void Numero(int x)
        //{
        //    this.numero = x;
        //}
        //public int Numero()
        //{
        //    return this.numero;
        //}

        //public int Numero { get; set; }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public void Tirar()
        {
            Random random = new Random();
            this.numero = random.Next(1, this.NumeroMayorDado);
        }

        public Dado()
        {
        }
        public Dado(int numeroTrampa)
        {
            this.numero = numeroTrampa;
        }


    }
}
