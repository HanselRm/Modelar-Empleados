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
        public static void VoucherMenu()
        {
            bool bucle = true;
            while (bucle)
            {
                Utilidades.LimpiarPantalla();
                Utilidades.ImprimirMensaje(@"
                Elija la opcion deseada
                    1- Imprima todos los Empleado
                    2- Imprima 1 Empleado
                    3- Salir
                ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Utilidades.LimpiarPantalla();
                        VoucherImprimir_1();
                        Utilidades.Pausa();
                        break;

                    case "2":
                        Utilidades.LimpiarPantalla();
                        VoucherImprimir_todos();
                        Utilidades.Pausa();
                        break;
                    case "3":

                        bucle = false;
                        break;
                }

            }
                
        }


        public static void VoucherImprimir_1()
        {

        }

        public static void VoucherImprimir_todos()
        {

        }

    }
}
