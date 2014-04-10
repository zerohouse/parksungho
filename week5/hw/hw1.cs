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
			Console.Write ("n : ");
			y = Console.ReadLine ();
			b = Convert.ToInt32 (y);

			for (int i = 1; i < a + 1; i++) {
				for (int j = 1; j < b + 1; j++) {
					Console.Write ("{0}  ", i * j);
				}
				Console.WriteLine();
			}



		}
	}
}
