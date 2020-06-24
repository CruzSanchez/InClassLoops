using System;
using System.Collections.Generic;

namespace IterationStatementsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Hello User!");
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("Hello User!");
            //    i++;
            //} while (i < 10);

            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    numbers[j] += 1;
            //    Console.WriteLine($"{numbers[j]}");
            //}


            ////Array Example - static size
            //int[] numbers = new int[10];

            ////List Example - dynamic size
            //List<int> numberList = new List<int>();

            //numberList.Add(1);
            //numberList.Add(2);
            //numberList.Add(3);
            //numberList.Add(4);
            //numberList.Add(5);

            //foreach (int number in numberList)
            //{
            //    Console.WriteLine(number);
            //}

            //NumberPrinter();

            ThreePrinter();
            Console.ReadLine();

            //Ask user for a number 
            Console.WriteLine("Please give me a number!!!");

            //Store the user number into a variable
            int userInput = int.Parse(Console.ReadLine());

            //Calling the method and store the value that the method returns into a variable
            int[] array = ArrayCreator(userInput);

            //Loop through the array
            foreach(int number in array)
            {
                //Print each to console
                Console.WriteLine(number);
            }
        }

        private static void ThreePrinter()
        {
            int i = 3;

            while(i <= 999)
            {
                Console.WriteLine(i);

                i += 3;
            }
        }

        public static void NumberPrinter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Declare a method
        public static int[] ArrayCreator(int userNumber)
        {
            //Create an array
            int[] customArray = new int[userNumber];

            //Create a random object
            Random rng = new Random();

            //Loop through our array
            for(int index = 0; index < customArray.Length; index++)
            {
                //Assign each index a random int value
                customArray[index] = rng.Next();
            }

            //Return the array
            return customArray;
        }
    }
}
