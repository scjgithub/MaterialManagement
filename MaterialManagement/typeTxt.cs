using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    class typeTxt
    {
        public static string local(string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Execl files (*.csv)|*.csv";
            saveFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "output";

            saveFileDialog.FileName = fileName  + System.DateTime.Now.ToLongDateString().ToString() + "导出" + ".csv";

            saveFileDialog.FilterIndex = 0;

            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.CreatePrompt = true;

            saveFileDialog.Title = "Excel报表保存到：";
            String saveFileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog.FileName;
            }
            else {
                return null;
            }

            return saveFileName;
        }
    }
}
