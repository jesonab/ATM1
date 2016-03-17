using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class user
    {
        private string customerID;
        private string customerName;
        private string pID;
        private string telephone;
        private string address;
        public string CustomerID
        {
            set { customerID = value; }
            get { return customerID; }

        }
        public string CustomerName
        {
            set { customerName = value; }
            get { return customerName; }

        }
        public string PID
        {
            set { pID = value; }
            get { return pID; }

        }
        public string Telephone
        {
            set { telephone = value; }
            get { return telephone; }

        }
        public string Address
        {
            set { address = value; }
            get { return address; }

        }

    }
}
