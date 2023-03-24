namespace pizzaproject;
class Program
{

    static int[] pizzatoppingsChoices = new int[3];
    static string[] pizzatoppingNames = new string[9];
    static double[] pizzatoppingsPrice = new double[9];
    static string username = "";
    static string ynresponse = "";
    static int[] pizzabaseChoices = new int[1];
    static string[] pizzabaseNames = new string[3];
    static double[] pizzabasePrice = new double[3];
    static int[] pizzacrustChoices = new int[1];
    static string[] pizzacrustNames = new string[5];
    static double[] pizzacrustPrice = new double[5];
    static void Main(string[] args)
    {
        PizzaProjectMain();

    }

    static void PizzaProjectMain()
    {

        pizzatoppingNames = new string[9] { "Chocolate Sprinkles", "Rainbow Sprinkles", "Marshmellows", "Generic Brand Candies", "Gummies", "Fruits", "Whipped Creams", "White Chocolates", "Hazelnut Spread" };
        pizzatoppingsPrice = new double[9] { 0.25, 0.25, 0.50, 0.75, 0.75, 1.00, 0.25, 0.75, 1.00 };
        pizzabaseNames = new string[3] { "Vanilla", "Chocolate", "Strawberry" };
        pizzabasePrice = new double[3] { 5.00, 5.50, 6.25 };

        Console.WriteLine("Please Enter Your First Name");
        username = Console.ReadLine();
        Console.WriteLine($"Welcome to Aly's Pizza, {username}!");
        Console.WriteLine("Are you interested in a dessert pizza today? If so enter y if not enter n.");
        ynresponse = Console.ReadLine();
        if (ynresponse == "y" || ynresponse == "yes" || ynresponse == "Y")
        {
            Console.WriteLine("To Begin Your Order Please Choose One of the Three Pizza Bases! Please Type Your Number Choice.");
            yresponse();
        }
        else
        {
            nresponse();

        }

    }
    static void nresponse()
    {
        Console.WriteLine("Thank You for Checking Out Aly's Pizza! Have a Good Day.");

    }

    static void yresponse()
    {
        for (int Pbase = 0; Pbase < 3; Pbase++)
        {
            Console.WriteLine($"{Pbase + 1} {pizzabaseNames[Pbase]}");
        }
        bool valid = false;
        do
        {
            pizzabaseChoices[0] = -1;
            try
            {
                pizzabaseChoices[0] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Not a Number!");
            }
            //Maybe only numbers with the words?
            if (pizzabaseChoices[0] == 1 || pizzabaseChoices[0] == 2 || pizzabaseChoices[0] == 3)
            {
                valid = true;
                PizzaBaseStart();
            }
            else
            {
                valid = false;
                Console.WriteLine("Invaid Response Please Try Again");
            }
        }
        while (valid == false);

        static void PizzaBaseStart()
        {
            pizzacrustNames = new string[5] { "Thick", "Thin", "Stuffed", "Gluton-Free", "Sugar-Free" };
            pizzacrustPrice = new double[5] { 0.50, 0.50, 1.25, 0.25, 0.25 };

            Console.WriteLine($"{pizzabaseNames[pizzabaseChoices[0]-1]}? Awesome!");
            Console.WriteLine("Now Please Choose Your Crust! Type the Number Below.");
            for (int crust = 0; crust < 5; crust++)
            {
                Console.WriteLine($"{crust + 1} {pizzacrustNames[crust]}");
            }
            bool valid = false;
            do
            {
                pizzacrustChoices[0] = -1;
                try
                {
                    pizzacrustChoices[0] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a Number!");
                }
                //Maybe only numbers with the words?
                if (pizzacrustChoices[0] == 1 || pizzacrustChoices[0] == 2 || pizzacrustChoices[0] == 3 || pizzacrustChoices[0] == 4 || pizzacrustChoices[0] == 5)
                {
                    valid = true;
                    PizzaToppingStart();
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Invaid Response Please Try Again");
                }
            }
            while (valid == false);
            static void PizzaToppingStart()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"So Far We Have a {pizzabaseNames[pizzabaseChoices[0]-1]} Pizza with {pizzacrustNames[pizzacrustChoices[0]-1]} Crust. Pizza-tastic!");
                    Console.WriteLine("Lastly, Let's Choose some Toppings! You Can Choose up to Three Toppings per Pizza!");
                    Console.WriteLine("Please Enter the Corrosponding Number One at a Time.");
                    for (int topping = 0; topping < 9; topping++)
                    {
                        Console.WriteLine($"{topping + 1} {pizzatoppingNames[topping]}");
                    }
                    bool valid = false;
                    do
                    {
                        pizzatoppingsChoices[i] = -1;
                        try
                        {
                            pizzatoppingsChoices[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a Number!");
                        }

                        if (pizzatoppingsChoices[i] == 1 || pizzatoppingsChoices[i] == 2 || pizzatoppingsChoices[i] == 3 || pizzatoppingsChoices[i] == 4 || pizzatoppingsChoices[i] == 5 || pizzatoppingsChoices[i] == 6 || pizzatoppingsChoices[i] == 7 || pizzatoppingsChoices[i] == 8 || pizzatoppingsChoices[i] == 9)
                        {
                            valid = true;

                        }
                        else
                        {
                            valid = false;
                            Console.WriteLine("Invaid Response Please Try Again");
                        }

                    }
                    while (valid == false);
                    // Prices may be stored in a seperate area? Voidspace?/loop  

                }
                Console.WriteLine($"So Your Order is {pizzabaseNames[pizzabaseChoices[0]-1]}, with {pizzacrustNames[pizzacrustChoices[0]-1]} crust and topped with {pizzatoppingNames[pizzatoppingsChoices[0]-1]}, {pizzatoppingNames[pizzatoppingsChoices[1]-1]}, and {pizzatoppingNames[pizzatoppingsChoices[2]-1]}. ");
                prices();

            }


        }

        Console.ReadKey(true);
    }
    static void prices()
    {

        double price1 = 0;
        double price2 = 0;
        double total = 0;

        price1 = pizzabasePrice[pizzabaseChoices[0] - 1] + pizzacrustPrice[pizzacrustChoices[0] - 1] + pizzatoppingsPrice[pizzatoppingsChoices[0] - 1] + pizzatoppingsPrice[pizzatoppingsChoices[1] - 1] + pizzatoppingsPrice[pizzatoppingsChoices[2] - 1];
        price2 = price1 / 2.50;
        total = price1 + price2;
        Console.WriteLine($"Your Total Today, Including a 2.5% VAT, Will Be = ${total:f2}");


        //Can add a yes or no question that loops back to beginning if yes or ends prgram if not- Loop
        Console.ReadKey(true);

    }
}
//CAN'T CHANGE THE WORDS TO NUMBERS, MESSES WITH MY PRETTY TEXT FIX AGAIN AND AGAIN AND AGAIN AHHHHHHHHHHHHHHHH