using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using qtellq.UserContrl;

namespace qtellq
{
    public partial class fmSetting : KryptonForm
    {
        public fmSetting()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            paneCtrl.Controls.Clear();
            paneCtrl.Controls.Add(userControl);
        }

        private void TabGeneral_Click(object sender, EventArgs e)
        {
            uc_general ucg = new uc_general();
            addUserControl(ucg);

        }

        private void TabConfig_Click(object sender, EventArgs e)
        {
            uc_configs ucc = new uc_configs();
            addUserControl(ucc);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uc_general ucg = new uc_general();
            addUserControl(ucg);
        }
    }
}
