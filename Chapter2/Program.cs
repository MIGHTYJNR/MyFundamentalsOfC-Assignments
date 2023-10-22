//=====Solutions to Chapter Two Exercises====

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
    Question12();
    Question13();
}
//==1== Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
static void Question1()
{
    sbyte num1 = -115;
    ushort num2 = 52130;
    int num3 = 4825932;
    byte num4 = 97;
    short num5 = -10000;
    ushort num6 = 20000;
    byte num7 = 224;
    int num8 = 970700000;
    sbyte num9 = 112;
    sbyte num10 = -44;
    int num11 = -1000000;
    short num12 = 1990;
    long num13 = 123456789123456789;
}

//==2== Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
static void Question2()
{
    float values = -5.01F;
    float valueS = 12.345F;
    double value1 = 5d;
    double value11 = 34.567839023d;
    double value12 = 8923.1234857d;
    decimal value2 = 3456.091124875956542151256683467M;
}
//==3== Write a program, which compares correctly two real numbers with accuracy at least o.000001.
static void Question3()
{
    double realNum1 = 7;
    double realNum2 = 6.9999999;
    double accuracy = 0.000001;
    double comparisonResult = realNum1 - realNum2;
    Console.WriteLine($"The differ is: {comparisonResult}");
    if (comparisonResult < accuracy)
    {
        Console.WriteLine("The numbers are equal according to the specified accuracy.");
    }
    else if (realNum1 < realNum2)
    {
        Console.WriteLine("The first number is smaller");
    }
    else
    {
        Console.WriteLine("The second number is smaller");
    }
}
//==4== Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
static void Question4()
{
    int hexValue = 0x100;
    Console.WriteLine(hexValue);
}
//==5== Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
static void Question5()
{
    char charValue = (char)72;
    Console.WriteLine(charValue);
}

//==6== Declare a variable isMale of type bool and assign a value to it depending on your gender.
static void Question6()
{
    bool isMale = true;
    Console.WriteLine($"I am a Male: {isMale}");
}

//==7== Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
static void Question7()
{
    string wave = "Hello";
    string globe = "World";
    object greetings = wave + " " + globe;
    Console.WriteLine(greetings);
}

//==8==  Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting)
static void Question8()
{
    string wave = "Hello";
    string globe = "World";
    object greetings = wave + " " + globe;
    string finalGreeting = greetings.ToString()!;
    Console.WriteLine(finalGreeting);
}

//==9== Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
static void Question9()
{
    string quotedString = "The \"use\" of quotations causes difficulties.";
    string unQuotedString = "The use of quotations causes difficulties";
    Console.WriteLine(quotedString); Console.WriteLine(unQuotedString);
}

//==10== Write a program to print a figure in the shape of a heart by the sign "o".
static void Question10()
{
    Console.WriteLine(" o  o       o o");
    Console.WriteLine("o     o   o     o");
    Console.WriteLine("o       o       o");
    Console.WriteLine("o               o");
    Console.WriteLine(" o             o ");
    Console.WriteLine("   o         o   ");
    Console.WriteLine("     o     o     ");
    Console.WriteLine("        o        ");
}

//==11== Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
static void Question11()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    {
        Console.WriteLine("    ©    ");
        Console.WriteLine("  ©   ©  ");
        Console.WriteLine(" ©     © ");
        Console.WriteLine("© © © © ©");
    }
}

//==12== A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
static void Question12()
{
    string firstName;
    string lastName;
    byte age;
    char gender;
    int employeeNum;
}

//==13== Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
static void Question13()
{
    int firstNum = 5;
    int secondNum = 10;
    firstNum = firstNum + secondNum;//firstnum = 5+10 =15
    secondNum = firstNum - secondNum;//secondNum = 15-10 =5
    firstNum = firstNum - secondNum;//fistnum = 15-5 =10
    Console.WriteLine(firstNum);
    Console.WriteLine(secondNum);
}


