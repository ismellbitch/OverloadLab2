
using OverloadLab2;

internal class Program
{
    private static void Main(string[] args)
    {
        Money money1 = new Money(10, 0);
        Money money2 = new Money(14, 101);
        Money money3 = money1 + money2;
        Console.WriteLine(money3.ToString());
    }
}