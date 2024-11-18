using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ALBRIGHT_ASSIGNMENT_3_1
{
    internal class Program
    {
        // 3.1.1 Method
        static void EvenNumbers(int a)
        {
            StringBuilder evenNums = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    evenNums.Append(i + ", ");
                }
            }
            Console.WriteLine(evenNums);
        }

        // 3.1.2 Method
        static void LeapYear(int b)
        {
            if (((b % 4 == 0) && (b % 100 != 0)) | ((b % 4 == 0) && (b % 100 == 0) && (b % 400 == 0)))
            {
                Console.WriteLine("\n" + b + " is a Leap Year");
            }
            else
            {
                Console.WriteLine("\n" + b + " is not a Leap YEar");
            }
        }

        // 3.1.5 Method
        static void FindandReplaceConsecutive1s(int[] arrayInput)
        {
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if ((arrayInput[i] == arrayInput[i + 1]) && arrayInput[i+1]==1)
                {
                    arrayInput[i] = 0;
                    arrayInput[++i] = 0;

                    break;
                }
            }
            
        }

        static void Main(string[] args)
        {
            /*MSSA CCAD 16 - NOV 18 2024
             *DAY 11 - CHRIS ALBRIGHT
             *ASSIGNMENT 3.1
             */

            // 3.1.1:
            //Write a method that returns a string of even numbers greater than 0 and less than 100.
            //(Use StringBuilder class)

            Console.WriteLine("3.1.1: Enter the upper bound for even number generator (i.e. 100)");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEven numbers from 0 to "+upperBound+" :");
            EvenNumbers(upperBound);

            Console.WriteLine("\n=============================================================================");
            //===============================================================================================

            // 3.1.2
            // If year is leap. Given a year as integer, write a method that checks if year is leap.
            Console.WriteLine("\n3.1.2: Welcome to Leap Year Calculator:");
            Console.WriteLine("\nEnter the desired year in question:");
            int myYear = Convert.ToInt32(Console.ReadLine());
            LeapYear(myYear);

            Console.WriteLine("\n=============================================================================");
            //================================================================================================

            // 3.1.3
            // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
            Console.WriteLine("\n3.1.3: Welcome to Character Counter:");
            Console.WriteLine("\nEnter your string of characters:");
            string stringInput = Console.ReadLine();
            Console.WriteLine("\nEnter your searched for character:");
            char selectChar = Convert.ToChar(Console.ReadLine());
            int spaceCount = 0;
            foreach(char c in stringInput)
            {
                if (c == selectChar)
                {
                    spaceCount++;
                }
            }
            Console.WriteLine("\nThe character '" + selectChar + "' occurs in the string " + spaceCount + " times.");

            Console.WriteLine("\n=============================================================================");
            //================================================================================================

            // 3.1.4
            // Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine
            // in which quadrant the coordinate point lies.
            Console.WriteLine("\n3.1.4: Welcome to Coord. Quadrant Finder:");
            Console.WriteLine("\nEnter your x coord.:");
            double xCoord = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter your y coord.:");
            double yCoord = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your entered point is ({xCoord},{yCoord}).");

            if (xCoord > 0 && yCoord > 0)
            {
                Console.WriteLine("\nYour coord. pair is in quadrant I.");
            }
            else if (xCoord < 0 && yCoord > 0)
            {
                Console.WriteLine("\nYour coord. pair is in quadrant II.");
            }
            else if (xCoord < 0 && yCoord < 0)
            {
                Console.WriteLine("\nYour coord. pair is in quadrant III.");
            }
            else if (xCoord > 0 && yCoord < 0)
            {
                Console.WriteLine("\nYour coord. pair is in quadrant IV.");
            }
            else if (xCoord == 0 && yCoord != 0)
            {
                Console.WriteLine("\nYour coord. pair is on the y axis.");
            }
            else if (xCoord != 0 && yCoord == 0)
            {
                Console.WriteLine("\nYour coord. pair is on the x axis.");
            }
            else
            {
                Console.WriteLine("\nYour coord. pair is at the origin.");
            }

            Console.WriteLine("\n=============================================================================");
            //================================================================================================

            // 3.1.5
            // Write a function which takes an array as input and finds the first occurrence of 2 consecutive
            // 1s and changes their value to 0.

            Console.WriteLine("\n3.1.5: Welcome to First 2x Consecutive 1's Replacer:");
            Console.WriteLine("\n3.1.5: Enter the number of elements you'd like in the array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter array element: " + (i+1));
                array[i] = int.Parse (Console.ReadLine());
            }

            Console.WriteLine("\nYour entered array is as follows:");
            foreach (var item in array)
            {
                Console.Write(item+", ");
            }

            FindandReplaceConsecutive1s(array);

            Console.WriteLine("\n\nYour edited array is as follows:");
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n\n END OF ASSIGNMENT 3.1");
            Console.WriteLine("\n=============================================================================");
            //================================================================================================
        }
    }
}