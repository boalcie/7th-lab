class Program
{
    static void first(string row123)
    {
        var row12 = row123.Length;
        Console.WriteLine(row12);
    }

    static int second(string row124)
    {
        return row124.Length;
    }
    static int third(int n)
    {
        if (n == 0 || n == 1) return n;

        return third(n - 1) + third(n - 2);
    }
    static void Main()
    {
        first("Oleg");
        Console.WriteLine(second("IvanPetrovich"));
        Console.Write("n = ");
        var n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(third(n));
        }

}