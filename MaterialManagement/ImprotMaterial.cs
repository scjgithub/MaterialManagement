using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement
{
    class ImprotMaterial
    {
        public static void ImportToDB()
        {
            FileStream fs = new FileStream("888888.csv"/*fileExcelPath*/, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding(936));

            string str = "";
            string[] material;
            string queryString = "";
            while (str != null)
            {
                str = sr.ReadLine();
                if (str == null)
                {
                    break;
                }
                material = str.Split(',');

                if (material[0].Length == 0 || material[0] == "物料类别（一级）")
                {
                    continue;
                }

                Console.WriteLine(str);

                queryString = "insert into material values('";

                queryString += material[5] + "','" +
                               material[0] + "','" +
                               material[1] + "','" +
                               material[2] + "','" +
                               material[3] + "','" +
                               material[4] + "','" +
                               material[6] + "')";

                Console.WriteLine(queryString);

                try
                {
                    DataDBInfo.ExecuteSQLQuery(queryString);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(queryString);
                }
            }
        }
    }
}