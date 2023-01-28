using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gerente
    {
        private static string Codigo;

        private static Gerente gerente;

        private Gerente() { }

        public static Gerente GetGerente()
        {
            if(gerente == null)
            {
                gerente = new Gerente();
                int generador = new Random().Next(1000,9999);
                Codigo = $"GER{generador}";
            }

            return gerente;
        }
    }
}
