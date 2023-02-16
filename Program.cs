namespace pizzaproject;
class Program
{
    static void Main(string[] args)
    {
string username;

string ynresponse;

string pizzabase;

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


        Console.ReadKey(true);

    }
}
