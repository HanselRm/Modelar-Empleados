using C_Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class ManejadorEmpleado
    {
        public static Empleados crearEmpleado()
            {
            Empleados em = new Empleados();

            Utilidades.ImprimirMensaje("Ingrese la Cedula");
            em.Cedula = int.Parse(Console.ReadLine() ?? "");

            Utilidades.ImprimirMensaje("Ingrese el Nombre");
            em.Nombre = Console.ReadLine()??"";

            Utilidades.ImprimirMensaje(@"
                                        Ingrese el Numero del departamento
                                     1-Gerencial 2-Administrativo 3-Operativo");

            em.Departamento = Console.ReadLine() ?? "";

            Utilidades.ImprimirMensaje("Ingrese el precio por hora");
            em.SalarioxH = double.Parse(Console.ReadLine() ?? "");

            Utilidades.ImprimirMensaje("Ingrese las horas trabajadas");
            em.SalarioNeto = double.Parse(Console.ReadLine() ?? "");

            return em;
                
            }

        public static Empleados verEmpleados()
            {
                Utilidades.ImprimirMensaje("Toy funcionando");
                Console.ReadKey();
                return new Empleados();
                
            }

        public static double Cobrar (int sueldo) 
            {
                Utilidades.ImprimirMensaje("Toy funcionando");
                Console.ReadKey();
                return sueldo;
                
            }

        public static string GenerarCodigo()
        {
            string codigo = "";
            return codigo;
            //asdsd
            
            //asd
        }

       public static 
    }
}
