internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Haulul");
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T x)
    {
        Console.WriteLine("Halo user " + x);
    }
}
