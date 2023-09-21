using static System.Console;

namespace Module5
{
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeStatement();

            int secretNumber = 42;
            MagicNumber(secretNumber);

            Write("Enter first number: ");
            int a = Convert.ToInt32(ReadLine());

            Write("Enter second number: ");
            int b = Convert.ToInt32(ReadLine());

            FindArea(a, b);

            WriteLine($"Tax rate: {LocalTaxRate()}");
        }

        static void WelcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

        static void MagicNumber(int num)
        {
            WriteLine(num);
        }

        static void FindArea(int x, int y)
        {
            WriteLine($"Area: {x * y}");
        }

        static double LocalTaxRate()
        {
            Write("Enter tax rate: ");
            double rate = Convert.ToDouble(ReadLine());

            return rate;
        }
    }
}