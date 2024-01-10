using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

/*
Original Code : adapt .NetFramework4.8
 https://marunaka-blog.com/cshap-tcpclient-create/2314/
*/

namespace tcpClient
{
    class TcpSocketClient
    {
        public async Task<string> StartClient(string ipaddress, int port, string request)
        {
            var writeBuffer = new byte[1024];
            var readBuffer = new byte[1024];
            var response = "";

            // サーバーへ接続
            try
            {
                // クライアント作成
                using (var tcpclient = new TcpClient())
                {
                    // 送受信タイムアウト設定
                    tcpclient.SendTimeout = 1000;
                    tcpclient.ReceiveTimeout = 1000;

                    // サーバーへ接続開始
                    await tcpclient.ConnectAsync(ipaddress, port);
                    Debug.WriteLine("サーバーと通信確立");
                    using (var stream = tcpclient.GetStream())
                    {
                        // サーバーへリクエストを送信
                        writeBuffer = System.Text.Encoding.ASCII.GetBytes(request);
                        await stream.WriteAsync(writeBuffer, 0, writeBuffer.Length);
                        Debug.WriteLine($"サーバーへ[{request}]を送信");

                        // サーバーからレスポンスを受信
                        var length = await stream.ReadAsync(readBuffer, 0, readBuffer.Length);
                        response = System.Text.Encoding.ASCII.GetString(readBuffer, 0, length);
                        Debug.WriteLine($"サーバーから[{response}]を受信");
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
