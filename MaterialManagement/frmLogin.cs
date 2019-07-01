using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    public partial class frmLogin : Form
    {
#region Fields
        private bool validForm;
#endregion
        public frmLogin()
        {
            InitializeComponent();
            tbName.Validating += new CancelEventHandler(ValidateTextBox);
            tbPassword.Validating += new CancelEventHandler(ValidateTextBox);
        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            bool NameValid = true, PasswordValid = true;

            if (String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                switch (Convert.ToByte(((TextBox)sender).Tag))
                {
                    case 0:
                        errorProvider1.SetError(tbName, "Please, enter your name");
                        NameValid = false;
                        break;
                    case 1:
                        errorProvider1.SetError(tbPassword, "Please, enter your password");
                        PasswordValid = false;
                        break;
                }
            }
            else
            {
                switch (Convert.ToByte(((TextBox)sender).Tag))
                {
                    case 0:
                        errorProvider1.SetError(tbName, "");
                        break;
                    case 1: errorProvider1.SetError(tbPassword, "");
                        break;
                }
            }
            validForm = NameValid && PasswordValid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validForm)
            {
                //Check the userName and the password
                LoginDataInfo.LoginData.DoLogin(tbName.Text, tbPassword.Text);

                if (LoginDataInfo.LoginData.Logged) //check the logged flag
                {
                    try
                    {
                        StreamWriter fileWriter = new StreamWriter("user.txt", false, Encoding.Default);
                        fileWriter.WriteLine(tbName.Text);
                        fileWriter.Flush();
                        fileWriter.Close();
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


                    this.Close();
                }
                else
                {
                    MessageBox.Show("The password or the name are wrong. \n Please, try again. \n ", "Login failed", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Please, fill all text boxes");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream("user.txt", FileMode.Open, FileAccess.Read, FileShare.None), System.Text.Encoding.GetEncoding(936));
                string userName = sr.ReadLine();

                tbName.Text = userName;

                sr.Close();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
