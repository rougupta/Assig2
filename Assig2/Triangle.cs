using System;
using System.Collections.Generic;
using System.Text;

namespace Assig2
{

	public class Triangle
	{ 
	
	       private int sidea;
			private int sideb;
			private int sidec;

			public Triangle()
		{

			sidea = 1;
			sideb = 1;
			sidec = 1;
		}

		public Triangle(int sidea, int sideb, int sidec)
		{
			this.sidea = sidea;
			this.sideb = sideb;
			this.sidec = sidec; ;
		}

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

			//string result = string.Empty;
			//Console.Write("For Side A : ");
			//sidea = Convert.ToInt32(Console.ReadLine());

			//Console.Write("For Side B : ");
			//sideb = Convert.ToInt32(Console.ReadLine());

			//Console.Write("Foe Side C : ");
			//sidec = Convert.ToInt32(Console.ReadLine());


			//if (sidea+sideb > && sidea+sidec>sideb && sideb+ sidec > sidea)
			//{

			//	if (sidea==sideb && sidea == sidec)
			//	{
			//		result = "Its an equilateral triangle";
			//	}

			//	else
			//		if (sidea == sideb )
			//             {

			//		result = "Its an isosceles triangle";

			//	}
			//}

		}


	}
}