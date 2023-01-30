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

        public static IDepartamentos Comprobar(Empleados emple)
        {
            if (emple.Departamento == "1")
            {
                return Gerente.GetGerente();
            }
            else if (emple.Departamento == "2")
            {
                return new Administrativo();
            }

            else if (emple.Departamento == "3")
            {
                return new Operativo();
            }

            else
            {
                Console.WriteLine("Ese departamento no existe");
                return null;
            }


        }

        public string Depa()
        {
            return $"{tipoDepartamento}";
        }



    }
}
