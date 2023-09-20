using static System.Console;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new();
            Food food2 = new();

            food1.FoodId = 1;
            food1.Name = "Apple";
            food1.Description = "fruit";
            food1.Price = 0.5;

            food2.FoodId = 2;
            food2.Name = "Cantaloupe";
            food2.Description = "Melon";
            food2.Price = 1.5;

            WriteLine("{0,10} {1,10} {2,10} {3,10}", "FoodId", "Name", "Description", "Price");

            WriteLine("{0,10} {1,10} {2,10} {3,10}", food1.FoodId, food1.Name, food1.Description, food1.Price);

            WriteLine("{0,10} {1,10} {2,10} {3,10}", food2.FoodId, food2.Name, food2.Description, food2.Price);
        }
    }
}