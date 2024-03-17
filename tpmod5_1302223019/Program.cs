public class HaloGeneric
{
    public void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
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

        DataGeneric<int> data = new DataGeneric<int>(1302223019);
        data.PrintData();
    }
}