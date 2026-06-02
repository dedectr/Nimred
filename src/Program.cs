using Core.Interface;
using Core.Ipscan;

class Program
{
	static void Main()
	{
		while (true){
			var ia = "";
			Interface.Tela();
			ia = Console.ReadLine();
			switch (ia)
			{
				case "1":
					// var ips = Ipscan.Ipaddres();
					// Console.WriteLine($"{ips}");
					// ip = Console.ReadLine();
					Ipscan.Pings("8.8.8.8");
					Console.ReadKey();
					break;
				default:
					return;
			}
		}
	}
}
