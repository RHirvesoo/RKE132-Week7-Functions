Console.WriteLine("Are you coming or leaving?(in/out)");
string userChoce = Console.ReadLine();

if(userChoce == "in")
{
   PrintHello();
}
else
{
    PrintGoodBye();

}
static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}