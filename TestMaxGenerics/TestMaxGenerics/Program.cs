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
                Console.WriteLine("4.Find Maximum Among Three Value Using Generics Method");
                Console.WriteLine("5.Find Maximum among Three Value using Generic class");
                Console.WriteLine("6. Find Maximum from More Than Three Parameters Using Generic");
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
                        Console.WriteLine("######################################################\n");

                        break;

                    case 2:
                        // Creating Instance of Class FindMaxFloat
                        FindMaxFloat objFindMaxFloat = new FindMaxFloat();

                        // printing Max Float No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(3.1f, 2.1f, 1.1f));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(4.1f, 6.1f, 5.1f));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxFloat.FindMaxAmongFloat(8.1f, 7.1f, 9.1f));
                        Console.WriteLine("######################################################\n");
                        break;

                    case 3:
                        // Creating Instance of Class FindMaxFloat
                        FindMaxString objFindMaxString = new FindMaxString();

                        // printing Max Float No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("David", "Bryan", "Dane"));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("Amber", "Charlie", "Bruno"));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxString.FindMaxAmongString("Dwayne", "Cherry", "Scarlet"));
                        Console.WriteLine("######################################################\n");
                        break;

                    case 4:
                        GenricMethodMax objfindmax = new GenricMethodMax();
                        // for integer value
                        Console.WriteLine("Maximum Integer Number = {0}", objfindmax.FindMaxGeneric(30, 20, 10));

                        Console.WriteLine("Maximum Integer Number = {0}", objfindmax.FindMaxGeneric(40, 60, 50));

                        Console.WriteLine("Maximum Integer Number = {0}", objfindmax.FindMaxGeneric(70, 80, 90));
                        Console.WriteLine("###################################################\n");


                        // for Float Value
                        Console.WriteLine("Maximum Float Number = {0}", objfindmax.FindMaxGeneric(3.1f, 2.1f, 1.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objfindmax.FindMaxGeneric(4.1f, 6.1f, 5.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objfindmax.FindMaxGeneric(7.1f, 8.1f, 9.1f));
                        Console.WriteLine("###################################################\n");



                        // for String Value
                        Console.WriteLine("Maximum String Value = {0}", objfindmax.FindMaxGeneric("David", "Bryan", "Dane"));

                        Console.WriteLine("Maximum String Value = {0}", objfindmax.FindMaxGeneric("Amber", "Charlie", "Bruno"));

                        Console.WriteLine("Maximum String Value = {0}", objfindmax.FindMaxGeneric("Dwayne", "Cherry", "Scarlet"));
                        Console.WriteLine("######################################################\n");
                        break;
                    case 5:
                        //Test case for Integer
                        GenricClassMax<int> maxInt = new GenricClassMax<int>(10, 20, 30);
                        Console.WriteLine("Maximum integer Number =  " + maxInt.TestMaximum());
                        Console.WriteLine("###################################################\n");

                        //Test case for Float
                        GenricClassMax<float> maxFloat = new GenricClassMax<float>(1.1f, 2.1f, 3.1f);
                        Console.WriteLine("Maximum Float Number =  " + maxFloat.TestMaximum());
                        Console.WriteLine("###################################################\n");

                        //Test case for String
                        GenricClassMax<string> maxString = new GenricClassMax<string>("Apple", "Banana", "Peach");
                        Console.WriteLine("Maximum String Value = " + maxString.TestMaximum());
                        Console.WriteLine("######################################################\n");
                        break;

                    case 6:
                        //Test case for Integer
                        int[] intArray = { 100, 120, 150, 130, 240 };
                        GenericFindMax<int> objMaxInt = new GenericFindMax<int>(intArray);
                        Console.WriteLine("Maximum Integer Value = " + objMaxInt.FindMaxMethod());
                        Console.WriteLine("#####################################################\n");

                        //Test case for Float
                        float[] floatArray = { 11.1f, 52.2f, 45.5f, 23.3f, 14.4f };
                        GenericFindMax<float> objMaxFloat = new GenericFindMax<float>(floatArray);
                        Console.WriteLine("Maximum Float value = " + objMaxFloat.FindMaxMethod());
                        Console.WriteLine("######################################################\n");

                        //Test case for String
                        string[] stringArray = { "Daniel", "David", "Jhon", "Dwyane", "Charlie" };
                        GenericFindMax<string> objMaxString = new GenericFindMax<string>(stringArray);
                        Console.WriteLine("Maximum String Value = " + objMaxString.FindMaxMethod());
                        Console.WriteLine("######################################################\n");
                        break;


                    default:
                        Console.WriteLine("\nPlease Enter Correct Question Number");
                        break;
                }
            } while (Choice != 0);
            Console.ReadKey();
        }
    }
}