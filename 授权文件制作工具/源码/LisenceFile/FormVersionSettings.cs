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
    public partial class FormVersionSettings : Form
    {
        public FormVersionSettings()
        {   
            InitializeComponent();

            this.Load += FormVersionSettings_Load;
        }

        void FormVersionSettings_Load(object sender, EventArgs e)
        {   

            listBox1.DataSource = VersionSettingsManager.Instance.List();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(item))
                return;

            var dialog = MessageBox.Show(this, "是否要删除","提示", MessageBoxButtons.OKCancel);
            if (dialog == System.Windows.Forms.DialogResult.Cancel)
                return;

            var result = VersionSettingsManager.Instance.Delete(item);
            if (result)
            {
                listBox1.DataSource = VersionSettingsManager.Instance.List();
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           var result = VersionSettingsManager.Instance.Create(txtVersion.Text.Trim());
           if (result)
           {   
               listBox1.DataSource = VersionSettingsManager.Instance.List();
               txtVersion.Text = string.Empty;
           }
        }


    }
}
