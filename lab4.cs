using System;

namespace collapse
{
	public class o
	{
		public string name;
		public int x;
		public int y;
		public int r;
	}

	class collapsetest{
		static void Main(string[] args)
		{
			o o1 = new o();
			Console.Write ("1번 원의 이름 : ");
			o1.name = Console.ReadLine ();

			Console.Write ("1번 원 중심의 x좌표 : ");
			string x1 = Console.ReadLine ();
			o1.x = Convert.ToInt32 (x1);

			Console.Write ("1번 원 중심의 y좌표 : ");
			string y1 = Console.ReadLine ();
			o1.y = Convert.ToInt32 (y1);

			Console.Write ("1번 원의 반지름 : ");
			string r1 = Console.ReadLine ();
			o1.r = Convert.ToInt32 (r1);

			// 1번원

			o o2 = new o();
			Console.Write ("2번 원의 이름 : ");
			o2.name = Console.ReadLine ();

			Console.Write ("2번 원 중심의 x좌표 : ");
			string x2 = Console.ReadLine ();
			o2.x = Convert.ToInt32 (x2);

			Console.Write ("2번 원 중심의 y좌표 : ");
			string y2 = Console.ReadLine ();
			o2.y = Convert.ToInt32 (y2);

			Console.Write ("2번 원의 반지름 : ");
			string r2 = Console.ReadLine ();
			o2.r = Convert.ToInt32 (r2);

			// 2번원

			Console.WriteLine("{0}의 중심 좌표는 ({1}, {2}) 반지름은 {3}입니다." , o1.name, o1.x, o1.y, o1.r);
			Console.WriteLine("{0}의 중심 좌표는 ({1}, {2}) 반지름은 {3}입니다." , o2.name, o2.x, o2.y, o2.r);

			if (o1.r + o2.r >=
			    Math.Sqrt (Math.Pow (Math.Abs (o1.x - o2.x), 2) + Math.Pow (Math.Abs (o1.y - o2.y), 2))) {
				Console.WriteLine ("{0}과(와) {1}은(는) 충돌합니다!",o1.name,o2.name);
			} else {
				Console.WriteLine ("{0}과(와) {1}은(는) 충돌하지 않습니다!",o1.name,o2.name);
			}
		}
	}
}

