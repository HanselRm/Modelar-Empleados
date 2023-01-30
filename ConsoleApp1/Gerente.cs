using C_Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gerente : IDepartamentos
    {

        private static Gerente gerente;

        private Gerente() { }

        public static Gerente GetGerente()
        {
            if(gerente == null)
            {
                gerente = new Gerente();
                string Codigo = gerente.codigo();
            }

            return gerente;
        }

        public string codigo()
        {
            int generador = new Random().Next(1000, 9999);
            string codigo = $"Adm {generador}";
            return codigo;
        }

        public string tipoDepartamento()
        {
            string depa = "Administrativo";
            return depa;
        }
    }
}
