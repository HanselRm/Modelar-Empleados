using C_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gerente : IDepartamentos
    {
        public string type= "";
        public string estado = "";
        private static Gerente gerente;

        private Gerente() { }

        public static Gerente GetGerente()
        {
            if(gerente == null)
            {
                gerente = new Gerente();
                string Codigo = gerente.codigo();
                gerente.estado = "activo";
                gerente.type = "Gerencial";
            }
            else
            {
                Console.WriteLine("Ya hay 1 gerente");
                gerente.estado = "ocupado";
            }

            return gerente;
        }

        public string codigo()
        {
            int generador = new Random().Next(1000, 9999);
            string codigo = $"GER{generador}";
            return codigo;
        }
        public string status()
        {
            return estado;
        }
        public string tipoDepartamento()
        {
          
            return type;
        }
    }
}
