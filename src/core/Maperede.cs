using System.Net;
using System.Net.NetworkInformation;


namespace Core.Maperede
{
    public class Maperede
    {
        public static void MaperedeIp()
        {
            var ipBase = "192.168.100.0";
            IPAddress ip = IPAddress.Parse(ipBase);
            byte[] bytsIp = ip.GetAddressBytes();
            for (int j = 1; j <= 254; j++)
            {
                try {
                    bytsIp[3] = (byte)j;
                    IPAddress ipAtual = new IPAddress(bytsIp);
                    Pings(ipAtual);
                }
                catch (Exception ex){
                    Console.WriteLine($"erro {ex}");
                }
            }
        }
        public static void Pings(IPAddress ip)
		{
			var ping = new Ping();
			for (int j = 0; j < 1; j++)
			{
				var resposta = ping.Send(ip, 500);
				if (resposta.Status == IPStatus.Success)
				{
					Console.WriteLine($"IP: {ip} | Ping: {resposta.RoundtripTime} ms");
				}
				else
				{
					Console.WriteLine($"Erro {ip}");
				}
			}
			// Console.ReadKey();
		}
    }
}
