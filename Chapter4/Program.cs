// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    Question1();
    Question2();
    Question3();
    Question4();
    Question5();
    Question6();
    Question7();
    Question8();
    Question9();
    Question10();
    Question11();
    //Question12();
}
//==1== Write a program that reads from the console three numbers of type int and prints their sum.
static void Question1()
{
    try
    {
        Console.Write("Enter 1st operand: ");
        int a = Int32.Parse(Console.ReadLine()!);
        Console.Write("2nd operand: ");
        int b = Int32.Parse(Console.ReadLine()!);
        Console.Write("3rd operand: ");
        int c = Int32.Parse(Console.ReadLine()!);
        Console.WriteLine("Result is {0}", a + b + c);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Input", ex.Message);
        Console.ResetColor();
    }
}

//==2== Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
static void Question2()
{
    Console.Write("Enter Radius: ");
    int r = Int32.Parse(Console.ReadLine()!);
    Console.WriteLine("Perimeter(P) is {0}", 2 * Math.PI * r);
    Console.WriteLine("Area(A) is {0}", Math.PI * r * r);
}

//==3== A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.Write a program that reads information about the company and its manager and then prints it on the console.
static void Question3()
{
    Console.Write("Enter company name: ");
    string compName = Console.ReadLine()!;
    Console.Write("Enter company address: ");
    string compAddress = Console.ReadLine()!;
    Console.Write("Enter company phone number: ");
    long compPhoneNum = Int64.Parse(Console.ReadLine()!);
    Console.Write("Enter company fax number: ");
    long compFax = Int64.Parse(Console.ReadLine()!);
    Console.Write("Enter company website: ");
    string compWebsite = Console.ReadLine()!;
    Console.Write("Enter manager firstname: ");
    string managerName = Console.ReadLine()!;
    Console.Write("Enter manager surname: ");
    string managerSurname = Console.ReadLine()!;
    Console.Write("Enter manager phone number: ");
    long managerPhoneNum = Int64.Parse(Console.ReadLine()!);
    Console.WriteLine($"Firm Details: {compName} - Address: {compAddress} - Contact: {compPhoneNum} - Fax: {compFax} - Company Website: {compWebsite}.\nManager Details: {managerName} {managerSurname} - Contacts: {managerPhoneNum}");
}

//==4== Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters
//and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; 
//and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
static void Question4()
{
    int number1 = 123;
    double number2 = 3.14159;
    double number3 = -0.98765;

    // Convert number1 to hexadecimal
    string hexNumber = number1.ToString("X");
    Console.WriteLine(hexNumber);

    // Round number2 and number3 to two decimal places
    double roundedNumber2 = Math.Round(number2, 2);
    double roundedNumber3 = Math.Round(number3, 2);

    // Print the numbers in three virtual columns
    Console.WriteLine($"{hexNumber,-10}{roundedNumber2,-10}{roundedNumber3,-10}");
}

//==5== Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the 
//remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.   
static void Question5()
{
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);
    int divisibleNums = 0; //Initializing a variable to count the numbers that meets the condition of the if statement

    for (int i = a; i <= b; i++) //starts counting from a, & when increament reaches b operation stops
    {
        if (i % 5 == 0)
            divisibleNums++;
    }
    Console.WriteLine($"In the range ({a}, {b}) only {divisibleNums} numbers that can be divided by 5 without remainder is found.");
}

//==6== Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
static void Question6()
{
    Console.Write("Enter first operand: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second operand: ");
    int b = Int32.Parse(Console.ReadLine()!);

    Console.WriteLine($"The greater of the two operand is {Math.Max(a, b)}, While the smallest is {Math.Min(a, b)}");
}

//==7== Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
static void Question7()
{
    int i = 1;
    int sum = 0;

    while (i <= 5)
    {
        Console.Write($"Enter an integer (#{i}): ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            sum += number;
            i++;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    Console.WriteLine($"The sum of the five integers is: {sum}");
}

//==8== Write a program that reads five numbers from the console and prints the greatest of them.
static void Question8()
{
    Console.Write("Enter first operand: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second operand: ");
    int b = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter third operand: ");
    int c = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter fourth operand: ");
    int d = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter fifth operand: ");
    int e = Int32.Parse(Console.ReadLine()!);

    if (a >= b && a >= c && a >= d && a >= e)
    {
        Console.WriteLine("{0} is the biggest.", a);
    }
    else if (b >= a && b >= c && b >= d && b >= e)
    {
        Console.WriteLine("{0} is the biggest.", b);
    }
    else if (c >= a && c >= b && c >= d && c >= e)
    {
        Console.WriteLine("{0} is the biggest.", c);
    }
    else if (d >= a && d >= b && d >= c && d >= e)
    {
        Console.WriteLine("{0} is the biggest.", d);
    }
    else if (e >= a && e >= b && e >= c && e >= d)
    {
        Console.WriteLine("{0} is the biggest.", e);
    }
    else
    {
        Console.WriteLine("There is not a bigger number.");
    }
}

//==9== Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
static void Question9()
{
    Console.Write("Input a value for 'n': ");
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"The \'{n}\' numbers are\n{i}");
            sum += i;
        }
        Console.WriteLine($"The sum of the \'{n}\' numbers is: {sum}");
    }
    else
    {
        Console.WriteLine("Invalid input for 'n'. Please enter a valid integer.");
    }
}

//==10== Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line
static void Question10()
{
    Console.Write("Input a value for 'n': ");
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}");
        }
    }
    else
    {
        Console.WriteLine("Invalid input for 'n'. Please enter a valid integer.");
    }
}

//==11== Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 
static void Question11()
{
    long num1 = 0;
    long num2 = 1;
    long sum = 1;


    for (int count = 0; count < 100; count++)
    {
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.WriteLine(num2);
        count++;
    }
}

//==12==




















