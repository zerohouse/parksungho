using System;
class ex1 {
	static void Main(string[] args)
	{	
		Console.Write ("행 :");
		string a = Console.ReadLine();
		int c = Convert.ToInt32(a);

		Console.Write ("열 :");
		a = Console.ReadLine();
		int b = Convert.ToInt32(a);


		for (int i=0;i<c;i++){
			for (int j=0;j<b;j++)
				Console.Write("{0}{1} ",i,j);
			Console.WriteLine("");
		}



	}
}



