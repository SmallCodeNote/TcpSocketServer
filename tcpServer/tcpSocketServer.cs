using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task<bool> StartListening(int port)
        {
            // 接続を待つエンドポイントを設定
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

            // TcpListenerを作成
            var tcpServer = new TcpListener(localEndPoint);

            try
            {
                // 待ち受け開始
                tcpServer.Start();

                while (true)
                {
                    Debug.WriteLine("接続待機中...");

                    // 非同期で接続要求を待機
                    using (var tcpClient = await tcpServer.AcceptTcpClientAsync())
                    {
                        Debug.WriteLine("クライアントからの接続要求を受け入れ");

                        // クライアントからデータを受信
                        var request = await ReceiveAsync(tcpClient);
                    }

                    Debug.WriteLine("接続終了");
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
                    // クライアントからリクエストを受信する
                    do
                    {
                        int byteSize = await stream.ReadAsync(buffer, 0, buffer.Length);
                        request += Encoding.UTF8.GetString(buffer, 0, byteSize);
                    }
                    while (stream.DataAvailable);
                    Debug.WriteLine($"クライアントから「{request}」を受信");

                    // クライアントへレスポンスを送信する
                    var response = "GetMessage : " + request;
                    buffer = Encoding.ASCII.GetBytes(response);

                    await stream.WriteAsync(buffer, 0, buffer.Length);
                    Debug.WriteLine($"クライアントへ「{response}」を送信");
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
