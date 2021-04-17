using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace librgcs_net
{
    public class Server
    {
        private bool ServerLoop = true;
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public void StartServer(int port)
        {
         
            socket.Bind(new IPEndPoint(new IPAddress(0),port));
            while(ServerLoop == true)
            {
                //Console.SetCursorPosition(3, 0);
               
                
                Console.ReadLine();
               
            }
            
        }
        public void SendVersionInfo()
        {
            byte[] versiondata = { 0, 0, 0, 68,69,86 };
            socket.Send(versiondata);
        }
    }
}
