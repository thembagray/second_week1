using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_week1
{
    internal class Program
    {

        static void numbers() {

            Console.WriteLine(5);
            Console.WriteLine(5 + 6);
            Console.WriteLine(5%2);
            Console.WriteLine(4+2*3);
            Console.WriteLine(5/2);
            Console.WriteLine(5/2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2,2));
        
        }
        static void user_input() {
            Console.WriteLine("Enter your name");

            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("How old are you? ");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + "old");
        
        }
        static void Calculator() {

            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);
        }
        static void for_arr()
        {
            int[] luckyNumber = { 4, 5, 8, 9, };

            Console.WriteLine(luckyNumber[0]);

            string[] friends = new string[5];

            friends[0] = "Jim";
            friends[1] = "John";
            friends[2] = "Peter";
            Console.WriteLine(friends[0]);
        }
        static void methods() { 

             void sayHi()
            {
                Console.WriteLine("Hi");
            }

            void sayHiUser(string name)
            {
                Console.WriteLine("Hello " + name);
            }

            void sayHiAge(string name, int age)
            {
                Console.WriteLine("Hello " + name + " you are " + age);
            }

            sayHi();
            sayHiAge("John", 55);
            sayHiUser("Evans");
            
        }
        static void if_statements() {

            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are a male");
            }else {
                Console.WriteLine("You are female");
                    }

            bool isTall = false;

            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall");

            }else if (!isTall && isMale)
            {
                Console.WriteLine("You are not tall but you are male");
            }
            else {
                Console.WriteLine("You are either not tall or not a male");
                    }
        }
        static void if_statemets_2() {

            Console.WriteLine(getMax(2, 10));

            int getMax(int num1, int num2)
            {
                if (num1 > num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }

            
        }
        static void for_return() {

            Console.WriteLine(cube(5));

            cube(5);

            Console.ReadLine();

            int cube(int num)
            {
                int results = num * num * num;
                return results;
            }
        }
        static void calculator_user_input() {

            Console.WriteLine("Enter  a first number ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter  a  second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Not an operator");
            }
        }
        static void for_switch() { 
        
            Console.Write("Enter a number (1 - 3): ");

            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine("You entered '1'");
                    break;
                case 2:
                    Console.WriteLine("You entered '2'");
                    break;
                case 3:
                    Console.WriteLine("You entered '3'");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3");
                    break;
            }
        }
        static void for_while() {

            int index = 0;

            Console.WriteLine("This is the while loop");

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("This is the do while loop");
            int index2 = 0;
            do
            {
                Console.WriteLine(index);
                index2++;
            }
            while (index2 <= 5);
            
        }
        static void for_forloops() { 
        
        
            Console.WriteLine("The while loop for reference");

            int i = 0;

            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("This a for loop");

            for(i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            string[] lists = {"6 = numbers", "7 = Getting_User_input", "8 = Building_a_Calculator",
            "9 = Arrays", "10 = Methods", "11 = If_statemets", "12 = If_Statemets_2", "13 = TheReturnKeyword"
            ,"14 = Simple_Calculator with user input", "15 = Switch statemets", "16 = while loop", "17 = The for loop"};

            for(int i = 0;i < lists.Length; i++)
            {
                Console.WriteLine(lists[i]);
            }

           Console.WriteLine("Enter a the number of the task from 6 to 17");
            int option = Convert.ToInt32(Console.ReadLine());

            if(option == 6)
            {
                numbers();
            }else if (option == 7)
            {
                user_input();
            }
            else if (option == 8)
            {
                Calculator();
            }
            else if (option == 9)
            {
                for_arr();
            }
            else if (option == 10)
            {
                methods();
            }
            else if (option ==11)
            {
                if_statements();
            }
            else if (option == 12)
            {
                if_statemets_2();
            }
            else if (option == 13)
            {
                for_return();
            }
            else if (option == 14)
            {
                calculator_user_input();
            }
            else if (option == 15)
            {
                for_switch();
            }
            else if (option == 16)
            {
                for_while();
            }
            else if (option == 17)
            {
                for_forloops();
            }

            Console.ReadKey();
        }
    }
}
