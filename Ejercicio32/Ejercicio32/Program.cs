using Ejercicio32;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del rombo: ");
        int tamaño = int.Parse(Console.ReadLine());

        try
        {
            Rombo rombo = new Rombo(tamaño);
            rombo.Dibujar();
            rombo.Mostrar();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
