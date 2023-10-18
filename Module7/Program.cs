namespace Module7;

class Program
{
    static void Main(string[] args)
    {
        var make = new string[5];
        var model = new string[5];
        var price = new double[5];

        for (int i = 0; i < make.Length; i++)
        {
            Console.WriteLine($"Enter make for car {i}: ");
            make[i] = Console.ReadLine();
            Console.WriteLine($"Enter model for car {i}: ");
            model[i] = Console.ReadLine();
            Console.WriteLine($"Enter price for car {i}: ");
            price[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("{0,10}{1,10}{2,10}", "Make", "Model", "Price");

        for (int i = 0; i < make.Length; i++)
        {
            Console.WriteLine("{0,10}{1,10}{2,10}", make[i], model[i], price[i].ToString("C"));
        }

        double maxPrice = price.Max();
        int p = Array.IndexOf(price, maxPrice);

        Console.WriteLine("Most expensive car: \n{0,10}{1,10}{2,10}", make[p], model[p], price[p].ToString("C"));
    }
}