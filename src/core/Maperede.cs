using System;
using System.Net;
using System.Net.NetworkInformation;
using Core.Ipscan;

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
                    Ipscans.Pings(ipAtual);
				
                }
                catch (Exception){
                    Console.WriteLine("");
                }
            }
        }
    }
}
