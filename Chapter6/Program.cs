class Excercise6
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
        // Question11();
        // Question12();
        // Question13();
        // Question14();
        // Question15();
        // Question16();
        // Question17();
        // Question18();
    }
    //==1== Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
    static void Question1()
    {
        Console.Write("Enter the (N) number: ");
        int N = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= N; i++)
        {
            Console.Write($"{i} ");
        }
    }
    //==2== Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
    static void Question2()
    {
        Console.WriteLine(" ");
        Console.Write("Enter the (N) number: ");
        int N = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= N; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write($"{i} ");
            }
        }

    }
    //==3== Write a program that reads from the console a series of integers and prints the smallest and largest of them.
    static void Question3()
    {
        int smallest = int.MaxValue;
        int largest = int.MinValue;

        Console.Write("Enter the count of integer numbers: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n <= 0)
        {
            Console.WriteLine("Invalid count of integer numbers.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number < smallest)
            {
                smallest = number;
            }

            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine("Smallest number: " + smallest);
        Console.WriteLine("Largest number: " + largest);
    }
    //==4== Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
    static void Question4()
    {
        for (int suit = 1; suit <= 4; suit++)
        {
            for (int cards = 2; cards <= 14; cards++)
            {
                switch (cards)
                {
                    case 2: Console.Write("2 of "); break;
                    case 3: Console.Write("3 of "); break;
                    case 4: Console.Write("4 of "); break;
                    case 5: Console.Write("5 of "); break;
                    case 6: Console.Write("6 of "); break;
                    case 7: Console.Write("7 of "); break;
                    case 8: Console.Write("8 of "); break;
                    case 9: Console.Write("9 of "); break;
                    case 10: Console.Write("10 of "); break;
                    case 11: Console.Write("J of "); break;
                    case 12: Console.Write("Q of "); break;
                    case 13: Console.Write("K of "); break;
                    case 14: Console.Write("A of "); break;
                }
                switch (suit)
                {
                    case 1:
                        Console.WriteLine("Clubs ");
                        break;
                    case 2:
                        Console.WriteLine("Diamonds ");
                        break;
                    case 3:
                        Console.WriteLine("Hearts ");
                        break;
                    case 4:
                        Console.WriteLine("Spades ");
                        break;
                }
            }
        }
    }
    //==5== Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
    static void Question5()
    {
        Console.Write("Enter the number of Fibonacci numbers you want to sum (N): ");
        int N = int.Parse(Console.ReadLine()!);

        int num1 = 0;
        int num2 = 1;
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += num1;
            int newNum3 = num1 + num2;
            num1 = num2;
            num2 = newNum3;
        }
        Console.WriteLine($"The sum of the first {N} Fibonacci numbers is: {sum}");
    }
    //==6== Write a program that calculates N!/K! for given N and K (1<K<N).
    static void Question6()
    {
        Console.Write("Enter the value of 'N' (1<K<N): ");
        int N = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of 'K' (1<K<N): ");
        int K = int.Parse(Console.ReadLine()!);

        if (K <= 1 || K >= N)
        {
            Console.WriteLine("Invalid values! 'K' must be greater than 1 and less than 'N' (1<K<N).");
            return;
        }
        for (int i = N - 1; i > 0; i--)
        {
            N *= i;
        }
        for (int i = K - 1; i > 0; i--)
        {
            K *= i;
        }
        long result = N / K;
        Console.WriteLine($"N!/K! = {result}");
    }
    //==7== Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).
    static void Question7()
    {
        Console.Write("Enter the value of 'N' (1<K<N): ");
        int N = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of 'K' (1<K<N): ");
        int K = int.Parse(Console.ReadLine()!);
        int denominator = N - K;

        if (K <= 1 || K >= N)
        {
            Console.WriteLine("Invalid values! 'K' must be greater than 1 and less than 'N' (1<K<N).");
            return;
        }
        for (int i = N - 1; i > 0; i--)
        {
            N *= i;
        }
        for (int i = K - 1; i > 0; i--)
        {
            K *= i;
        }
        for (int i = denominator - 1; i > 0; i--)
        {
            denominator *= i;
        }

        long result = N * K / denominator;
        Console.WriteLine($"N!*K!/(N-K)! = {result}");
    }
    //==8== In combinatorics, the Catalan numbers are calculated by the following formula: Cn = (2n)! / (n+1)!*n!, for n ≥ 0. Write a program that calculates the nth Catalan number by given n.
    static void Question8()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine()!);
        int numerator2N = 2 * n;
        int denominatorNplus1 = n + 1;


        if (n < 0)
        {
            Console.WriteLine("Invalid values! N must not be less than Zero.");
            return;
        }
        for (int i = numerator2N - 1; i > 0; i--)
        {
            numerator2N *= i;
        }
        for (int i = denominatorNplus1 - 1; i > 0; i--)
        {
            denominatorNplus1 *= i;
        }
        for (int i = n - 1; i > 0; i--)
        {
            n *= i;
        }
        Console.WriteLine("(2n)! / (n+1)!*n! = {0}", numerator2N / (denominatorNplus1 * n));
    }
    //==9== Write a program that for a given integers n and x, calculates the sum: S=1 + 1!/x + 2!/x^2 + ... n!/x^n
    static void Question9()
    {
        Console.Write("Enter n: ");
        int n = Int32.Parse(Console.ReadLine()!);
        Console.Write("Enter x: ");
        int x = Int32.Parse(Console.ReadLine()!);

        double sum = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i / Math.Pow(x, i);
            sum += factorial;
        }
        Console.WriteLine($"The sum S is: {sum}");
    }
    //==10== 
    static void Question10()
    {
       
    }

}
