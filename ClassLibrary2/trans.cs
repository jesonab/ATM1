using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class trans
    {
        private DateTime transDate;
        private string cardID;
        private string transType;
        private float transMoney;
        private string remark;
        public DateTime TransDate
        {
            set { transDate = value; }
            get { return transDate; }
        }
        public string CardID
        {
            set { cardID = value; }
            get { return cardID; }
        }
        public string TransType
        {
            set { transType = value; }
            get { return transType; }
        }
        public float TransMoney
        {
            set { transMoney = value; }
            get { return transMoney; }
        }
        public string Remark
        {
            set { remark = value; }
            get { return remark; }
        }
    }
}
