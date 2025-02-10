namespace ClassIntro
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player("Grzegorz Brzenczyszczykiewicz", 100, 10);
			Console.WriteLine(player.GetDamage());
			Console.ReadKey();
		}
	}
}