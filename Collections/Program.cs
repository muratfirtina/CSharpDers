class Program
{
    public static void Main(string[] args)
    {
        List<string> isimler = new List<string> { "Murat", "Emel", "Vera" };
        Console.WriteLine(isimler[0]);
        isimler.Add("Pekmez");
        Console.WriteLine(isimler[3]);
        
    }
}