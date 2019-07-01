using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement
{
    class DataDBInfo
    {
        ///Construct
        public DataDBInfo()
        {
        }

        /// <summary>
        /// 执行查询操作
        /// </summary>
        /// <returns></returns>
        public static DataTable QueryDBInfo(string queryString)
        {
            return PostgreDBUtility.PostgreDBUtility.ExecuteSQLDtQuery(queryString);
        }

        /// <summary>
        /// 查找barcode对应的库存数量
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public static string GetRemainNumByBarCode(string barCode)
        {
            string condition = "barcode = " + barCode;

            string queryString = "select * from material where barcode = '" + barCode + "'";
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set txt(s) 对textBox赋值
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][6].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0";
            }
        }

        /// <summary>
        /// 查找barcode物料信息
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public static DataTable GetMaterialInfoByBarCode(string barCode)
        {
            string condition = "barcode = " + barCode;

            string queryString = "select * from material where barcode = '" + barCode + "'";
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                return dt;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public static int ExecuteSQLQuery(string queryString)
        {
            return PostgreDBUtility.PostgreDBUtility.ExecuteSQLQuery(queryString);
        }
    }
}
