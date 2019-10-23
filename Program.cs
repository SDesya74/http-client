using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient {
	class Program {
		static WebClient Connector;
		static async void Main(string[] args) {
			Connector = new WebClient();

			while(true) {
				Console.WriteLine(" Enter request type (GET/POST)");
				Console.Write(" > ");

				string line = Console.ReadLine();
				switch(line.ToUpper()) {
					case "GET":

						break;

					case "POST":
						break;
				}
			}
		}


	}
}
