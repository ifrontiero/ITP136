namespace HelloWorld
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is your name?");

            Write("> ");

            string userName = ReadLine();

            WriteLine("Your name is " + userName);
        }
    }
}