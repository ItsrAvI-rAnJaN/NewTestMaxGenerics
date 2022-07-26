using System;
using TestMaxGenerics;

namespace TestMaxGenrics
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t###################################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO PROGRAM FIND MAXIMUM USING GENERICS");
            Console.WriteLine("\t\t\t\t###################################################################");

            //Creating Variable to Store Input From User
            int Choice; 
            do
            {
                Console.WriteLine("\n0.Exit");
                Console.WriteLine("1.Find Maximum Among Three Integer");
                Console.WriteLine("2.Find Maximum Among Three Float");
                Console.WriteLine("3.Find Maximum Among Three String Value");
                Console.Write("\nEnter Your Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine()); // store iput From User & Convert Into Integer type

                // Using Switch Case To Excute Program Input by User
                switch (Choice)
                {
                    case 1:

                        // Creating Instance of Class FindMaxInt
                        FindMaxNumber objFindMaxInt = new FindMaxNumber();

                        // printing Max Int No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(30, 20, 10));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(40, 60, 50));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(80, 70, 90));

                        break;

                    case 2:
                        // Creating Instance of Class FindMaxFloat
                        FindMaxFloat objFindMaxFloat = new FindMaxFloat();

                        // printing Max Float No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(3.1f, 2.1f, 1.1f));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(4.1f, 6.1f, 5.1f));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(8.1f, 7.1f, 9.1f));
                        break;

                    case 3:
                        // Creating Instance of Class FindMaxFloat
                        FindMaxString objFindMaxString = new FindMaxString();

                        // printing Max Float No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("David", "Bryan", "Dane"));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("Amber", "Charlie", "Bruno"));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("Dwayne", "Cherry", "Scarlet"));
                        break;

                    default:
                        Console.WriteLine("Please Enter Correct Question Number");
                        break;
                }
            } while (Choice != 0);
            Console.ReadKey();
        }
    }
}