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

            int answer = Add(5, 7);
            Console.WriteLine(answer);




        }

        //Method Header
        //Access Modifier - Return Type - Method Name(in Pascal Case) - Parentheses (sometimes with paramers)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //A complete method - header and body is called a method declaration.
            int sum = firstNumber + secondNumber;

            return sum;
        }
        //If you have a method that does not have a return value, you  would ust the keyword "void"
        //with void you dont use the key word return
    }
}
