using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcpserver
{
    public class SocketMessage
    {

        public string clientName { get; set; }
        public DateTime connectTime { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public bool check { get; set; }
        public bool needCheck { get; set; }
        public string parameter { get; set; }


        public SocketMessage(DateTime connectTime, string clientName, string status, string message, string parameter, bool needCheck = true)
        {
            this.connectTime = connectTime;
            this.clientName = clientName;
            this.status = status;
            this.message = message;
            this.check = false;
            this.needCheck = needCheck;
            this.parameter = parameter;

        }

        public string Key()
        {
            return clientName + "_" + connectTime.ToString("yyyy/MM/dd HH:mm:ss.fff");
        }

        public override string ToString()
        {
            return clientName + "\t" + connectTime.ToString("yyyy/MM/dd HH:mm:ss") + "\t" + status + "\t" + message + "\t" + check.ToString() + "\t" + needCheck.ToString();
        }

    }

}
