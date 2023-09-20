namespace Week4
{
    public class Food
    {
        int foodId;
        string name;
        string description;
        double price;

        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}