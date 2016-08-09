using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsumeWCFservice.CalcServiceReference1;

namespace ConsumeWCFservice
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient proxy = new CalculatorClient();

            double addResult = proxy.AddNumbers(24, 60);
            Console.WriteLine("Result of Add Operation:");
            Console.WriteLine(addResult);

            double minusResult = proxy.AddNumbers(0, 42);
            Console.WriteLine("Result of Minus Operation:");
            Console.WriteLine(minusResult);

            double divideResult = proxy.DivideNumbers(12, 6);
            Console.WriteLine("Result of Divide Operation:");
            Console.WriteLine(divideResult);

            double multResult = proxy.MultiplyNumbers(3, 4);
            Console.WriteLine("Result of Multiply Operation");
            Console.WriteLine(multResult);

            Console.WriteLine(Environment.NewLine + "Now that you've seen how math works, lets try some..." + Environment.NewLine);
            Console.WriteLine("Give me a number");
            String firstNum = Console.ReadLine();
            double num1 = CheckNumberString(firstNum);
            Console.WriteLine("Now give me a second number");
            String secondNum = Console.ReadLine();
            double num2 = CheckNumberString(secondNum);

            Console.WriteLine("Now we need an operator");
            ConsoleKeyInfo oper = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            double result = 0;
            switch (oper.KeyChar.ToString())
            {
                case "+":
                    Console.WriteLine("Adding!");
                    result = proxy.AddNumbers(num1, num2);                    
                    break;
                case "-":
                    Console.WriteLine("Subtracting");
                    result = proxy.SubtractNumbers(num1, num2); 
                    break;
                case "*":
                case "x":
                    Console.WriteLine("Multiplying!");
                    result = proxy.MultiplyNumbers(num1, num2); 
                    break;
                case "/":
                    Console.WriteLine("Dividing!");
                    result = proxy.DivideNumbers(num1, num2); 
                    break;
                default:
                    Console.WriteLine("I don't support that, better go buy a scientific calculator");
                    break;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static double CheckNumberString(string s)
        {
            double num1 = 0;
            bool result = double.TryParse(s, out num1);
            if (result)
            {
                Console.WriteLine(Environment.NewLine + "Thanks for the number!" + Environment.NewLine);
                return num1;
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Not a number, I'm just going to ignore your stupidity and use 0." + Environment.NewLine);
                return num1;
            }
        }
    }
}
