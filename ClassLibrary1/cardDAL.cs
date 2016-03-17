using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    class cardDAL
    {
        public cardDAL()
        { }
        public card GetModel(string name, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" customerID,customerName,pID,telephone,address ");
            strSql.Append(" from Admin ");
            strSql.Append(" where LoginID='" + name + "' and LoginPWD='" + pwd + "'");
            user model = new user();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
    }
}
