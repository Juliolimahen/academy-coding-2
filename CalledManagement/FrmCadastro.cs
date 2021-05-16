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
        DateTime _DateTime;
        public FrmRegisterCalled()
        {
            InitializeComponent();
        }
        private void FrmCadastro_Activated(object sender, EventArgs e)
        {
            txtRegID.Focus();
        }
        private Boolean ValidateData()
        {
            {
                if (txtRegName.Text == string.Empty)
                {
                    MessageBox.Show("O campo nome é obrigatório !", "Atenção");
                    txtRegName.Focus();
                    return false;
                }
                return true;
            }
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
            _DateTime = DateTime.Now;
            lbRegDateTime.Text = _DateTime.ToString();
            timer1.Enabled = true;


        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {

                Called called = new Called();
                called.Name = txtRegName.Text;
                called.Date = dtpRegDate.Value;
                called.Descripition = txtRegDescripition.Text;
                called.Finished = txtRegStatus.Text;

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

        private void btnRegDelete_Click(object sender, EventArgs e)
        {
            if (txtRegName.Text.Length > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro ?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    CalledDAO calleddao = new CalledDAO();
                    if (calleddao.Delete(int.Parse(txtRegID.Text)) == false)
                    {
                        txtRegID.Focus();
                        return;
                    }
                    else
                    {
                        Function.Clean(this);
                        Function.EnableButtons(this, "");
                        txtRegID.Focus();
                    }
                }
            }
        }

         private void SearchRegistration()
         {
             int id = int.Parse(txtRegID.Text);
             Function.Clean(this);
             CalledDAO calleddao = new CalledDAO();
             Called called = new Called();

             called = calleddao.SearchID(id);

             if (called.Id > 0)
             {
                 txtRegID.Text = called.Id.ToString();
                 txtRegName.Text = called.Name;
                 dtpRegDate.Text = called.Date.ToString();
                 txtRegStatus.Text = called.Finished;
                 txtRegDescripition.Text = called.Descripition;

                 Function.EnableButtons(this, "Change");
             }
             else MessageBox.Show("Codigo de cliente não encontrado!", "Atenção");
         }

        private void lbRegTimer_Click(object sender, EventArgs e)
        {

        }

        private void lbRegDateTime_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _DateTime = DateTime.Now;
            lbRegTimer.Text = _DateTime.ToLongTimeString();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSecSearch_Click(object sender, EventArgs e)
        {
            CalledDAO calleddao = new CalledDAO();
            //string Name = txtSearch.Text;
            //calleddao.SearchGrid(dgvSecCalled, Name);

            dgvSecCalled.DataSource = calleddao.SearchName(txtSearch.Text);

        }

        private void dgvSecCalled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmRegisterCalled_Load(object sender, EventArgs e)
        {
            CalledDAO calleddao = new CalledDAO();
            calleddao.ListarGrid(dgvSecCalled);
        }

        private void txtRegID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRegID.Text.Length > 0)
                {
                    SearchRegistration();
                    btnRegChange.Focus();
                }
            }
        }
    }
}
