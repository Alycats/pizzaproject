namespace pizzaproject;
class Program
{

    static string pizzatoppings1 = "";
    static string pizzatoppings2 = "";
    static string pizzatoppings3 = "";
    static string username = "";
    static string ynresponse = "";
    static string pizzabase = "";
    static string pizzacrust = "";
    static void Main(string[] args)
    {
        PizzaProjectMain();

    }

    static void PizzaProjectMain()
    {


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
        Console.WriteLine("1-Vanilla");
        Console.WriteLine("2-Chocolate");
        Console.WriteLine("3-Strawberry");
        bool valid = false;
        do
        {
            pizzabase = Console.ReadLine();
            //Maybe only numbers with the words?
            if (pizzabase == "1" || pizzabase == "2" || pizzabase == "3")
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
            Console.WriteLine($"{pizzabase}? Awesome!");
            Console.WriteLine("Now Please Choose Your Crust! Type the Number Below.");
            Console.WriteLine("1-Thick");
            Console.WriteLine("2-Thin");
            Console.WriteLine("3-Stuffed");
            Console.WriteLine("4-Gluton-Free");
            Console.WriteLine("5-Sugar-Free");
            bool valid = false;
             do
        {
            pizzacrust = Console.ReadLine();
            //Maybe only numbers with the words?
            if (pizzacrust == "1" || pizzacrust == "2" || pizzacrust == "3" || pizzacrust == "4" || pizzacrust == "5")
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
            Console.WriteLine($"So Far We Have a {pizzabase} Pizza with {pizzacrust} Crust. Pizza-tastic!");
            Console.WriteLine("Lastly, Let's Choose some Toppings! You Can Choose up to Three Toppings per Pizza!");
            Console.WriteLine("Please Enter the Corrosponding Number One at a Time.");
            Console.WriteLine("1-Chocolate Sprinkles");
            Console.WriteLine("2-Rainbow Sprinkles");
            Console.WriteLine("3-Marshmellows");
            Console.WriteLine("4-Generic Brand Candies");
            Console.WriteLine("5-Gummies");
            Console.WriteLine("6-Fruits");
            Console.WriteLine("7-Whipped Creams");
            Console.WriteLine("8-White Chocolates");
            Console.WriteLine("9-Hazelnut Spread");
            // Prices may be stored in a seperate area? Voidspace?/loop
            
            for (int i=0; i<=3; i++ )
        {
            pizzatoppings1 = Console.ReadLine();
            pizzatoppings2 = Console.ReadLine();
            pizzatoppings3 = Console.ReadLine();
        }
           if (pizzatoppings1 == "1")
           {

           }
        }
             Console.WriteLine($"So Your Order is {pizzabase}, with {pizzacrust} crust and topped with {pizzatoppings1}, {pizzatoppings2}, and {pizzatoppings3}. ");

        prices();
        Console.ReadKey(true);
    }
    static void prices()
    {
        double pizzabase = 10;
        double pizzacrust = 2.50;
        double pizzatoppings1 = 1;
        double pizzatoppings2 = 1;
        double pizzatopping3 = 1;
        double price1 = 0;
        double price2 = 0;
        double total = 0;

        price1 = pizzabase + pizzacrust + pizzatoppings1 + pizzatoppings2 + pizzatopping3;
        price2 = price1 / 2.50;
        total = price1 + price2;
        Console.WriteLine($"Your Total Today, Including a 2.5% VAT, Will Be = ${total}");


        //Can add a yes or no question that loops back to beginning if yes or ends prgram if not- Loop
        Console.ReadKey(true);

    }
    }
}
//CAN'T CHANGE THE WORDS TO NUMBERS, MESSES WITH MY PRETTY TEXT FIX AGAIN AND AGAIN AND AGAIN AHHHHHHHHHHHHHHHH