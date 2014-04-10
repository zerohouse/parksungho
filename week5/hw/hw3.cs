using System;
class MainClass
{
	public static void Main (string[] args)
	{
		string x, y;
		int a, b;
		Console.Write ("m : ");
		x = Console.ReadLine ();
		a = Convert.ToInt32 (x);

		string[,] star;

		star = new string[a,a];

		for (int i =0; i < a; i++) {
			for (int j =0; j < a; j++) {
				Console.Write ("*");
				star[i,j]="*";
			}
			Console.WriteLine();
		}

		string[] g;
		g = new string[1];
		int c;
		do

		{
			Console.Write(" su:");
			x = Console.ReadLine();


			g = x.Split(' ');

			c=Convert.ToInt32(g[0]);
			b=Convert.ToInt32(g[1]);

			if (star[c,b] == "*"){
				star[c,b] = " ";
				star[b,c] = " ";

				for (int i=0;i<a;i++){
					for(int j=0;j<a;j++){
						Console.Write("{0}",star[i,j]);}
					Console.WriteLine();
				}

			}

			else{
				Console.WriteLine("지운거임");
			}
		}

		while( c >=0 || b>=0);








	}
}