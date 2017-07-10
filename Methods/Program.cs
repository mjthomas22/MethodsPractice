using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way of us collecting a series of instructions and then call them when needed.
            //Methods are always part of a class.
            //Methods are always children of classes.
            //This means a method will never be inside another method or member of the class.

            //Console.WriteLine();
            //int answer = Add(5, 7);
            //Console.WriteLine(answer);

            //RobotWarning("Will Robinson");

            //string myBirthMonth = "September";

            //Creat a method called faoritefood
            //it should take two string para. one representing a name and the ther a favorite food
            //type should be void method should concatenate

            /* Create a method called retirementcalculater
             * it should take an int as para reppresenting users age
             * method should calculate how many more years the user retures using 65
             * return type should be coid 
             * print retirement age
             * "user will retire in x years where x represents the value that was calculated.*/
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("What is your favorite food ?");
            //string favFood = Console.ReadLine();
            //FavortieFood(userName, favFood);



            //Console.WriteLine("How old are you ?");
            //int userAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("The user will retire in "+RetirementCalculator(userAge)+" years.");





        }


        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = (hoursWorked * 52 * hourlyWage) / 12;

            return monthlyWage;
        }

        public static void FavortieFood(string name, string food)
        {
            Console.WriteLine("{0}'s favorite food is {1}", name, food); 
        }
        //Method Header
        //Access Modifier - Return Type - Method Name(in Pascal Case) - Parentheses (sometimes with paramers)
        public static int RetirementCalculator(int age)
        {
            int retireAge = 65 - age;

            return retireAge;
                
        }
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //A complete method - header and body is called a method declaration.
            int sum = firstNumber + secondNumber;

            return sum;
        }
        //If you have a method that does not have a return value, you  would ust the keyword "void"
        //with void you dont use the key word return

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static string Vehicle(string birthmonth)
        {
            string vehicleFortune;
            if (birthmonth.ToLower() == "september" || birthmonth.ToLower() == "october")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

    }
}
