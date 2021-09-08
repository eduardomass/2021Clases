using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
   

    public static class FormasFactory
    {
        static int id = 999;

        
        public static Forma Recepcionar(int lado, Forma.TipoForma tipoForma)
        {
            FormasFactory.id++;
            Forma forma = new Forma();
            switch (tipoForma)
            {
                case Forma.TipoForma.Cuadrado:
                    forma = new Cuadrado();
                    break;
                case Forma.TipoForma.Triangulo:
                    break;
                case Forma.TipoForma.Rectangulo:
                    break;
                default:
                    break;
            }
            forma.Id = FormasFactory.id;
            forma.Lado = lado;
            return  forma;
        }
        
    }
}
