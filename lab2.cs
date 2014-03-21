
using System;

namespace triangle
{
	class Ex1
	{
		static void Main(string[] args)
		{
			String name;
			Console.Write ("삼각형의 이름?:");
			name = Console.ReadLine ();

			String a;
			Console.Write ("밑변의 길이:");
			a = Console.ReadLine ();
			int x = Convert.ToInt32 (a);

			String b;
			Console.Write ("높이?:");
			b = Console.ReadLine ();
			int y = Convert.ToInt32(b);

			double z = (x * y) / 2;
			Console.WriteLine ("{0}의 넓이={1}",name, z);
		}
	}

}

