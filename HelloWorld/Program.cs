namespace HelloWorld
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Who is being seen today?");

            Write("> ");

            string patientName = ReadLine();
            
            WriteLine("Welcome: " + patientName);
        }
    }
}