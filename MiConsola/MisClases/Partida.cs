using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola.MisClases
{
    public class Partida
    {
        List<Dado> listaDados = new List<Dado>();
        public void ComenzarPartida(int cantidadDeDados)
        {
            listaDados = new List<Dado>();
            for (int i = 0; i < cantidadDeDados; i++)
            {
                listaDados.Add(new Dado());
            }
            foreach (Dado dadoDeMiPartida in this.listaDados)
            {
                dadoDeMiPartida.Tirar();
            }
        }
        public bool Perdi()
        {
            foreach (Dado dadoX in this.listaDados)
            {
                foreach (var dadoY in this.listaDados)
                {
                    if (dadoX == dadoY)
                        continue;

                    if (dadoY.Numero == dadoX.Numero)
                        return true;
                }
            }
            return false;
        }
    }
}
