using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        Boolean PerIsert=false; Boolean PerChange=false; Boolean PerDelete=false;Boolean PerView=false;

        private void btnRegFinish_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
