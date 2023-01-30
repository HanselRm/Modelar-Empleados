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

            em.departamentos = IDepartamentos.Comprobar(em);

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
                empleados.Codigo = empleados.departamentos.codigo();
                empleados.Tipodepa = empleados.departamentos.tipoDepartamento();
                    Console.WriteLine($@"
                        Cedula: {empleados.Cedula}
                        Codigo: {empleados.Codigo}
                        Nombre: {empleados.Nombre}
                        Departamento: {empleados.Tipodepa}
                        Salario por Horas: {empleados.SalarioxH}
                        Horas trabajadas: {empleados.HorasTrabajadas}
                    -------------------------------------------------------------------------------
                    ");
                }

        }

        

        public static void CalcularSueldo(List<Empleados> emple)
        {
            foreach (Empleados empleados in emple)
            {
               empleados.SalarioNeto = empleados.SalarioxH * empleados.HorasTrabajadas;
                empleados.Codigo = empleados.departamentos.codigo();
                string depart = empleados.departamentos.Depa();

                Console.WriteLine($@"
                        Cedula: {empleados.Cedula}
                        Codigo: {empleados.Codigo}
                        Nombre: {empleados.Nombre}
                        Departamento: {depart}
                        Salario por Horas: {empleados.SalarioxH}
                        Horas trabajadas: {empleados.HorasTrabajadas}
                        Ha cobrado: {empleados.SalarioNeto}
                    -------------------------------------------------------------------------------
                    ");
            }
        }

        

     
    }
}
