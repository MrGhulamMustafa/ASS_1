using System;
using System.ComponentModel.Design;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question_1:
            static void Sum() {
                Console.Write("Enter First Number >> ");
                int FirstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number >> ");
                int SecondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Sum of {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}");
            }
            Sum();
            
            //Questio_2:
            static void Even()
            {
                int StartNumber = 2;
                while(StartNumber <=100)
                {
                    Console.WriteLine(StartNumber);
                    StartNumber+=2;
                }
            }
            Even();

            //Question_3:
            static void IsLeap()
            {
                Console.Write("Enter an year >> ");
                int Year = int.Parse(Console.ReadLine());
                if (Year!=0 & Year%4==0 & Year%100!=0)
                {
                    Console.WriteLine("This is a leap year");
                }
                else if (Year!=0 & Year % 400 == 0)
                {
                    Console.WriteLine("This is a leap year");
                }
                else
                {
                    Console.WriteLine("This is not a leap year");
                }

            }
            IsLeap();

            //Question_4:
            static void Convert()
            {
                Console.Write("Enter the speed >> ");
                int Speed = int.Parse(Console.ReadLine());
                Console.WriteLine($"The speed in miles per hours is {Speed*0.621371}");
            }
            Convert();

            //Question_5:
            static void IsBuzz()
            {
                Console.Write("Enter a number >> ");
                int Number = int.Parse(Console.ReadLine());
                string StringName = Number.ToString();
                char LastDg = StringName[StringName.Length-1];
                int LastDigit = LastDg - '0';
                if (Number!=0 & Number % 7 == 0 | LastDigit == 7)
                {
                    Console.WriteLine($"{Number} is Buzz");
                }
                else
                {
                    Console.WriteLine($"{Number} is not Buzz");
                }
            }
            IsBuzz();

            //Question_6:
            static void Table()
            {
                Console.Write("Enter a number >> ");
                int TableNumber = int.Parse(Console.ReadLine());
                int i= 1;
                while(i <=10)
                {
                    Console.WriteLine($"{TableNumber} X {i} = {TableNumber * i}");
                    i++;
                }
            }
            Table();

            //Question_7:
           static void FindFactorial()
            {
                Console.Write("Enter a number >> ");
                int FactorialNumber = int.Parse(Console.ReadLine());
                int Factorial = 1;
                if (FactorialNumber == 0) { Console.WriteLine("Factorial is 0"); }
                else
                {
                    while(FactorialNumber > 0)
                    {
                        Factorial=Factorial*FactorialNumber;
                        FactorialNumber--;
                    }
                }
                Console.WriteLine($"Factorial is {Factorial}");
            }
            FindFactorial();

            //Question_8:
            static void IsPrime()
            {
                Console.Write("Enter a number >> ");
                int PNumber = int.Parse(Console.ReadLine());
                bool prime = true;
                if (PNumber == 1| PNumber==0)
                {
                    Console.WriteLine($"{PNumber} is not a prime number");
                }
                else
                {
                    while (PNumber % (PNumber / 2) == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(PNumber!=1 & prime |PNumber==2)
                {
                    Console.WriteLine($"{PNumber} is a Prime Number");
                }
                else
                {
                    Console.WriteLine($"{PNumber} is not a prime number");
                }
            }
            IsPrime();

            //Question_9:
            static void TriangleType()
            {
                Console.Write("Enter a number >> ");
                int Number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter a number >> ");
                int Number2 = int.Parse(Console.ReadLine());
                Console.Write("Enter a number >> ");
                int Number3 = int.Parse(Console.ReadLine());
                if (Number1 == Number2 & Number2 == Number3)
                {
                    Console.WriteLine("Triangle is equilatral");
                }
                else if (Number1 == Number2 | Number1 == Number3)
                {
                    Console.WriteLine("Triangle is isoclece");
                }
                else
                {
                    {
                        Console.WriteLine("Triangle is scalene");
                    }
                }
            }
            TriangleType();

            //Question_10:
            static void star()
            {
                int nrows = 5;
                int i = 1;
                while (i <=nrows)
                {
                    int j = 1;
                    while(j <= i)
                    {
                        Console.Write("*");
                        j++;
                    }
                    i++;
                    Console.WriteLine();
                }
            }
            star();

            //Bonus_Question:
            static void palindrome()
            {
                Console.Write("Enter a number >> ");
                int Number = int.Parse(Console.ReadLine());
                string strNumber=Number.ToString();
                bool plan=false;
                for (int i = 1; strNumber[i-1] == strNumber[strNumber.Length - i]; i++)
                {
                    plan=true;
                    if(i== strNumber.Length)
                    {
                        break;
                    }
                }
                if (plan)
                {
                    Console.WriteLine($"{Number} is palindrome");
                }
                else{
                    Console.WriteLine($"{Number} is not palindrome");
                }
            }
            palindrome();
        }
    }
}