using CalledManagement.EntitiesDAO;
using CalledManagement.EntitiesModel;
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

namespace CalledManagement.Views
{
    public partial class FrmUser : Form
    {
        private string operation;

        public FrmUser()
        {
            InitializeComponent();
        }
        private void btnRegInit_Click(object sender, EventArgs e)
        {
            Function.EnableFields(this, true);
            Function.Clean(this);
            Function.EnableButtons(this, "Save");
            //cbxRegID.Enabled = false;
            txtRegName.Focus();
            operation = "Init";
            //txtRegDate.Enabled = false;
            //txtSecSearchCalled.Enabled = true;
        }
        private Boolean ValidateDataUser()
        {
            if (txtRegName.Text == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório!", "Atenção");
                txtRegName.Focus();
                return false;
            }
            if (txtRegPassword.Text == string.Empty)
            {
                MessageBox.Show("O campo Descrição é obrigatório!", "Atenção");
                txtRegName.Focus();
                return false;
            }
            return true;
        }
        //botão para salvar registros 
        private void btnRegSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (ValidateDataUser() == true)
            {

                //HourWorked hourworked = new HourWorked();
                user.Descripition = txtRegName.Text;
                user.RegisterDate = DateTime.Now;
                //user.UpdateDate = DateTime.Now;
                user.Password = txtRegPassword.Text;
                user.Email = txtEmail.Text;

                //Priority priority = new Priority();
                //called.PriorityId = priority;
                //called.PriorityId.Id = Convert.ToInt32(cbxRegPriority.SelectedValue.ToString());
                if (operation == "Init")
                {
                    UserDAO userdao = new UserDAO();
                    if (userdao.Insert(user) == false)
                    {
                        txtRegName.Focus();
                        return;
                    }
                }
                else if (operation == "Change")
                {
                    UserDAO userdao = new UserDAO();
                    user.Id = Convert.ToInt32(cbxRegID.SelectedValue.ToString());
                    if (userdao.Change(user) == false)
                    {
                        txtRegName.Focus();
                        return;
                    }
                    //txtRegDate.Enabled = false;
                }
            }

            //LoadComboxs();
            //LoadGrids();
            Function.EnableFields(this, false);
            Function.Clean(this);
            Function.EnableButtons(this, "Init");
            cbxRegID.Enabled = true;
            cbxRegID.Focus();
            operation = "";
            //txtSecSearchHours.Enabled = true;
            // txtSecSearchCalled.Enabled = true;
        }
        //botão para editar registros 
        private void btnRegChange_Click(object sender, EventArgs e)
        {

            if (cbxRegID.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um codigo identificador para alterar um registro e clique novamente em alterar!", "Atenção!!!");
                cbxRegID.Focus();
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Change");
            }

            else if (cbxRegID.SelectedIndex >= 0)
            {
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Save");
                //BuscarRegistroCalled();
                cbxRegID.Enabled = true;
                txtRegName.Focus();
            }

            operation = "Change";
            //txtSecSearchHours.Enabled = true;
            //txtSecSearchCalled.Enabled = true;
        }
        //botão responsável por cancelar cadastro 
        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a edição do registro ?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Function.EnableFields(this, false);
                Function.Clean(this);
                Function.EnableButtons(this, "Load");
                operation = "";
                // txtSecSearchHours.Enabled = true;
                // txtSecSearchCalled.Enabled = true;
            }
        }
        //botão resposavel por deletar registros dos chamados 
        private void btnRegDelete_Click(object sender, EventArgs e)
        {
            UserDAO userdao = new UserDAO();
            //verifica se campo nome esta vazio 

            if (cbxRegID.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (userdao.Delete(Convert.ToInt32(cbxRegID.SelectedValue.ToString())) == false)
                    {
                        cbxRegID.Focus();
                    }
                    else
                    {
                        Function.Clean(this);
                        Function.EnableButtons(this, "Init");
                        cbxRegID.Focus();
                        //LoadGrids();
                        //LoadComboxs();
                        MessageBox.Show("Cadastro Excluido com sucesso!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um codigo identificador para excluir um registro!");
                Function.EnableFields(this, true);
            }
            //txtSecSearchCalled.Enabled = true;
            //txtSecSearchCalled.Enabled = true;
        }

        private void btnRegFinish_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            Function.EnableFields(this, false);
            Function.EnableButtons(this, "Load");
            //LoadComboxs();
            LoadGrids();
            //txtSecSearchHours.Enabled = true;
            //txtSecSearchCalled.Enabled = true;
            Function.Clean(this);
        }
        public void LoadGrids()
        {
            UserDAO userdao = new UserDAO();
      
            string name = txtSecSearchUser.Text;
            userdao.ToListGrid(dgvUser, name);

            //textBoxPesquisa
            //txtSecSearchCalled.Enabled = true;
            //txtSecSearchHours.Enabled = true;
        }
        public void LoadComboxs()
        {
            UserDAO userdao = new UserDAO();
            userdao.ToListComboBoxID(cbxRegID);
        }
    }
}
