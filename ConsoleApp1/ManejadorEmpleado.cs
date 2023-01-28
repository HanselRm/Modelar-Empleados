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

            Utilidades.ImprimirMensaje
                (@"
                Ingrese el Numero del departamento
                1-Gerencial 2-Administrativo 3-Operativo
                ");

            em.Departamento = Console.ReadLine() ?? "";


            Utilidades.ImprimirMensaje("Ingrese el precio por hora");
            em.SalarioxH = double.Parse(Console.ReadLine() ?? "");

            Utilidades.ImprimirMensaje("Ingrese las horas trabajadas");
            em.HorasTrabajadas = double.Parse(Console.ReadLine() ?? "");

            return em;
                
            }

        public static void verEmpleados(Empleados em)
            {
            Console.WriteLine($"Nombre es: {em.Nombre}  Cedula: {em.Cedula} Salario {em.SalarioNeto}");
                
            }

        public static Empleados Cobrar (Empleados ems) 
            {
            ems.SalarioNeto = CalcularSueldo(ems);

            return ems;
                
            }

        public static double CalcularSueldo(Empleados em)
        {
            double salario = (em.SalarioxH * em.HorasTrabajadas);
            return salario;
        }

        public static string GenerarCodigo()
        {
            string codigo = "";
            return codigo;
            //asdsd
            
            //asd
        }

       //public static 
    }
}
