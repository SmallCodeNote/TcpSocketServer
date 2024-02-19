using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

/*
Original Code :
 https://marunaka-blog.com/cshap-tcpclient-create/2314/
 code adapt .NetFramework4.8
*/

namespace tcpClient
{
    public class TcpSocketClient
    {
        public async Task<string> StartClient(string ipaddress, int port, string request)
        {
            var writeBuffer = new byte[1024];
            var readBuffer = new byte[1024];
            var response = "";

            try
            {
                using (var tcpclient = new TcpClient())
                {
                    tcpclient.SendTimeout = 1000;//ms
                    tcpclient.ReceiveTimeout = 1000;//ms

                    await tcpclient.ConnectAsync(ipaddress, port);
                    Debug.WriteLine("Server connected.");
                    using (var stream = tcpclient.GetStream())
                    {
                        writeBuffer = System.Text.Encoding.ASCII.GetBytes(request);
                        await stream.WriteAsync(writeBuffer, 0, writeBuffer.Length);
                        Debug.WriteLine($"Send [{request}] to server.");

                        var length = await stream.ReadAsync(readBuffer, 0, readBuffer.Length);
                        response = System.Text.Encoding.ASCII.GetString(readBuffer, 0, length);
                        Debug.WriteLine($"Recieved [{response}] from server.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return response;
        }

    }


}
