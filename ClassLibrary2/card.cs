using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class card
    {
        private string cardID;
        private string curType;
        private string savingType;
        private DateTime openDate;
        private float openMoney;
        private float balance;
        private string pass;
        private int IsReportLoss;
        private int customerID;
        public string CardID
        {
            set { cardID = value; }
            get { return cardID; }
        }
        public string CurType
        {
            set { curType = value; }
            get { return curType; }
        }
        public string SavingType
        {
            set { savingType = value; }
            get { return savingType; }
        }
        public DateTime OpenDate
        {
            set { openDate = value; }
            get { return openDate; }
        }
        public float OpenMoney
        {
            set { openMoney = value; }
            get { return openMoney; }
        }
        public float Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public string Pass
        {
            set { pass = value; }
            get { return pass; }
        }
        public int isReportLoss
        {
            set { IsReportLoss = value; }
            get { return IsReportLoss; }
        }
        public int CustomerID
        {
            set { customerID = value; }
            get { return customerID; }
        }
    }
}
