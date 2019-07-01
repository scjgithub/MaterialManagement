using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreDBUtility
{
    public partial class PostgreDBUtility
    {
        #region 共有调用方法
        /// <summary>
        /// 此功能用于执行特定SQL语句，返回表
        /// </summary>
        /// <returns>Tables（）</returns>
        /// <param name="queryString"></param>
        public static DataTable ExecuteSQLDtQuery(string queryString)
        {
            IDBHelper dbHelper = new PostgreHelper();
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.Text, queryString, null);
            return ds.Tables[0];
        }
        public static int ExecuteSQLQuery(string queryString)
        {
            IDBHelper dbHelper = new PostgreHelper();
            int r = dbHelper.ExecuteNonQuery(connectionString, CommandType.Text, queryString, null);
            return r;
        }
        #endregion
    }
}
