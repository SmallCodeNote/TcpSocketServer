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
        public List<AddressInfo> addressList;

        public ClientData(string Line, List<AddressInfo> addressList)
        {
            string[] cols = Line.Split('\t');

            try
            {
                ClientName = cols[0];
                Timeout = int.Parse(cols[1]);
                TimeoutMessage = cols[2];
                this.addressList = addressList;
            }
            catch
            {
                ClientName = "";
                Timeout = 0;
                TimeoutMessage = "";
                this.addressList = null;
            }
        }

    }

    public class AddressBook
    {
        Dictionary<string, AddressInfo> addressBook;

        public AddressBook(string[] Lines)
        {
            addressBook = new Dictionary<string, AddressInfo>();

            for (int i = 1; i <= Lines.Length; i++)
            {
                addressBook.Add(i.ToString(), new AddressInfo(Lines[i - 1]));

            }

        }

        public List<AddressInfo> getAddress(string keyIndexList)
        {
            string[] keyIndexSet = keyIndexList.Split(',');

            List<AddressInfo> result = new List<AddressInfo>();

            foreach (string key in keyIndexSet)
            {
                if (addressBook.ContainsKey(key)) result.Add(addressBook[key]);
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
            addressName = cols.Length > 1 ? cols[1] : "";

        }

        public override string ToString()
        {
            return address;
        }

    }


}
