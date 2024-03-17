internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Haulul");

        DataGeneric<String> data = new DataGeneric<String>("1302223007");
        data.PrintData();
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah " + data);
    }
}
