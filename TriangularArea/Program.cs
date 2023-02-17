using System;

namespace TriangularArea
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangular triangular = new Triangular();

			triangular.SideA = 4;
			triangular.SideB = 5;
			triangular.SideC = 3;
            
			Console.WriteLine(GetPerimeter(triangular));
			Console.WriteLine(IsRightTriangle(triangular));
            Console.WriteLine(GetTriangleArea(triangular));
		}

		private static double GetPerimeter(Triangular triangular)
		{
			return triangular.SideA + triangular.SideB + triangular.SideC;
		}

		private static bool IsRightTriangle(Triangular triangular)
		{
			if(triangular.SideA > triangular.SideB && triangular.SideA > triangular.SideC)
			{
				if (Math.Pow(triangular.SideA, 2) == Math.Pow(triangular.SideB, 2) + Math.Pow(triangular.SideC, 2))
				{
					return true;
				}
			}

			if (triangular.SideB > triangular.SideA && triangular.SideB > triangular.SideC)
			{
				if (Math.Pow(triangular.SideB, 2) == Math.Pow(triangular.SideA, 2) + Math.Pow(triangular.SideC, 2))
				{
					return true;
				}
			}

			if (triangular.SideC > triangular.SideA && triangular.SideC > triangular.SideB)
			{
				if (Math.Pow(triangular.SideC, 2) == Math.Pow(triangular.SideB, 2) + Math.Pow(triangular.SideA, 2))
				{
					return true;
				}
			}

			return false;
		}

		private static double GetTriangleArea(Triangular triangular)
        {
            if (IsRightTriangle(triangular))
            {
				if (triangular.SideA > triangular.SideB && triangular.SideA > triangular.SideC)
				{
					return triangular.SideB*triangular.SideC/2;
				}

				if (triangular.SideB > triangular.SideA && triangular.SideB > triangular.SideC)
				{
					return triangular.SideA * triangular.SideC / 2;
				}

				if (triangular.SideC > triangular.SideB && triangular.SideC > triangular.SideA)
				{
					return triangular.SideB * triangular.SideA / 2;
				}
			}

			return 0;
        }
	}
}
