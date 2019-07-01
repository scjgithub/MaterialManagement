using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreDBUtility
{
    public partial class PostgreDBUtility
    {
        #region 属性

        //状态定义：1运行 2故障 3或 4是待机 5停机


        //数据库连接字符串(web.config来配置)， =PubConstant.ConnectionString
        //原密文："Server=127.0.0.1;Port=5432;User Id=postgres;"+ "Password=fanuc; Database=postgres;" + "CommandTimeout=0;ConnectionLifeTime=0;"
        //加密后："BAC16CAEB0AAFACFCDCE7BBB482022AE1DE9A348B8C4A03BC9DB56AC3ED87F16A04DE2E338B6AC17A7FC634B914A084E0D3D2EF0F33B39E58C6D44412DC116BED850832387F538C254E48173CDFE9BAEA2A8C13B9763DD3BFA1D103BA97ADDC13A722F4220BE5CC007970E73E739D0098CF7F96C9EFBF4D8"
        public static string connEncryptString { set; get; }
        //private static string connectionString = "Server=192.168.1.200;Port=5432;User Id=postgres;Password=hardman; Database=material;CommandTimeout=0;ConnectionLifeTime=0;";
        private static string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=hardman; Database=material;CommandTimeout=0;ConnectionLifeTime=0;";


        #endregion
        public PostgreDBUtility()
        {
            
        }
        public static void DecryptString()
        {
            connectionString = DotNet.Utilities.MySecurity.SDecryptString(connEncryptString);
            connectionString = "Server=\\HDM-PC;Port=5432;User Id=postgres;Password=hardman; Database=postgresold;CommandTimeout=0;ConnectionLifeTime=0;";
        }
        #region 表公共方法
        /// <summary>
        /// 此功能用于ync三菱PLC报警实时信息的查看操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable SelMitsubishiRealTimeAlarmQuery(string machineid,string startime,string endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "SELECT * FROM public.mitalarm WhERE strip='" + machineid + "' AND strtime>'" + startime + "' AND strtime<'" + endtime + "'";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.Text, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync三菱PLC报警配置的查看操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable SelMitsubishiAlarmQuery()
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "SELECT * FROM public.ync_mitsubishi_alarmconfig";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.Text, queryString, null);
            return ds.Tables[0];
        }
        
        /// <summary>
        /// 此功能用于ync设备配置的查看操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable Exe(string queryString)
        {
            IDBHelper dbHelper = new PostgreHelper();
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.Text, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync三菱PLC报警配置的插入操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static int InsertMitsubishiAlarmQuery(string alarmtypeno, string alarmmsg)
        {
            IDBHelper dbHelper = new PostgreHelper();           
            string queryString = "insert into public.ync_mitsubishi_alarmconfig values('" + alarmtypeno + "','" + alarmmsg + "')";
            int r = dbHelper.ExecuteNonQuery(connectionString, CommandType.Text, queryString, null);
            return r;
        }
        /// <summary>
        /// 此功能用于ync设备配置的插入操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static int InsertFactoryOrgInfoQuery(string machineid, string machineuse, string machinename, string machineonelevel, string machinetwolevel, string machinethreelevel, string machineip, string machineindex)
        {
            string queryString = "insert into public.machinedata values('" + machineid + "','" + machineuse + "','" + machinename + "','" + machineonelevel + "','" + machinetwolevel + "','" + machinethreelevel + "','" + machineip + "','" + machineindex + "')";           
            return ExecuteSQLQuery(queryString);
        }
        /// <summary>
        /// 此功能用于ync三菱PLC报警配置的删除操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static int DeleteMitsubishiAlarmQuery()
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "delete FROM public.ync_mitsubishi_alarmconfig";
            int r = dbHelper.ExecuteNonQuery(connectionString, CommandType.Text, queryString, null);           
            return r;
        }
        /// <summary>
        /// 此功能用于ync设备配置的删除操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static int DeleteFactoryOrgInfoQuery()
        {
            string queryString = "delete FROM public.machinedata"; 
            return ExecuteSQLQuery(queryString);
        }
        /// <summary>
        /// 此功能用于ync废品量的查看操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable SelMachineScrapQuery(string Onelevel, string Twolevel, string Threelevel, string machineid, string startime, string endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "SELECT * FROM public.ync_scrap_quantity WHERE machineid='" + machineid + "' AND inputdate>='" + startime + "' AND inputdate<='" + endtime + "' ORDER BY inputdate";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.Text, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync废品量的插入操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static int InsertScrapQuantityQuery(string Onelevel, string Twolevel, string Threelevel, string machineid ,int scrap_quantity, string Inputtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "insert into public.ync_scrap_quantity values('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + scrap_quantity + "','" + Inputtime + "')";
            int r = dbHelper.ExecuteNonQuery(connectionString, CommandType.Text, queryString, null);
            return r;
        }
        #endregion
        #region 函数公用方法

        /// <summary>
        /// 此功能用于ync三菱PLC报警实时信息的查看操作
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetMitsubishiAlarmQuery(string Onelevel, string Twolevel, string Threelevel, string machineid,string altypeno, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            //string queryString = "SELECT * FROM public.mitalarm WhERE strip='" + machineid + "' AND strtime>'" + startime + "' AND strtime<'" + endtime + "'";
            string queryString = string.Format("public.ync_mitalarms('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Onelevel, Twolevel, Threelevel, machineid, altypeno, Startime, Endtime);
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }

        public static DataSet GetSingleMachineInfoQuery(string MachineID)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.pgsinglemachineinfo('" + MachineID + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds;
        }

        
        //public static DataSet GetPlantStatesQuery(string Onelevel,string Twolevel)
        //{
        //    IDBHelper dbHelper = new PostgreHelper();
        //    string queryString = "public.pgplantstates('" + Onelevel + "','" + Twolevel + "')";
        //    DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
        //    return ds;
        //}
        public static DataTable GetPlantStatesQuery(string Onelevel, string Twolevel)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncpgplantstates('" + Onelevel + "','" + Twolevel + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);            
            return ds.Tables[0];
        }
        public static DataTable GetPlantStatesRemtimQuery(string Onelevel, string Twolevel,string DbColumnName)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncpgplantstates('" + Onelevel + "','" + Twolevel + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            ds.Tables[0].Columns.Remove(DbColumnName);
            return ds.Tables[0];
        }
        public static DataTable GetPlantStatesRemtimQuery(string Onelevel, string Twolevel)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncpgmachinestates('" + Onelevel + "','" + Twolevel + "','C')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);           
            return ds.Tables[0];
        }
        public static DataTable GetPlantStatesAllQuery(string Onelevel, string Twolevel)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncpgmachinestatesall('" + Onelevel + "','" + Twolevel + "','C')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);          
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync工厂的信息，包含工厂，车间，生产线，机床id列表，机床name列表
        /// </summary>
        /// <returns>Tables（工厂，车间，生产线，机床id列表，机床name列表）</returns>
        public static DataTable GetFactoryOrgInfoQuery()
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncfactoryorginfo()";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync指定生产线的刀具信息，包含刀夹、T代码、当前值、予置值、目标值、剩余值、、刀具名称，刀补值：（刀长-磨损）
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetLineToolStatesQuery(string Onelevel, string Twolevel,string Threelevel)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncLineToolStates('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }
        
        /// <summary>
        /// 此功能用于ync获取指定时间段的机器产量信息。
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetMachineOutputQuery(string Onelevel, string Twolevel, string Threelevel,string Startime,string Endtime)
        {
            Stopwatch watch = Stopwatch.StartNew();
            watch.Start();
            
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncmachineouput('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + Startime + "','" + Endtime + "')";
            string s = "dbHelper 成功！耗时：" + "/n" + watch.ElapsedMilliseconds + "毫秒";
            Debug.WriteLine(s);
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            s = "ds 成功！耗时：" + "/n" + watch.ElapsedMilliseconds + "毫秒";
            Debug.WriteLine(s);
            return ds.Tables[0];
        }

        /// <summary>
        /// 此功能用于ync获取指定时间段的机器产量信息。可筛选功能。
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetMachineOutputQuery(string Onelevel, string Twolevel, string Threelevel, string Startime, string Endtime,string Workpieceid,string Machinename)
        {
            Stopwatch watch = Stopwatch.StartNew();
            watch.Start();

            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.yncmachineouputq('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + Workpieceid + "','" + Machinename + "','" + Startime + "','" + Endtime + "')";
            string s = "dbHelper 成功！耗时：" + "/n" + watch.ElapsedMilliseconds + "毫秒";
            Debug.WriteLine(s);
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            s = "ds 成功！耗时：" + "/n" + watch.ElapsedMilliseconds + "毫秒";
            Debug.WriteLine(s);
            return ds.Tables[0];
        }

        /// <summary>
        /// 此功能用于ync指定生产线/机床ID的报警列表
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetAlarmStatesQuery(string Onelevel, string Twolevel, string Threelevel, string machineid, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.ync_alarms_s('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + Startime + "','" + Endtime + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }

        /// <summary>
        /// 此功能用于ync指定生产线/机床ID的报警列表
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetAlarmStatesQuery(string Onelevel, string Twolevel, string Threelevel, string machineid,string alarmtype,string alarmno, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.ync_alarms_s('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + alarmtype + "','" + alarmno + "','" + Startime + "','" + Endtime + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }

        /// <summary>
        /// 此功能用于ync指定生产线/机床ID的报警列表机床统计表
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetAlarmStatesMachineQuery(string Onelevel, string Twolevel, string Threelevel, string machineid, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.ync_alarms_machine('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + Startime + "','" + Endtime + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync指定生产线/机床ID的报警列表机床统计表
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetAlarmStatesStatisticsQuery(string Onelevel, string Twolevel, string Threelevel, string machineid, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.ync_alarms_statistics('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + Startime + "','" + Endtime + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }
        /// <summary>
        /// 此功能用于ync指定车间/生产线/机床ID的oee
        /// </summary>
        /// <returns>Tables（）</returns>
        public static DataTable GetOeeDataQuery(string Onelevel, string Twolevel, string Threelevel, string machineid, string Startime, string Endtime)
        {
            IDBHelper dbHelper = new PostgreHelper();
            string queryString = "public.ync_ncs_oee('" + Onelevel + "','" + Twolevel + "','" + Threelevel + "','" + machineid + "','" + Startime + "','" + Endtime + "')";
            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
            return ds.Tables[0];
        }
        #endregion
        
        //        private void button1_Click(object sender, EventArgs e)
//        {
//            IDBHelper dbHelper = new PostgreHelper();
//            string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;"
//+ "Password=fanuc; Database=postgres;" + "CommandTimeout=0;ConnectionLifeTime=0;";

//            //string sql = "insert into [RawLog]([ProjectID],[File],[Note]) values('项目编号',@file,'备注')"; 
//            string queryString = "public.pgsinglemachineinfo('" + textBox1.Text + "')";

//            DataSet ds = dbHelper.ExecuteQuery(connectionString, CommandType.StoredProcedure, queryString, null);
//            DataTable data = new DataTable();
//            data = ds.Tables[0];
//            BindingSource dataSource = new BindingSource(data, null);
//            dataGridView1.DataSource = dataSource;

//        }
    }
}
