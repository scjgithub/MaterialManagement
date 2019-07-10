using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDataInfo
{
    public class CheckAuthority
    {

        public static bool Check(Authority logAuthority, Authority needAuthority)
        {
            if (logAuthority >= needAuthority)
            {
                return true;
            }
            return false;
        } 
    }
}
