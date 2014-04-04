using System;
class array {
	static void Main(string[] args)
	{	
		Console.Write ("크기 : ");
		string a = Console.ReadLine();
		int b = Convert.ToInt32(a);

		int c, i , j;
		int[,] x = new int[b, b];
		int[,] y = new int[b, b];

		for (i=0;i<b;i++)
			for (j=0;j<b;j++) {
				Console.Write (" 1 [{0},{1}] :", i, j);
				a = Console.ReadLine();
				c = Convert.ToInt32(a);
				x[i,j] = c;
			}

		for (i=0;i<b;i++)
			for (j=0;j<b;j++) {
				Console.Write (" 2 [{0},{1}] :", i, j);
				a = Console.ReadLine();
				c = Convert.ToInt32(a);
				y[i,j] = c;
			}

		for (i=0;i<b;i++)
			for (j=0;j<b;j++) {
				x[i,j] += x[i,j];
			}



		for (i = 0; i < b; i++) {
			Console.Write ("| ");
			for (j = 0; j < b; j++) {
				Console.Write ("{0} ", x [i, j]);
			}
			Console.Write ("|");
			Console.WriteLine ("");
		}



		}
	}




