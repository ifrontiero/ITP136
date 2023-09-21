using static System.Console;

namespace Module5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b;

            WelcomeMessage();

            for (int k = 0; k < 3; k++)
            {
                a = AskNumber();
                b = AskNumber();

                AddNumber(a, b);
            }
        }

        static void WelcomeMessage()
        {
            WriteLine("Welcome to my method");
        }

        static int AskNumber()
        {
            Write("Enter a number ");

            int x = Convert.ToInt32(ReadLine());

            return x;
        }

        static void AddNumber(int num1, int num2)
        {
            int total = num1 + num2;

            WriteLine($"Your total is {total}");
        }
    }
}