internal class Program
{
    private static void Main(string[] args)
    {
        Array values = Enum.GetValues(typeof(ConsoleColor));
        ConsoleColor randomBar = (ConsoleColor)values.GetValue(new Random().Next(values.Length));
        Console.WriteLine(randomBar);
        Console.ForegroundColor = randomBar;


        Console.WriteLine("####################################");
        Console.WriteLine("####################################");
        Console.WriteLine("####################################");
        Console.WriteLine("####################################");
        Console.WriteLine("############     {0}      #############", randomBar);
        Console.WriteLine("####################################");
        Console.WriteLine("####################################");
        Console.WriteLine("####################################");

    }
}
