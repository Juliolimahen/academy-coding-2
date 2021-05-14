using CalledManagement.DAO;
using CalledManagement.Entities;
using CalledManagement.Utils;
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
    public partial class FrmRegisterCalled : Form
    {
        string operation;
        public FrmRegisterCalled()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegFinish_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegInit_Click(object sender, EventArgs e)
        {

            Function.EnableFields(this, true);
            Function.Clean(this);
            Function.EnableButtons(this, "Save");
            txtRegID.Enabled = false;
            txtRegName.Focus();
            operation = "Init";

        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {


            Called called = new Called();
            called.Name = txtRegName.Text;
            called.Date = dtpRegDate.Value;
            called.Descripition = txtRegDescripition.Text;
            called.Status = txtRegStatus.Text;

            if (operation == "Init")
            {
                CalledDAO calleddao = new CalledDAO();
                if (calleddao.Insert(called) == false)
                {
                    txtRegName.Focus();
                    return;
                }

            }
            else if (operation == "Change")
            {

                CalledDAO calleddao = new CalledDAO();
                called.Id = int.Parse(txtRegID.Text);
                if (calleddao.Change(called) == false)
                {
                    txtRegName.Focus();
                    return;
                }
            }

            Function.EnableFields(this, false);
            Function.Clean(this);
            Function.EnableButtons(this, "Init");
            txtRegID.Enabled = true;
            //txtRegResearch.Enabled = true;
            txtRegID.Focus();
            operation = "";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRegChange_Click(object sender, EventArgs e)
        {
            Function.EnableFields(this, true);
            Function.EnableButtons(this, "Save");
            txtRegID.Enabled = false;
            txtRegName.Focus();
            operation = "Change";
        }
    }
}
