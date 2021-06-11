﻿using System;
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
            FrmRegisterCalled frmregistercalled = new FrmRegisterCalled();
            frmregistercalled.ShowDialog();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            FrmRepCalled frmrepcalled = new FrmRepCalled();
            frmrepcalled.ShowDialog();
        }

        private void chamadosFechadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepHours frmrephours = new FrmRepHours();
            frmrephours.ShowDialog();
        }
    }
    
}