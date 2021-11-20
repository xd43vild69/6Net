using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6BaseLib;
public class Recursion
{

    public int ConvertNumberToBinary(int num)
    {
        int bin;
        if (num != 0)
        {
            bin = (num % 2) + 10 * ConvertNumberToBinary(num / 2);
            Console.Write(bin);
            return 0;
        }
        else
        {
            return 0;
        }
    }

    public void Fibonacci(int iterations)
    {

        int num1 = 0;
        int num2 = 1;

        string fib = $"{num1} {num2} " + Fibonacci(num1, num2, iterations - 1);

        Console.WriteLine(fib);
    }

    private string Fibonacci(int num1, int num2, int counter)
    {
        if (counter > 0)
        {
            counter--;
            return $"{num1 + num2} " + Fibonacci(num2, num1 + num2, counter);
        }
        else
        {
            return " ";
        }
    }

}

