using C_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Administrativo : IDepartamentos 
    {
        public string codigo()
        {
            int generador = new Random().Next(1000, 9999);
            string codigo = $"ADM{generador}";
            return codigo;
        }

        public string tipoDepartamento()
        {
            string depa = "Administrativo";
            return depa;
        }
        public string status()
        {
            string estado = "";
            return estado;
        }
    }
}
