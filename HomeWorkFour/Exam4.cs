using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exam4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            PrintReversedDigits(number);
        }
        static void PrintReversedDigits(int number)
        {
            Queue digitsQueue=new Queue();
            while(number>0)
            {
                int digit=number%10;
                digitsQueue.Enqueue(digit);
                number/=10;
            }
            Console.WriteLine("Reversed Didits");
            while (digitsQueue.Count>0)
            {
                Console.Write(digitsQueue.Dequeue()+"");
            }
        }
    }
}
