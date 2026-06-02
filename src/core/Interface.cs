using System;

namespace Core.Interface
{
	public class Interface
	{
		public static void Tela()
		{
			Console.Clear();
			Console.WriteLine("--------------");
			Console.WriteLine("1 - Mapear Ips da rede");
			Console.WriteLine("2 - Mapear Trafego Rede TCP/UDP");
			Console.WriteLine("3 - Escutar porta");
			Console.WriteLine("--------------");
		}
	}
}
