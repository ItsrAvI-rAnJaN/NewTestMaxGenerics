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
                }
            } while (Choice != 0);
            Console.ReadKey();
        }
    }
}