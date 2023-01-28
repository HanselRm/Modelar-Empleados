using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Empleados
{
    static class Utilidades
    {
        public static void LimpiarPantalla()
        {
            Console.Clear();
        } 

        public static void ImprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
