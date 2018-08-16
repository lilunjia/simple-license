using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LisenceFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {   
            cbxVersions.DataSource = VersionSettingsManager.Instance.List();
                        
            cbxAuthoTypes.DataSource = AuthorizeManager.Instance.LoadItems();

            txtSignDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");

        }

        /// <summary>
        /// 版本管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisionSettings_Click(object sender, EventArgs e)
        {
            FormVersionSettings fs = new FormVersionSettings();
            fs.ShowDialog(this);

            cbxVersions.DataSource = VersionSettingsManager.Instance.List();
        }

        
        private void cbxAuthoTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuthorizeItem ai = cbxAuthoTypes.SelectedItem as AuthorizeItem;
            if (ai == null)
                return;

            lblMemo.Text = ai.Memo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            AuthorizeFile af = new AuthorizeFile();
            af.Version = cbxVersions.Text;
            
            af.AuthorizeType = cbxAuthoTypes.Text;
            af.AuthorizeContent = txtContent.Text;

            if (string.IsNullOrWhiteSpace(af.Version))
            {   
                MessageBox.Show("版本类型不可为空");
                return;
            }

            if (string.IsNullOrWhiteSpace(af.AuthorizeContent))
            {
                MessageBox.Show("授权类型中的内容不可为空");
                return;
            }

            string localFilePath = String.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //设置文件类型  
            saveFileDialog1.Filter = "授权文件(*.dat)|*.dat|所有文件(*.*)|*.*";
            //设置文件名称：
            saveFileDialog1.FileName = "授权文件["+ af.Version +"+"+ af.AuthorizeType +"]"+ DateTime.Now.ToString("yyyyMMddHHmm") +".dat";

            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;

            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径  
                localFilePath = saveFileDialog1.FileName.ToString();

                string json = af.ToJson();

                string publicKeyXml = VersionSettingsManager.Instance.ReadPublicKey(af.Version);
                string privateKeyXml = VersionSettingsManager.Instance.ReadPrivateKey(af.Version);

                LisenceSign signer = new LisenceSign();
                var sign = signer.Sign(json, privateKeyXml);

                System.IO.File.WriteAllText(localFilePath, json + "+++++=====+++++" + sign + "+++++=====+++++" + publicKeyXml);
            }

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
                string content = System.IO.File.ReadAllText(filePath);
                string[] items = content.Split(new string[] { "+++++=====+++++" }, StringSplitOptions.RemoveEmptyEntries);

                if (items.Length != 3)
                {
                    MessageBox.Show("授权文件格式无法识别");
                    return;
                }

                string json = items[0];
                string sign = items[1];
                string publicKeyXml = items[2];

                LisenceSign signer = new LisenceSign();
                var isVerify = signer.Verify(json, sign, publicKeyXml);

                if (isVerify == false)
                {   
                    MessageBox.Show("授权文件格式校验未通过");
                    return;
                }

                AuthorizeFile af = AuthorizeFile.FromJson(json);

                cbxVersions.Text = af.Version;
                
                cbxAuthoTypes.Text = af.AuthorizeType;
                txtContent.Text = af.AuthorizeContent;
                txtSignDate.Text = af.SignDate.ToString("yyyy年MM月dd日");


            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lilunjia/simple-license");  
        }

        private void cbxVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var versionName = cbxVersions.Text;
            if (string.IsNullOrWhiteSpace(versionName))
                return;

            string publicKeyXml = VersionSettingsManager.Instance.ReadPublicKey(versionName);

            var hashcode6 = MD5Helper.GetMD5HashString(publicKeyXml).Substring(0,6);

            txtVersionNo.Text = hashcode6;
        }

       


    }
}
