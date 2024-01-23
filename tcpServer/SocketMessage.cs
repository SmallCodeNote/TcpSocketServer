using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcpserver
{
    public class SocketMessage
    {

        public string groupName { get; set; }
        public DateTime connectTime { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public bool check { get; set; }
        public bool needCheck { get; set; }


        public SocketMessage(DateTime connectTime, string groupName, string status, string message)
        {
            this.connectTime = connectTime;
            this.groupName = groupName;
            this.status = status;
            this.message = message;
            this.check = false;
            this.needCheck = true;
        }

        public string Key()
        {

            return groupName + "_" + connectTime.ToString("yyyy/MM/dd HH:mm:ss.fff");

        }

        public override string ToString()
        {
            return groupName + "\t" + connectTime.ToString("yyyy/MM/dd HH:mm:ss") + "\t" + status + "\t" + message + "\t" + check.ToString() + "\t" + needCheck.ToString();
        }

    }

}
