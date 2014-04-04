using System;
public class ex3 {
	public static void DoublePrint(int x){
		x = 2 * x;
		Console.WriteLine (x);
	}

	static void Main(string[] args){
		int x = 10;
		int y = 20;
		DoublePrint (x);
		DoublePrint (y);
		DoublePrint (30);
		Console.WriteLine ("Main x: {0}", x);
	}
}

