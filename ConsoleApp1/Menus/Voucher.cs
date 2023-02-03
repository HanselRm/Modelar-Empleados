using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Empleados
{
    internal static class Voucher
    {
        public static void VoucherMenu(List<Empleados> emple)
        {
            bool bucle = true;
            while (bucle)
            {
                Utilidades.LimpiarPantalla();
                Utilidades.ImprimirMensaje(@"
                Elija la opcion deseada
                    1- Imprima 1 Empleado
                    2- Imprima todos los Empleado
                    3- Salir
                ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Utilidades.LimpiarPantalla();
                        VoucherImprimir_1(emple);
                        Utilidades.Pausa();
                        break;

                    case "2":
                        Utilidades.LimpiarPantalla();
                        VoucherImprimir_todos(emple);
                        Utilidades.Pausa();
                        break;
                    case "3":

                        bucle = false;
                        break;
                }

            }
                
        }


        public static void VoucherImprimir_1(List <Empleados> emple)
        {
            Console.WriteLine("Escriba el codigo del Empleado que quiere imprimir");
            ManejadorEmpleado.verEmpleados(emple);

            string codigo = Console.ReadLine() ?? "";

            Empleados empleado1 = emple.FirstOrDefault(p => p.Codigo == codigo);
            TextWriter escribe = EscribirTxt();
            try
            {
                empleado1.SalarioNeto = ManejadorEmpleado.CalcularSalarioNeto(empleado1);
                string depa = ManejadorEmpleado.SacarTipoDepa(empleado1);
                string status = ManejadorEmpleado.SacarStatus(empleado1);
                string estadoEmple = "activo";
                if (status == "ocupado")
                {
                    estadoEmple = "Indefinido";
                }
                escribe.WriteLine($@"
                        Cedula: {empleado1.Cedula}
                        Codigo: {empleado1.Codigo}
                        Nombre: {empleado1.Nombre}
                        Departamento: {depa}
                        Estado: {estadoEmple}
                        Salario por Horas: {empleado1.SalarioxH}
                        Horas trabajadas: {empleado1.HorasTrabajadas}
                        Ha cobrado: {empleado1.SalarioNeto}
                -------------------------------------------------------------------------------
                        ");
                
                escribe.Close();
            }
            
            catch
            {
                Console.WriteLine("Error");
            }
            
           
        }

        public static void VoucherImprimir_todos(List <Empleados> emple)
        {
            TextWriter escribe = EscribirTxt();
            try
            {
                foreach(Empleados em in emple)
                {
                    em.SalarioNeto = ManejadorEmpleado.CalcularSalarioNeto(em);
                    string depa = ManejadorEmpleado.SacarTipoDepa(em);
                    string status = ManejadorEmpleado.SacarStatus(em);
                    string estadoEmple = "activo";
                    if (status == "ocupado")
                    {
                        estadoEmple = "Indefinido";
                    }
                    escribe.WriteLine($@"
                        Cedula: {em.Cedula}
                        Codigo: {em.Codigo}
                        Nombre: {em.Nombre}
                        Departamento: {depa}
                        Estado: {estadoEmple}
                        Salario por Horas: {em.SalarioxH}
                        Horas trabajadas: {em.HorasTrabajadas}
                        Ha cobrado: {em.SalarioNeto}
                    -------------------------------------------------------------------------------
                        
                    ");
                }
                escribe.Close();
                
            }

            catch
            {
                Console.WriteLine("Error");
            }

        }

        public static TextWriter EscribirTxt()
        {
            //El archivo se encuentra en la carpeta ConsoleApp1\bin\Release\net6.0
            TextWriter escribe = new StreamWriter(@"Voucher.txt");
            return escribe;
        }

    }
}
