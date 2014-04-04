using System;

namespace Next {
	public class Next {
		public static int[] ReadInts(string msg){
			int[] arr;
			arr = new int[3];
			Console.Write ("{0}", msg);
			Console.ReadLine ();


			return arr;
		}
	}

	class Test{
		static void Main(string[] args){
			int[] arr = Next.ReadInts ("input test Numbers");
			foreach (int i in arr)
				Console.WriteLine (i);
		}
	}
}