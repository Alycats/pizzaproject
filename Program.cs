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
PizzaProjectMain();

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

        Console.WriteLine ($"So Your Order is {pizzabase}, with {pizzacrust} crust and topped with {pizzatoppings1}, {pizzatoppings2}, and {pizzatoppings3}. ");

        prices();
        Console.ReadKey(true);
    }
    static void prices()
    {
double pizzabase=10;
double pizzacrust =2.50;
double pizzatoppings1 =1;
double pizzatoppings2 =1;
double pizzatopping3 =1;
double price1 =0;
double price2 =0;
double total=0;

price1 = pizzabase + pizzacrust + pizzatoppings1 + pizzatoppings2 + pizzatopping3;
price2 = price1/2.50;
total= price1 + price2;
Console.WriteLine ($"Your Total Today, Including a 2.5% VAT, Will Be = ${total}");

Console.ReadKey (true);

}
}
//CAN'T CHANGE THE WORDS TO NUMBERS, MESSES WITH MY PRETTY TEXT FIX AGAIN AND AGAIN AND AGAIN