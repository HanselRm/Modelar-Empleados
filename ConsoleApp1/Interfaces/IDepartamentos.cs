using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Empleados.Interfaces
{
    interface IDepartamentos
    {
        string codigo();
        string status();
        string tipoDepartamento();

        public string Depa()
        {
            return $"{tipoDepartamento}";
        }



    }
}
