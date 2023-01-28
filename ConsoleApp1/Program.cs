using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        Empleados em = new Empleados();
        em = GUI.MenuPrincipal(em);

        Console.WriteLine(em.Nombre);
    }
}