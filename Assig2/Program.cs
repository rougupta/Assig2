
using System;

namespace Assig2
{
    public static class Trianglesolver
    {
        public static string Analyze(int sidea, int sideb, int sidec)
        {

            if (((sidea + sideb) < sidec) || ((sideb + sidec) < sidec) || ((sidec + sidea) < sideb))
            {
                Console.WriteLine("");
                Console.Write("This triangle can not be formed.");
                return "This can't form triangle.";

            }

            else
             if (((sidea - sideb) > sidec) || ((sideb - sidec) > sidec) || ((sidec - sidea) > sideb))
            {
                Console.WriteLine("");
                Console.Write("This triangle can not be formed.\n");
                return "This can't form Triangle.";
            }

            else
             if ((sidea == sideb && sideb == sidec) && (sidea != 0 || sideb != 0 || sidec != 0))
            {
                Console.WriteLine("");
                Console.Write("It's an equilateral triangle.\n");
                return "It's an equilateral triangle.";
            }

            else
           if ((sidea == sideb || sidea == sidec || sideb == sidec) && (sidea != 0 || sideb != 0 || sidec != 0))
            {
                Console.WriteLine("");
                Console.Write("It's an isosceles triangle.\n");
                return "It's an isosceles triangle.";
            }


            else
               if (sidea == 0 | sideb == 0 || sidec == 0)
            {
                Console.WriteLine("");
                Console.Write("This triangle can not be formed.\n");
                return "This can't form Triangle.";
            }

            else
            {
                Console.WriteLine("");
                Console.Write("It's a scalene triangle.\n");
                return "It's a scalene triangle.";
            }

        }


        public static void Main(string[] args)
        {


            bool val = false;
            while (val == false)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Enter Triangle Dimention");
                Console.WriteLine("2. Exit");
                Console.WriteLine("");
                string Options = Console.ReadLine();
                Console.WriteLine(" ");

                switch (Options)
                {
                    case "1":
                        int sidea, sideb, sidec;
                        Console.Write("For Side A : ");
                        sidea = Convert.ToInt32(Console.ReadLine());


                        Console.Write("For Side B : ");
                        sideb = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Foe Side C : ");
                        sidec = Convert.ToInt32(Console.ReadLine());

                        Trianglesolver.Analyze(sidea, sideb, sidec);


                        break;
                    case "2":

                        Console.WriteLine("Exit");
                        val = true;

                        break;
                    default:
                        Console.WriteLine("That's not a valid input, Enter Valid Option");
                        break;
                }

            }

        }

    }
}




