using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

/*
Original Code // fix mistype
 https://marunaka-blog.com/cshap-tcplistener-create/2293/
*/

namespace tcpserver
{

    class TcpSocketServer
    {
        public DateTime LastReceiveTime;
        public ConcurrentQueue<string> messageQueue;
        
        public TcpSocketServer()
        {
            LastReceiveTime = DateTime.Now;
            messageQueue = new ConcurrentQueue<string>();
            
        }

        public async Task<bool> StartListening(int port)
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
            var tcpServer = new TcpListener(localEndPoint);

            try
            {
                tcpServer.Start();

                while (true)
                {
                    using (var tcpClient = await tcpServer.AcceptTcpClientAsync())
                    {
                        var request = await ReceiveAsync(tcpClient);
                        
                        if (messageQueue.Count >= 1024) { string b = ""; messageQueue.TryDequeue(out b); }
                        messageQueue.Enqueue(request);
                        LastReceiveTime = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return false;
        }


        public async Task<string> ReceiveAsync(TcpClient tcpClient)
        {
            byte[] buffer = new byte[1024];
            string request = "";
            
            try
            {
                using (NetworkStream stream = tcpClient.GetStream())
                {
                    
                    do
                    {
                        int byteSize = await stream.ReadAsync(buffer, 0, buffer.Length);
                        request += Encoding.UTF8.GetString(buffer, 0, byteSize);
                    }
                    while (stream.DataAvailable);

                    Debug.WriteLine($"Received: {request}");


                    //Responce code for client
                    var response = "received : " + request;
                    buffer = Encoding.ASCII.GetBytes(response);
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                    Debug.WriteLine($"Response : {response}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return request;
        }

    }
}
