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
			Connector.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";


			while(true) {
				
				Console.WriteLine(" Enter request type (GET/POST)");
				Console.Write(" > ");

				string address;
				byte[] raw;
				string result;

				string line = Console.ReadLine();
				switch(line.ToUpper()) {
					case "GET":
						Console.WriteLine(" Enter address");
						Console.Write(" > ");

						address = Console.ReadLine();
						if(!address.Contains("://")) address = "http://" + address;

						raw = Connector.DownloadData(address);
						result = BytesToString(raw);

						Console.WriteLine();
						Console.WriteLine(result);
						Console.WriteLine();
						break;

					case "POST":
						Console.WriteLine(" Enter address");
						Console.Write(" > ");

						address = Console.ReadLine();
						if(!address.Contains("://")) address = "http://" + address;


						Console.WriteLine(" Enter POST data");
						Console.Write(" > ");

						String data = Console.ReadLine();

						raw = Connector.UploadData(address, Encoding.UTF8.GetBytes(data));
						result = BytesToString(raw);

						Console.WriteLine();
						Console.WriteLine(result);
						Console.WriteLine();
						break;
				}
			}
		}


		public static String BytesToString(byte[] bytes) {
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
