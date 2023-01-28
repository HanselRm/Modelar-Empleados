using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gerente
    {
        Empleados empleado;

        private static Gerente gerente;

        private Gerente() { }

        public static Gerente GetGerente()
        {
            if(gerente == null)
            {
                gerente = new Gerente();
            }
            return gerente;
        }
    }
}
