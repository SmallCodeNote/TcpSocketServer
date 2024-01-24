using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcpserver
{
    public class ClientData
    {
        public string ClientName;
        public int Timeout;
        public string TimeoutMessage;
        public AddressNote TargetAddress;

        public ClientData(string Line, AddressNote AddressList)
        {
            string[] cols = Line.Split('\t');

            try
            {
                ClientName = cols[0];
                Timeout = int.Parse(cols[1]);
                TimeoutMessage = cols[2];
                TargetAddress = AddressList;
            }
            catch
            {

                ClientName = "";
                Timeout = 0;
                TimeoutMessage = "";
                TargetAddress = null;
            }
        }

    }

    public class AddressNote
    {
        Dictionary<string, AddressInfo> addressNote;

        public AddressNote(string[] Lines)
        {
            addressNote = new Dictionary<string, AddressInfo>();

            for (int i = 1; i <= Lines.Length; i++)
            {
                addressNote.Add(i.ToString(), new AddressInfo(Lines[i - 1]));

            }

        }

        public List<AddressInfo> getAddress(string indexList)
        {
            string[] indexSet = indexList.Split(',');

            List<AddressInfo> result = new List<AddressInfo>();

            foreach(var i in indexSet)
            {
                result.Add(addressNote[i]);
            }

            return result;

        }
        
    }


    public class AddressInfo
    {
        public string address;
        public string addressName;

        public AddressInfo(string Line)
        {
            string[] cols = Line.Split('\t');

            address = cols[0];
            addressName = cols.Length > 1 ?  cols[1] : "";

        }

    }


}
