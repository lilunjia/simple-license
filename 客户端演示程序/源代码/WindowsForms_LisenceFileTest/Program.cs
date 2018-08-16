using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_LisenceFileTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reg.dat");

            if (File.Exists(filePath) == false)
            {
                FormReg formReg = new FormReg();
                formReg.ShowDialog();
                if (File.Exists(filePath) == false)
                {
                    return;
                }
                else
                {   
                    //Application.Restart();
                }
            }
                        

            LicenseChecker lc = new LicenseChecker();
            string message = string.Empty;
            bool isCheck = lc.Check(filePath, out message);
            if (!isCheck)
            {   
                MessageBox.Show(message);
                return;
            }

            
            Application.Run(new Form1());
        }
    }
}
