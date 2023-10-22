//=====Solutions to Chapter Three Exercises====
static void Main(string[] args)
{
    Question1();
    Question2();
    Question3();
    //Question4();
    Question5();
    Question6();
    Question7();
    Question8();
    //Question9();
    Question10();
    Question11();
    Question12();
    //Question13();
    Question14();
    // Question15();
    //Question16();
}
//==1== Write an expression that checks whether an integer is odd or even.
static void Question1()
{
    Console.WriteLine("Input an integer");
    int userInput = int.Parse(Console.ReadLine()!);
    int oddOrEven = userInput % 2; Console.WriteLine(oddOrEven);
    if (oddOrEven == 0)
    {
        Console.WriteLine($"{userInput} is an even number");
    }
    else
    {
        Console.WriteLine($"{userInput} is an odd number");
    }
}

//==2== Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
static void Question2()
{
    bool isDivisibleBy5And7 = (userInput % 5 == 0) && (userInput % 7 == 0);
    if (isDivisibleBy5And7)
    {
        Console.WriteLine($"{userInput} is divisible by both 5 and 7");
    }
}

//==3== Write an expression that looks for a given integer if its third digit (right to left) is 7.
static void Question3()
{
    Console.WriteLine("Input an intiger you want to check if its third digit is = 7");
    int number = int.Parse(Console.ReadLine()!);
    bool isSeven = (number / 100) % 10 == 7 ? true : false;
    Console.WriteLine(isSeven);
    if (isSeven == true)
    {
        Console.WriteLine($"Third digit of {number} is 7");
    }
}

//==4== 
//==5== Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
static void Question5()
{
    int a = 2, b = 4, h = 6;
    int areaOfTrapezoid = (a + b) * h / 2;
    Console.WriteLine("Area of trapezoid is:" + areaOfTrapezoid);
}

//==6== Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
static void Question6()
{
    Console.Write("Enter Side: ");
    int side = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Height: ");
    int height = Convert.ToInt32(Console.ReadLine());
    int perimeterOfRectangle = 2 * (side + height), areaOfRectangle = side * height;
    Console.WriteLine($"Perimeter of rectangle= {perimeterOfRectangle}\nArea of rectangle= {areaOfRectangle}");
}

//==7== The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
static void Question7()
[
    Console.WriteLine("Enter weight of a man: ");
    int weight = Convert.ToInt32(Console.ReadLine());
    double weightOnMoon = weight * 0.17;
    Console.WriteLine($"This person will weight {weightOnMoon}kg on the Moon.");
]

//==8== Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
static void Question8()
{
    Console.Write("Enter x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    bool isInside = ((x * x) + (y * y) <= 5 * 5) ? true : false;
    if (isInside == true)
    {
        Console.WriteLine($"The point ({x},{y}) is within the circle K((0,0),5)");
    }
    else
    {
        Console.WriteLine($"The point ({x},{y}) is not within the circle K((0,0),5)");
    }
}

//==9== Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
//==10== Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following actions:
// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// - Prints on the console the number in reversed order: dcba (in our example 1102).
// - Puts the last digit in the first position: dabc (in our example 1201).
// - Exchanges the second and the third digits: acbd (in our example 2101)
static void Question10()
{
    Console.Write("Enter a four digit number: ");
    int fourDigitNum = Convert.ToInt32(Console.ReadLine());
    int aa = fourDigitNum / 1000;
    int bb = (fourDigitNum / 100) % 10;
    int cc = (fourDigitNum / 10) % 10;
    int dd = fourDigitNum % 10;

    Console.WriteLine($"1.Sum of digits: ({aa}+{bb}+{cc}+{dd})= {aa + bb + cc + dd}");
    Console.WriteLine($"2.Digits backwards = {dd} {cc} {bb} {aa}");
    Console.WriteLine($"3.Last digit on first place = {dd} {aa} {bb} {cc}");
    Console.WriteLine($"4.Replace third and second digit =  {aa} {cc} {bb} {dd}");
}

//==11== We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
static void Question11()
{
    int n = 35;
    int p = 5;
    int result = (n >> p) & 1; Console.WriteLine(result);
}

//==12== Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
static void Question12()
{
    int v = 5;
    //int p = 1;
    int mask = 1 >> p;
    bool isBitSetOne = (v & mask) != 0 ? true : false;
    Console.Write(isBitSetOne);
    if (isBitSetOne == true)
    {
        Console.WriteLine($", The bit at position {p} of number {v} is 1");
    }
}


//==13== 
//==14== Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
static void Question14()
{
    // int n = 1, a = 0;
    // for (int i = 1; i <= n; i++)
    // {
    //     if (n % i == 0) 
    //     {
    //         a++;
    //     }
    // }
    //     if (a == 2) 
    //     {
    //     Console.WriteLine("{0} is a Prime Number", n);
    //     }
    //     else 
    //     {
    //     Console.WriteLine("{0} is NOT a Prime Number", n);
    //     }
    int n = 9;   // The number to check
    int a = 0;   // A counter for the number of factors

    if (n <= 1)
    {
        Console.WriteLine("{0} is NOT a Prime Number", n);
    }
    else if (n == 2)
    {
        Console.WriteLine("2 is a Prime Number");
    }
    else if (n % 2 == 0)
    {
        Console.WriteLine("{0} is NOT a Prime Number", n);
    }
    else
    {
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
            {
                a++;  // Increment the counter when 'n' is divisible by 'i'
            }
        }

        if (a == 0)
        {
            Console.WriteLine("{0} is a Prime Number", n);
        }
        else
        {
            Console.WriteLine("{0} is NOT a Prime Number", n);
        }
    }
}

//==15==
//==16==


