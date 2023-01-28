using C_Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class GUI
    {
        public static void MenuPrincipal(int sueldo)
        {
            Boolean bucle = true;
            while (bucle)
            {
                Utilidades.LimpiarPantalla();
                Utilidades.ImprimirMensaje(@"
                Seleccione la opcion deseada

                1- Crear Empleado
                2- Ver Empleado
                3- Cobrar sueldo
                4- Salir                  
                ");
                string opcion = Console.ReadLine()??"";
                switch (opcion)
                {
                    case "1":
                        Utilidades.LimpiarPantalla();
                        ManejadorEmpleado.crearEmpleado();
                    break;

                    case "2":
                        Utilidades.LimpiarPantalla();
                        Utilidades.ImprimirMensaje("Opcion 2");
                        ManejadorEmpleado.verEmpleados();
                    break;

                    case "3":
                        Utilidades.LimpiarPantalla();
                        ManejadorEmpleado.Cobrar(sueldo);
                        //MenuCobrar();
                        break;

                    case "4":
                        Utilidades.LimpiarPantalla();
                        Utilidades.ImprimirMensaje("Que pase buenas");
                        bucle = false;
                    break;
                }
            }
        }

    }
}
