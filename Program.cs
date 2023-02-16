namespace pizzaproject;
class Program
{
    static void Main(string[] args)
    {
string username;
string ynresponse;
string pizzabase;
string pizzacrust;

        Console.WriteLine("Please Enter Your First Name");
        username = Console.ReadLine();
        Console.WriteLine($"Welcome to Aly's Pizza, {username}!");
        Console.WriteLine("Are you interested in a dessert pizza today? If so enter y in not enter n.");
        ynresponse = Console.ReadLine();
            //if y then proceed to next phase if n then have message, thank you for chosing Aly's Pizza
        Console.WriteLine ("To Begin Your Order Please Choose One of the Three Pizza Bases! Please Type Your Choice.");
        Console.WriteLine ("Vanilla");
        Console.WriteLine ("Chocolate");
        Console.WriteLine ("Strawberry");
        pizzabase = Console.ReadLine ();
            //add a part that if spelled wrong prompt again with Order line one
        Console.WriteLine ($"{pizzabase}? Awesome!");
        Console.WriteLine ("Now Please Choose Your Crust! Type it Below.");
        Console.WriteLine ("Thick");
        Console.WriteLine ("Thin");
        Console.WriteLine ("Stuffed");
        Console.WriteLine ("Gluton-Free");
        Console.WriteLine ("Sugar-Free");
        pizzacrust = Console.ReadLine();
        Console.WriteLine ($"So Far We Have a {pizzabase} Pizza with {pizzacrust} Crust. Pizza-tastic!");
        Console.WriteLine ("Lastly, Let's Choose some Toppings! You Can Choose up to Three Toppings per Pizza!");
        Console.WriteLine ("Please Enter the Corrosponding Number One at a Time.");
        Console.WriteLine ("1");
        Console.WriteLine ("2");
        Console.WriteLine ("3");
        Console.WriteLine ("4");
        Console.WriteLine ("5");
        Console.WriteLine ("6");
        Console.WriteLine ("7");
        Console.WriteLine ("8");
        Console.WriteLine ("9");
            // I believe I need an Int for this and thes values will have to have the names show only.
            // Prices may be stored in a seperate area? Voidspace?
        Console.ReadKey(true);

    }
}
