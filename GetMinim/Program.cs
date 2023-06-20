public class Program
{
    public static void Main()
    {
        Console.Write("Your first number is: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Your second number is: ");
        int secondNum = int.Parse(Console.ReadLine());

        GetMin(firstNum, secondNum);
    }

    public static void GetMin(int num1, int num2)
    {
        Console.WriteLine($"The smallest number between {num1} and {num2} is: {Math.Min(num1, num2)}.");
    }
}