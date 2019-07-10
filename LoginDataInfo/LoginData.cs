using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDataInfo
{
    public static class LoginData
    {
        //
        private static string userName = "";
        public static string UserName
        {
            get { return userName; }
        }

        private static string userPassword = "";
        public static string Password
        {
            get { return userPassword; }
        }

        private static Authority authority = Authority.Guest;
        public static Authority Authority
        {
            get { return authority; }
        }

        private static bool logged = false;
        public static bool Logged
        {
            get { return logged; }
        }

        public static void DoLogin(string name, string password)
        {
            string queryString = "Select * from usermanage where username = '" + name + "'";
            DataTable dt = QueryDBInfo(queryString);

            if (dt.Rows.Count == 1)
            {
                userName = name;
                userPassword = dt.Rows[0]["password"].ToString();
                authority = GetAuthority(dt.Rows[0]["authority"].ToString());
            }

            if (userPassword == password)
            {
                logged = true;
            }
        }

        private static LoginDataInfo.Authority GetAuthority(string authority)
        {
            switch (authority)
            {
                case "GUEST":
                    return Authority.Guest;
                case "SUPERADMIN":
                    return Authority.SuperAdmin;
                case "buyer":
                    return Authority.Buyer;
                case "WareHouse":
                    return Authority.WareHouse;
                default:
                    return Authority.Guest;
            }
        }

        public static DataTable QueryDBInfo(string queryString)
        {
            return PostgreDBUtility.PostgreDBUtility.ExecuteSQLDtQuery(queryString);
        }
    }
}
