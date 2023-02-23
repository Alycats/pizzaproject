namespace pizzaproject;
class Program
{

    static string pizzatoppings1 = "";
    static string pizzatoppings2 = "";
    static string pizzatoppings3 = "";
    static string username = "";
    static string ynresponse = "y";
    static string pizzabase = "";
    static string pizzacrust = "";
    static void Main(string[] args)
{
prices();

}

    static void PizzaProjectMain()
    {


        Console.WriteLine("Please Enter Your First Name");
            username = Console.ReadLine();
        Console.WriteLine($"Welcome to Aly's Pizza, {username}!");
        Console.WriteLine("Are you interested in a dessert pizza today? If so enter y if not enter n.");
             ynresponse = Console.ReadLine();
        if (ynresponse == "y")
        {
            Console.WriteLine ("To Begin Your Order Please Choose One of the Three Pizza Bases! Please Type Your Number Choice.");
            yresponse();
        }
        else
        {
           nresponse();
           
        }
        
    }    
  static void nresponse()
    {
            Console.WriteLine ("Thank You for Checking Out Aly's Pizza! Have a Good Day.");

    }

    static void yresponse()
    {
        Console.WriteLine ("Vanilla");
        Console.WriteLine ("Chocolate");
        Console.WriteLine ("Strawberry");
             pizzabase = Console.ReadLine ();
            //Maybe only numbers with the words?
        Console.WriteLine ($"{pizzabase}? Awesome!");
        Console.WriteLine ("Now Please Choose Your Crust! Type the Number Below.");
        Console.WriteLine ("Thick");
        Console.WriteLine ("Thin");
        Console.WriteLine ("Stuffed");
        Console.WriteLine ("Gluton-Free");
        Console.WriteLine ("Sugar-Free");
             pizzacrust = Console.ReadLine();
            //if option 1,2,..,5 then proceed if not then repeat
        Console.WriteLine ($"So Far We Have a {pizzabase} Pizza with {pizzacrust} Crust. Pizza-tastic!");
        Console.WriteLine ("Lastly, Let's Choose some Toppings! You Can Choose up to Three Toppings per Pizza!");
        Console.WriteLine ("Please Enter the Corrosponding Number One at a Time.");
        Console.WriteLine ("Chocolate Sprinkles");
        Console.WriteLine ("Rainbow Sprinkles");
        Console.WriteLine ("Marshmellows");
        Console.WriteLine ("Generic Brand Candies");
        Console.WriteLine ("Gummies");
        Console.WriteLine ("Fruits");
        Console.WriteLine ("Whipped Creams");
        Console.WriteLine ("White Chocolates");
        Console.WriteLine ("Hazelnut Spread");
            // I believe I need an Int for this and the values will have to have the names show only.
            // Prices may be stored in a seperate area? Voidspace?
             pizzatoppings1 = Console.ReadLine();
             pizzatoppings2 = Console.ReadLine();
             pizzatoppings3 = Console.ReadLine();

        Console.ReadKey(true);
    }
    static void prices()
    {
double pizzabase=0;
double pizzacrust =0;
double pizzatoppings1 =0;
double pizzatoppings2 =0;
double pizzatopping3 =0;
double price1 =0;
double price2 =0;
double total=0;

price1 = pizzabase + pizzacrust + pizzatoppings1 + pizzatoppings2 + pizzatopping3;
price2 = price1/2.5;
total= price1 + price2;
Console.WriteLine ($"Your Total today will be = {total}");

Console.ReadKey (true);

}
}
//CAN'T CHANGE THE WORDS TO NUMBERS, MESSES WITH MY PRETTY TEXT FIX AGAIN AND AGAIN AND AGAIN