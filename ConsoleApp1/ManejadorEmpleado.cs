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
        public static List<Empleados> crearEmpleado(List<Empleados> emple)
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

            emple.Add(em);
            return emple;
                
            }

        public static void verEmpleados(List<Empleados> emple)
            {
            foreach (Empleados empleados in emple)
                {
                    Console.WriteLine($@"
                        Cedula: {empleados.Cedula}
                        Nombre: {empleados.Nombre}
                        Salario por Horas: {empleados.SalarioxH}
                        Horas trabajadas: {empleados.HorasTrabajadas}
                        Ha cobrado: {empleados.SalarioNeto}
                    
                    ");
                }

        }

        public static Empleados Cobrar(Empleados ems)
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
        }

       //public static 
    }
}
