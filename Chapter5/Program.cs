// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//==1== Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
static void Question1()
{
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);    

    if (a > b)
    {
        a = a + b; //new a
        b = a - b; //new b = new a - old b == b with the vakue of a
        a = a - b; //final a = new a - old b == a with the value of b
        Console.WriteLine($"a is now {a} & b is now {b}");
    }
}
//==2== 































