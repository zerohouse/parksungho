using System;

namespace hw
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string x, y;
			int a, b;
			Console.Write ("m : ");
			x = Console.ReadLine ();
			a = Convert.ToInt32 (x);

			for (int i = 0; i < a + 1; i++) {
				for (int j = 0; j < a; j++) {
					if (i > j)
						Console.Write ("#");
					else
						Console.Write ("*");


				}
				Console.WriteLine();
			}



		}
	}
}
