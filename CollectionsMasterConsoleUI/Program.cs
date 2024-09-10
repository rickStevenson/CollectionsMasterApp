using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            ////Create Array and print first and last numbers
            //Console.WriteLine("First and Last Numbers");
            //int[] numbers = new int[50];

            //Populater(numbers);

            //Console.WriteLine($"The first number in numbers = {numbers[0]}");
            //Console.WriteLine($"The last number in numbers = {numbers[numbers.Length - 1]}");           

            //Console.WriteLine("All Numbers Original");

            //NumberPrinter(numbers);

            //Console.WriteLine("-------------------");
            ////Reverse Array
            //Array.Reverse(numbers);

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("All Numbers Reversed:");

            //Console.WriteLine("---------REVERSE CUSTOM------------");

            //Console.WriteLine("-------------------");

            //Console.WriteLine("Multiple of three = 0: ");

            //ThreeKiller(numbers);

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}
            

            //Console.WriteLine("-------------------");

            
            //Console.WriteLine("Sorted numbers:");

            //Array.Sort(numbers);

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            //Console.WriteLine("************Start Lists**************");

            //List<int> intList = new List<int>();

            //Console.WriteLine($"List Capacity = {intList.Capacity}");

            //Populater(intList);

            //foreach (int n in intList)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("---------------------");

            ////Done: Create a method that prints if a user numbers is present in the list
            ////Remember: What if the user types "abc" accident your app should handle that!
            ////Console.WriteLine("What numbers will you search for in the numbers list?");

            //int userNumber;

            //Console.WriteLine("Please enter a number:");

            //while (!int.TryParse(Console.ReadLine(), out userNumber))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            //Console.WriteLine($"You entered the valid number: {userNumber}");

            //NumberChecker(intList, userNumber);


            //Console.WriteLine("-------------------");

            //Console.WriteLine("All Numbers:");
            ////UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter(intList);
            
            //Console.WriteLine("-------------------");


            ////Done: Create a method that will remove all odd numbers from the list then print results
            //Console.WriteLine("Evens Only!!");
            //OddKiller(intList);
            //Console.WriteLine("------------------");

            ////Done: Sort the list then print results
            //Console.WriteLine("Sorted Evens!!");
            //intList.Sort();
            //foreach (int n in intList)
            //{
            //    Console.WriteLine(n);
            //}
            
            //Console.WriteLine("------------------");

            ////TODO: Convert the list to an array and store that into a variable
            //int[] storedArrayOfList = new int[intList.Count];
            //for(int i = 0; i < storedArrayOfList.Length; i++)
            //{
            //    storedArrayOfList[i] = intList[i];
            //}
            //foreach (int n in storedArrayOfList)
            //{
            //    Console.WriteLine(n);
            //}

            ////Done: Clear the list
            //intList.Clear();

            //if (intList.Count == 0)
            //{
            //    Console.WriteLine("Empty List");
            //}
            //else
            //{
            //    Console.WriteLine("List not empty");

            //    foreach (int n in intList)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length;i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        private static void OddKiller(List<int> numberList)
        {
            // Iterate from the end of the list to the beginning
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }

            // Print the remaining numbers
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (int n in numberList)
            {
                if (n == searchNumber)
                {
                    Console.WriteLine("Your user number is in the list.");
                }
                else
                {
                    Console.WriteLine("That number is not in the list.");
                    break;
                }
            }

        }
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }
        private static void Populater(int[] numbers)
        {
           Random rng = new Random();
           for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }

        

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
