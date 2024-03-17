internal class Program
{
    private static void Main(string[] args)
    {
        DataGeneric<String> data = new DataGeneric<String>("1302223007");
        data.PrintData();
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