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
        public static Empleados MenuPrincipal(Empleados em)
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
                        em = ManejadorEmpleado.crearEmpleado();
                        Utilidades.Pausa();
                        break;

                    case "2":
                        Utilidades.LimpiarPantalla();
                        ManejadorEmpleado.verEmpleados(em);
                        Utilidades.Pausa();
                    break;

                    case "3":
                        
                        em = ManejadorEmpleado.Cobrar(em);
                        Utilidades.Pausa();

                        break;

                    case "4":
                        Utilidades.LimpiarPantalla();
                        Utilidades.ImprimirMensaje("Que pase buenas");

                        bucle = false;
                    break;

                }
              
            }
            return em;
        }

    }
}
