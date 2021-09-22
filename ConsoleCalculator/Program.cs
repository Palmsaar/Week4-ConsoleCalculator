using System;

namespace ConsoleCalculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tConsole Calculator!\r");
            Console.WriteLine("\t\t\t-------------------\r");

            Console.WriteLine("\t\t\tEnter first number!\n");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an operator (+, -, *, /, %)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number!\n");
            secondNum = Double.Parse(Console.ReadLine());
            if (ops == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(answer);
            }
            else if (ops == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(answer);
            }
            else if (ops == "*")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(answer);
            }
            else if (ops == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(answer);
            }
            else if (ops == "%")
            {
                answer = firstNum % secondNum;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("\n" + "Press any key to exit...");
            Console.ReadKey();

        }
    }
}
