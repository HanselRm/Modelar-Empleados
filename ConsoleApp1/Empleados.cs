using C_Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Empleados
    {
        public int Cedula { get; set; }
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Departamento { get; set; }
        public double SalarioxH { get; set; }
        public double HorasTrabajadas { get; set; }
        public double SalarioNeto { get; set; }

        Departamentos departamentos;



    }

}
