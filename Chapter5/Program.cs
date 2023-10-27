using System.ComponentModel;

class Excercise5
{
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
    }
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
    //==2== Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
    static void Question2()
    {
        // Console.Write("Enter first number: ");
        // int a = Int32.Parse(Console.ReadLine()!);
        // Console.Write("Enter second number: ");
        // int b = Int32.Parse(Console.ReadLine()!);
        // Console.Write("Enter third number: ");
        // int c = Int32.Parse(Console.ReadLine()!);

        // if (a > 0 && b > 0 && c > 0)
        // {
        //     Console.WriteLine("The product is positive (+).");
        // }
        // else if (a < 0 && b < 0 && c > 0)
        // {
        //     Console.WriteLine("The product is positive (+).");
        // }
        // else if (a < 0 && b > 0 && c < 0)
        // {
        //     Console.WriteLine("The product is positive (+).");
        // }
        // else if (a > 0 && b < 0 && c < 0)
        // {
        //     Console.WriteLine("The product is positive (+).");
        // }
        // else if (a == 0 || b == 0 || c == 0)
        // {
        //     Console.WriteLine("The product is (0) neither positive (+) nor negative (-).");
        // }
        // else
        // {
        //     Console.WriteLine("The product is negative (-).");
        // }

        //======Following The Guidlines======
        int negativeNumbersCount = 0;

        // Input three real numbers
        Console.Write("Enter the first number: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double C = Convert.ToDouble(Console.ReadLine());

        // Check each number for negativity and increament the counter 
        if (A < 0)
        {
            negativeNumbersCount++;
        }
        if (B < 0)
        {
            negativeNumbersCount++;
        }
        if (C < 0)
        {
            negativeNumbersCount++;
        }

        // Determining the sign of the product based on the counter result
        if (negativeNumbersCount % 2 == 0)
        {
            Console.WriteLine("The product is positive (+).");
        }
        else if (A == 0 || B == 0 || C == 0)
        {
            Console.WriteLine("The product is 0.");
        }
        else
        {
            Console.WriteLine("The product is negative (-).");
        }
    }
    //==3== Write a program that finds the biggest of three integers, using nested if statements.
    static void Question3()
    {
        Console.Write("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter third number: ");
        int c = Int32.Parse(Console.ReadLine()!);

        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine("All numbers are equal");
            }
            else if (a < c)
            {
                Console.WriteLine($"{c} is the biggest");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are the biggest");
            }
        }
        else if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine($"{a} is the biggest");
            }
            else if (a < c)
            {
                Console.WriteLine($"{c} is the biggest");
            }
            else
            {
                Console.WriteLine($"{a} and {c} are the biggest");
            }
        }
        else if (a < b)
        {
            if (b > c)
            {
                Console.WriteLine($"{b} is the biggest");
            }
            else if (b < c)
            {
                Console.WriteLine($"{c} is the biggest");
            }
            else
            {
                Console.WriteLine($"{b} and {c} are the biggest");
            }
        }
    }
    //==4==  Sort 3 real numbers in descending order.
    static void Question4()
    {
        Console.Write("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter third number: ");
        int c = Int32.Parse(Console.ReadLine()!);

        int[] myNums = {a, b, c};
        Array.Sort(myNums);
        Console.WriteLine(myNums.Max());
        Console.WriteLine(myNums[1]);
        Console.WriteLine(myNums.Min());
    }
    //==5== Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
    static void Question5()
    {
        Console.Write("Enter Number (0-9): ");
        int num = Int32.Parse(Console.ReadLine()!);

        switch (num)
        {
            case 0: Console.WriteLine("Verilly"); break;
            case 1: Console.WriteLine("There"); break;
            case 2: Console.WriteLine("Shall"); break;
            case 3: Console.WriteLine("Be"); break;
            case 4: Console.WriteLine("Hardship"); break;
            case 5: Console.WriteLine("And"); break;
            case 6: Console.WriteLine("Then"); break;
            case 7: Console.WriteLine("Ease"); break;
            case 8: Console.WriteLine("To"); break;
            case 9: Console.WriteLine("Complement"); break;
            default: Console.WriteLine("Invalid Input(0-9 only)"); break;
        }
    }
    //==6== Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
    static void Question6()
    {
        Console.Write("Enter first coefficient 'a': ");
        int a = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter second coefficient 'b': ");
        int b = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter third coefficient 'c': ");
        int c = Int32.Parse(Console.ReadLine()!);

        int d = (b*b) - (4*a*c); Console.WriteLine($"Discriminant D = {d}");
        
        if (d == 0)
        {
            double x1 = (-b / 2 * a);
            Console.WriteLine($"The real root of the quadratic equation: {a}x^2 + {b}x + {c} = x is:\nX= {x1}");
        }
        else if (d > 0)
        {
            double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
            double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine($"The real root of the quadratic equation: {a}x^2 + {b}x + {c} = x are:\nX1={x1}\nX2={x2}");
        }
        else
        {
            Console.WriteLine($"Discriminant D={d}\nTherefore has no real roots.");
        }
        
    }
    //==7== Write a program that finds the greatest of given 5 numbers.
    static void Question7()
    {
        Console.Write("Enter first number: ");
        long a = Int64.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        long b = Int64.Parse(Console.ReadLine()!);
        Console.Write("Enter third number: ");
        long c = Int64.Parse(Console.ReadLine()!);
        Console.Write("Enter fourth number: ");
        long d = Int64.Parse(Console.ReadLine()!);
        Console.Write("Enter fifth number: ");
        long e = Int64.Parse(Console.ReadLine()!);

        if (a == b && b == c && c == d && d == e) 
        {
            Console.WriteLine("All numbers are equal");
        }
        
            if (b <= a && c <= a && d <= a && e <= a)
            {
                Console.WriteLine($"{a} is the greatest");
            }
            else if (a <= b && c <= b && d <= b && e <= b)
            {
                Console.WriteLine($"{b} is the greatest");
            }
            else if (a <= c && b <= c && d <= c && e <= c)
            {
                Console.WriteLine($"{c} is the greatest");
            }
            else if (a <= d && b <= d && c <= d && e <= d)
            {
                Console.WriteLine($"{d} is the greatest");
            }
            else 
            {
                Console.WriteLine($"{e} is the greatest");
            }
    }
    //==8== Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
    static void Question8()
    {
        Console.Write("Input a variable type (0 - int, 1 - double, 2 - string): ");
        int varIndicator = Int32.Parse(Console.ReadLine()!);

        switch (varIndicator)
        {
            case 0:
                {
                    Console.Write("Enter a int value: ");
                    int intValue = Int32.Parse(Console.ReadLine()!);
                    intValue++;
                    Console.WriteLine($"Int value increased by 1 = {intValue}");
                    break;
                }
            case 1:
                {
                    Console.Write("Enter a double value: ");
                    double doubleValue = double.Parse(Console.ReadLine()!);
                    doubleValue++;
                    Console.WriteLine($"Double value increased by 1 = {doubleValue}");
                    break;
                }
            case 2:
                {
                    Console.Write("Enter string variable: ");
                    string stringVar = Console.ReadLine()!;
                    stringVar = stringVar + '*';
                    Console.WriteLine($"String variable + * = {stringVar}");
                    break;
                }
            default:
            {
                Console.WriteLine("Invalid input"); 
                break;
            }
        } 

    }
    //==9== We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0
    static void Question9()
    {
        Console.Write("Enter first number: ");
            int first = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            int second = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter third number: ");
            int third = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter fourth number: ");
            int fourth = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter fifth number: ");
            int fifth = Int32.Parse(Console.ReadLine()!);

            if(first + second == 0)
                Console.WriteLine("{0} + {1} = 0", first, second);
            else if (first + third == 0)
                Console.WriteLine("{0} + {1} = 0", first, third);
            else if (first + fourth == 0)
                Console.WriteLine("{0} + {1} = 0", first, fourth);
            else if (first + fifth == 0)
                Console.WriteLine("{0} + {1} = 0", first, fifth);
            else if (second + third == 0)
                Console.WriteLine("{0} + {1} = 0", second, third);
            else if (second + fourth == 0)
                Console.WriteLine("{0} + {1} = 0", second, fourth);
            else if (second + fifth == 0)
                Console.WriteLine("{0} + {1} = 0", second, fifth);
            else if (third + fourth == 0)
                Console.WriteLine("{0} + {1} = 0", third, fourth);
            else if (third + fifth == 0)
                Console.WriteLine("{0} + {1} = 0", third, fifth);
            else if (fourth + fifth == 0)
                Console.WriteLine("{0} + {1} = 0", fourth, fifth);
            else if (first + second + third == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, third);
            else if (first + second + fourth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fourth);
            else if (first + second + fifth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fifth);
            else if (first + third + fourth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fourth);
            else if (first + third + fifth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fifth);
            else if (second + third + fourth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fourth);
            else if (second + third + fifth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fifth);
            else if (third + fourth + fifth == 0)
                Console.WriteLine("{0} + {1} + {2} = 0", third, fourth, fifth);
            else
            Console.WriteLine("There are no subsets with sum which equals 0.");
    }
    //==10== 
    static void Question10()
    {
        Console.Write("Enter a score between 1 and 9: ");
        int score = Int32.Parse(Console.ReadLine()!);
       
        if (score >= 1 && score <= 3)
        {
            Console.WriteLine("Score multiplied by 10 points: {0}", score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine("Score multiplied by 100 points: {0}", score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.WriteLine("Score multiplied by 1000 points: {0}", score * 1000);
        }
        else
        {
            Console.WriteLine("Invalid input, Score is out of range.");
        }
    }
    //==11==
    static void Question11()
    {

    }
    












}


