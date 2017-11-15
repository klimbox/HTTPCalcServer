using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpCalcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer("http://localhost:9999/");
            server.Start();
        }
    }
}
