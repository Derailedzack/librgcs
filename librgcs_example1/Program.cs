using librgcs_net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace librgcs_example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.StartServer(25565);
           
        }
    }
}
