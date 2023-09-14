class Program
{

	public static void Zadan64() //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
	{
		Console.WriteLine("");
		int N=Convert.ToInt32(Console.ReadLine());
		
		
				Console.WriteLine(NaturalNums(N,1));
		
		
	}
	public static void Zadan66() //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
	{
		Console.WriteLine("");
		int N = Convert.ToInt32(Console.ReadLine());
		int M =Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(NaturalSum(N, M));

	}
	public static void Zadan68() //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
	{
		int m = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
	}
	public static int NaturalNums (int nums, int m)
	{
		if (nums == m) return nums;
		else Console.Write($"{NaturalNums(nums, m + 1)}, ");
		return m;
	}
	public static int NaturalSum (int n, int m)
	{
		if (n == m) return n;
		else return NaturalSum(n + 1, m) + n;
	}
	public static int Akkerman(int m, int n)
	{
		if (m == 0) return n + 1;
		if (m > 0 && n == 0) return Akkerman(m - 1, 1);
		else return Akkerman(m - 1, Akkerman(m, n - 1));
	}




	public static void Main()
	{
		Console.WriteLine("");
		int numzad = Convert.ToInt32(Console.ReadLine());
		switch(numzad)
		{
			case 64:
				{
					Zadan64();
				}
				break;
			case 66:
				{
					Zadan66();
				}
				break;
			case 68:
				{
					Zadan68();
				}
				break;

		}
	}
}
