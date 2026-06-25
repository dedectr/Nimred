using Core.Interface;
using Core.Maperede;

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
					Maperede.MaperedeIp();
					break;
				default:
					return;
			}
		}
	}
}
