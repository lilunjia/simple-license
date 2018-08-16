using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_LisenceFileTest
{
    public partial class FormReg : Form
    {
        LicenseChecker lc = new LicenseChecker();


        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {   
            
            txtMachineCode.Text = lc.GetMachineCode();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(txtMachineCode.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = false;
            ofd.Filter = "授权文件(*.dat)|*.dat|所有文件(*.*)|*.*"; ;
            ofd.FilterIndex = 1;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                string filePath = ofd.FileName;
                string message = string.Empty;
                
                var isChecked = lc.Check(filePath, out message);

                if (!isChecked)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    System.IO.File.Copy(filePath, System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reg.dat"), true);

                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
