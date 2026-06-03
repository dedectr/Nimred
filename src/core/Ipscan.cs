using System.Net.NetworkInformation;
using System.Net;

namespace Core.Ipscan
{
	public class Ipscan
	{
		public static void Pings(string ip)
		{
			var ping = new Ping();
			for (int j = 0; j < 5; j++)
			{
				var resposta = ping.Send(ip, 1000);
				if (resposta.Status == IPStatus.Success)
				{
					Console.WriteLine($"IP: {ip} | Ping: {resposta.RoundtripTime} ms");
				}
				else
				{
					Console.WriteLine("Erro");
				}
			}
			Console.ReadKey();
		}
	}
}
