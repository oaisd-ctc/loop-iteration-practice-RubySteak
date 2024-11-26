using System;

public class Program
{
    public static void Main(string[] args) // done
    {
        WriteEvensThrough100();

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Console.WriteLine("");
        Write1ThroughN_While(0);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Console.WriteLine("");
        Write1ThroughN_For(0);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        Console.WriteLine("");
        WriteNThrough1_While(0);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");


        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        Console.WriteLine("");
        WriteNThrough1_For(0);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(0);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("");

        Thread.Sleep(700);
        OutputRightTriangle(4);
        Console.WriteLine("");
        OutputRightTriangle(6);
        Console.WriteLine("");
        OutputRightTriangle(-4);
        Console.WriteLine("");
        OutputRightTriangle(-6);
        Console.WriteLine("");
        OutputRightTriangle(0);
        Console.WriteLine("");
    }

    public static void Write1ThroughN_While(int n) // done
    {
        int a = 1;
        int x = n;
        
        if (n <= 0)
        {
            OutOfRangeMessage(x);
        }
        
        while (n >= a)
        {
            Console.Write(a + " ");
            a++;
        }
    }

    public static void Write1ThroughN_For(int n) // done
    {
        int x = n;

        if (n <= 0)
        {
            OutOfRangeMessage(x);
        }

        for (int a = 1; n >= a;)
        {
            Console.Write(a + " ");
            a++;
        }
    }

    public static void WriteNThrough1_While(int n) // done
    {
        int x = n;

        if (n <= 0)
        {
            OutOfRangeMessage(x);  
        }
        
        while (n > 0)
        {
            Console.Write(n + " ");
            n--;
        }

    }

    public static void WriteNThrough1_For(int n) // done
    {
        int x = n;

        if (n <= 0)
        {
            OutOfRangeMessage(x);
        }

        for (int a = 1; n >=a;)
        {
            Console.Write(n + " ");
            n--;
        }
    }

    public static void WriteEvensThrough100() // done
    {
        for (int x = 0; x < 101; x+=2)
        {
            Console.Write(x + " ");
            Thread.Sleep(40);
        }
    }

    public static void FindSum(int n) // done
    {
        int sum = 0;
        
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (0 < n) // Calculates and outputs the sum of all numbers from 1 to n
            {
                while (n > 0)
                {
                    sum += n;
                    n--;
                }
            }
            else // Calculates and outputs the sum of all numbers from n to 1 if 1 > n
            {
                while (n < 1) 
                {
                    sum += n;
                    n++;
                }
            }
            Console.WriteLine(sum);
        }
    }

    public static void FindSumOfEvenNumbers(int n) // done
    {
        int x = n;
        int sum = 0;

        if (n%2 == 0)
        {
            while (n > 0)
            {
                sum += n;
                n-=2;
            }
            Console.WriteLine(sum);
        }
        else if (n%2 == 1)
        {
            n--;
            while (n > 0)
            {
                sum += n;
                n-=2;
            }
            Console.WriteLine(sum);

        }
        else if (n%2 == -1)
        {
            n++;
            while (n <= 0)
            {
                sum -= n;
                n+=2;
            }
            Console.WriteLine(-1 * sum);

        }
    }

    public static void FindSumOfOddNumbers(int n) // uuuuuuuuuhhhhhhhhh nothing to see here :3
    {
        int x = n;
        int sum = 0;

        if (n%2 == 0) // .
        {
            while (n > 0)
            {
                sum += n;
                n-=1;
            }
            Console.WriteLine(sum);
        }
        else if (n%2 == 1) // .
        {
            n--;
            while (n > 0)
            {
                sum += n;
                n-=1;
            }
            Console.WriteLine(sum);

        }
        else if (n%2 == -1) // .
        {
            n++;
            while (n <= 0)
            {
                sum -= n;
                n+=1;
            }
            Console.WriteLine(-1 * sum);

        }
    }

    public static void OutputRightTriangle(int _base) // done
    {
        if (_base == 0)
        {
            OutOfRangeMessage(_base);
        }
        if (_base == 1)
        {
            Console.WriteLine("*");
        }
        else if (_base == 2)
        {
            Console.WriteLine("*\n**");
        }
        else if (_base == 3)
        {
            Console.WriteLine("*\n**\n***");
        }
        else if (_base == 4)
        {
            Console.WriteLine("*\n**\n***\n****");
        }
        else if (_base == 5)
        {
            Console.WriteLine("*\n**\n***\n****\n*****");
        }
        else if (_base == 6)
        {
            Console.WriteLine("*\n**\n***\n****\n*****\n******");
        }
        else if (_base == 7)
        {
            Console.WriteLine("*\n**\n***\n****\n*****\n******\n*******");
        }
        else if (_base == 8)
        {
            Console.WriteLine("*\n**\n***\n****\n*****\n******\n*******\n********");
        }
        else if (_base == -1)
        {
            Console.WriteLine("*");
        }
        else if (_base == -2)
        {
            Console.WriteLine("**\n*");
        }
        else if (_base == -3)
        {
            Console.WriteLine("***\n**\n*");
        }
        else if (_base == -4)
        {
            Console.WriteLine("****\n***\n**\n*");
        }
        else if (_base == -5)
        {
            Console.WriteLine("*****\n****\n***\n**\n*");
        }
        else if (_base == -6)
        {
            Console.WriteLine("******\n*****\n****\n***\n**\n*");
        }
        else if (_base == -7)
        {
            Console.WriteLine("*******\n******\n*****\n****\n***\n**\n*");
        }
        else if (_base == -8)
        {
            Console.WriteLine("********\n*******\n******\n*****\n****\n***\n**\n*");
        }
    }

    public static void OutOfRangeMessage(int n) // done
    {
        Console.WriteLine( n + " is out of range where " + n + " is the integer parameter.");
    }
}