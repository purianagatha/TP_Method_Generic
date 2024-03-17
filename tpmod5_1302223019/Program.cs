public class HaloGeneric
{
    public void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

public class main
{
    public static void Main(string[] args)
    {
        Console.Write("Input nama: ");
        String X = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(X);
    }
}