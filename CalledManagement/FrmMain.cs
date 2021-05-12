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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)
        {
            FrmRegisterCalled frmregidtercalled = new FrmRegisterCalled();
            frmregidtercalled.ShowDialog();

        }
    }
}
