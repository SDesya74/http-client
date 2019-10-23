using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient {
	class Program {
		static void Main(string[] args) {
			WebClient Connector = new WebClient();

			while(true) {
				
				Console.WriteLine(" Enter request type (GET/POST)");
				Console.Write(" > ");

				string line = Console.ReadLine();
				switch(line.ToUpper()) {
					case "GET":
						Console.WriteLine(" Enter address");
						Console.Write(" > ");

						string address = Console.ReadLine();
						if(!address.StartsWith("http://")) address = "http://" + address;

						byte[] raw = Connector.DownloadData(address);
						string result = BytesToString(raw);

						Console.WriteLine();
						Console.WriteLine(result);
						Console.WriteLine();
						break;

					case "POST":
						break;
				}
			}
		}


		public static String BytesToString(byte[] bytes) {
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
