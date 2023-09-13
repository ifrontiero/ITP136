using static System.Console;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SICK_PRICE_CHILD = 50;
            const double SICK_PRICE_ADULT = 75;

            const double LABS_PRICE = 25;

            const double CHECK_PRICE_CHILD = 75;
            const double CHECK_PRICE_ADULT = 100;
            
            int option;
            int ageOption, labsOption;
            double total;

            Write("Welcome. Please select visit type: (1) Sick Appointment (2) Check-Up ");
            option = Convert.ToInt32(ReadLine());

            switch(option)
            {
                case 1: // Sick Appointment
                    // int ageOption, labsOption;
                    Write("Enter age: (1) Child (2) Adult ");
                    ageOption = Convert.ToInt32(ReadLine());
                    Write("Labs? (1) Yes (2) No ");
                    labsOption = Convert.ToInt32(ReadLine());

                    if (ageOption == 1) // Child
                    {
                        if (labsOption == 1) // Yes
                        {
                            total = SICK_PRICE_CHILD + LABS_PRICE;
                        }
                        else
                        {
                            total = SICK_PRICE_CHILD;
                        }
                    }
                    else // Adult
                    {
                        if (labsOption == 1) // Yes
                        {
                            total = SICK_PRICE_ADULT + LABS_PRICE;
                        }
                        else
                        {
                            total = SICK_PRICE_ADULT;
                        }
                    }
                    WriteLine($"Total: {total:C}");
                    break;
                case 2: // Check-Up
                    Write("Enter age: (1) Child (2) Adult ");
                    ageOption = Convert.ToInt32(ReadLine());

                    if (ageOption == 1) // Child
                    {
                        total = CHECK_PRICE_CHILD;
                    }
                    else
                    {
                        total = CHECK_PRICE_ADULT;
                    }
                    WriteLine($"Total: {total:C}");
                    break;
                default:
                    WriteLine("No option selected");
                    break;
            }
        }
    }
}