using C_Empleados;
using C_Empleados.Factory;
using C_Empleados.Interfaces;
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

            em.departamentos = Fabrica.Comprobar(em);

            em.Codigo = em.departamentos.codigo();

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
                string estado = empleados.departamentos.status();
                string depart = empleados.departamentos.tipoDepartamento();
                string estadoEmple = "activo";
                    if (estado == "ocupado")
                    {
                    estadoEmple = "Indefinido";
                    }
                    Console.WriteLine($@"
                        Cedula: {empleados.Cedula}
                        Codigo: {empleados.Codigo}
                        Nombre: {empleados.Nombre}
                        Departamento: {depart}
                        Estado: {estadoEmple}
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
                empleados.SalarioNeto = CalcularSalarioNeto(empleados);
                string estado = SacarStatus(empleados);
                string depart = SacarTipoDepa(empleados);
                string estadoEmple = "activo";

                if (estado == "ocupado")
                {
                    empleados.SalarioNeto = 0;
                   estadoEmple = "Indefinido";
                }

                Console.WriteLine($@"
                        Cedula: {empleados.Cedula}
                        Codigo: {empleados.Codigo}
                        Nombre: {empleados.Nombre}
                        Departamento: {depart}
                        Estado: {estadoEmple}
                        Salario por Horas: {empleados.SalarioxH}
                        Horas trabajadas: {empleados.HorasTrabajadas}
                        Ha cobrado: {empleados.SalarioNeto}
                    -------------------------------------------------------------------------------
                    ");
            }
        
        }

        public static double CalcularSalarioNeto(Empleados empleados)
        {
            double salario = empleados.SalarioxH * empleados.HorasTrabajadas;
            return salario;
        }

        public static string SacarTipoDepa (Empleados em)
        {
            return em.departamentos.tipoDepartamento();
        }

        public static string SacarStatus(Empleados em)
        {
            return em.departamentos.status();
        }

    }
}
