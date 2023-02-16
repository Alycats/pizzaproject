namespace pizzaproject;
class Program
{

    static string username ="";
    static string ynresponse = "y";
    static string pizzabase ="";
    static string pizzacrust ="";
    static void Main(string[] args)
    {


        Console.WriteLine("Please Enter Your First Name");
        username = Console.ReadLine();
        Console.WriteLine($"Welcome to Aly's Pizza, {username}!");
        Console.WriteLine("Are you interested in a dessert pizza today? If so enter y in not enter n.");
        ynresponse = Console.ReadLine();
        if (ynresponse == "y")
        {
            Console.WriteLine ("To Begin Your Order Please Choose One of the Three Pizza Bases! Please Type Your Choice.");
            yresponse();
        }
        else
        {
           nresponse();
           
        }

            //if y then proceed to next phase if n then have message, thank you for chosing Aly's Pizza
            // if y then continue, if n or others, then play message
        
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
            //add a part that if spelled wrong prompt again with Order line one
            //Maybe only numbers with the words?
        Console.WriteLine ($"{pizzabase}? Awesome!");
        Console.WriteLine ("Now Please Choose Your Crust! Type it Below.");
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
        Console.WriteLine ("1");
        Console.WriteLine ("2");
        Console.WriteLine ("3");
        Console.WriteLine ("4");
        Console.WriteLine ("5");
        Console.WriteLine ("6");
        Console.WriteLine ("7");
        Console.WriteLine ("8");
        Console.WriteLine ("9");
            // I believe I need an Int for this and the values will have to have the names show only.
            // Prices may be stored in a seperate area? Voidspace?
        Console.ReadKey(true);
    }
}
