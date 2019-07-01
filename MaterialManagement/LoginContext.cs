using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDataInfo;

namespace MaterialManagement
{
    class LoginContext : ApplicationContext
    {
#region private fields
        private frmLogin fLogin;
        private frmMain fMain;
#endregion
        public LoginContext()
        {
            CreateLoginForm();
        }

        private void CreateLoginForm()
        {
            fLogin = new frmLogin();
            fLogin.Closed += new EventHandler(fLogin_Closed);
            this.MainForm = fLogin;
            fLogin.Show();
        }

        void fLogin_Closed( object sender, EventArgs e )
        {
            if (LoginData.Logged)
            {
                fMain = new frmMain();
                this.MainForm = fMain;
                fMain.Show();
            } 
            else
            {
                ExitThread();
            }
        }
    }
}
