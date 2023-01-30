using C_Empleados.Menus;
using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        Empleados em = new Empleados();
        List<Empleados> emple = new List<Empleados>();
        GUI.MenuPrincipal(emple);

        
    }
}