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
        public static void MenuPrincipal(List<Empleados> emple)
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
                        emple = ManejadorEmpleado.crearEmpleado(emple);
                        Utilidades.Pausa();
                        break;

                    case "2":
                        Utilidades.LimpiarPantalla();
                        ManejadorEmpleado.verEmpleados(emple);
                        Utilidades.Pausa();
                    break;

                    case "3":
                        Empleados em = new Empleados();
                        //Array em =  emple.ToArray();
                        //ManejadorEmpleado.Cobrar(em);

                        Utilidades.Pausa();

                        break;

                    case "4":
                        Utilidades.ImprimirMensaje("Que pase buenas");

                        bucle = false;
                    break;

                }
              
            }

        }

    }
}
