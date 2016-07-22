using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar_Problem_2
{
    class randomNum
    {
        static void Main(string[] args)
        {
            // Enter 1st number
            int a;
            Console.WriteLine("Enter a number:");
            Console.ReadKey();
            
            //Enter operation
            Console.WriteLine("Enter math operation:");
            char[] operators = { '+', '-', '*', '/' };
            char op = operators[r.Next(operators.Length)];
            Console.ReadKey();

            //Enter 2nd number
            int b;
            Console.WriteLine("Enter a number:");
            Console.ReadKey();
            {
                op = answer
                switch (op)
                {
                    case '+':
                        answer = a + b;
                        break;

                    case '-':
                        answer = a - b;
                        break;

                    case '*':
                        answer = a * b;
                        break;

                    case '/':
                        answer = a / b;
                        break;

                        Console.WriteLine(op answer);
                        Console.ReadKey();
                        Console.Write("Do you want to enter another number?(YES/No):" + "\n");
                }
                char y = (char)Console.Read();

                if (Char.IsLetter(y))
                {
                    if (Char.IsUpper(y))
                    {
                        Console.WriteLine("Continue");
                    }
                    else
                    {
                        Console.WriteLine("Goodbye:");
                    }

                }
    }

