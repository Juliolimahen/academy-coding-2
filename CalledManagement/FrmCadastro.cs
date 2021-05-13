using CalledManagement.DAO;
using CalledManagement.Entities;
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
        string operation = "";
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
            Called called = new Called();
            CalledDAO calleddao = new CalledDAO();
            if (calleddao.Inserir(called) == false)
            {
                txtRegName.Focus();
                operation = "Init";
                return;
            }
        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {

            
                Called called = new Called();
                called.Name = txtRegName.Text;
                called.Date = dtpRegDate.MaxDate;
                called.Descripition = txtRegDescripition.Text;
                called.Status = txtRegStatus.Text;
                

                if (operation == "Init")
                {
                    CalledDAO calleddao = new CalledDAO();
                    if (calleddao.Inserir(called) == false)
                    {
                        txtRegName.Focus();
                        return;
                    }

                }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
