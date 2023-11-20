using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.Database
{
    internal class Database
    {
        SqlConnection sqlConn;

        public Database()
        {
            /*string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QLthuvien;uid=sa;pwd=123";*/
            string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QLthuvien;uid=sa;pwd=123";
            sqlConn = new SqlConnection(strCnn);
        }

        public DataTable Execute(string sqlStr)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public object ExecuteScalar(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            object result = sqlcmd.ExecuteScalar();
            sqlConn.Close();
            return result;
        }

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
