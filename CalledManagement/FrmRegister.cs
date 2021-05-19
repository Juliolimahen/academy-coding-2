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
    //Classe resposavel pelo formulário de registro. herdada da classe Form
    public partial class FrmRegisterCalled : Form
    {
        // variavel global resposanvel por armazanar qual operação seguir na troca de botoes 
        string operation;
        //variavel global resposavel por guardar hora e data da inserção dos chamados 
        DateTime _DateTime;
        //Construtor responsavel por inicializar o componente; 
        public FrmRegisterCalled()
        {
            InitializeComponent();
        }
        private void FrmCadastro_Activated(object sender, EventArgs e)
        {
            txtRegID.Focus();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Botão para Finalizar chamado
        private void btnRegFinish_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //Botao para iniciar chamado 
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
            // ativa o timer ao iniciar um chamado
            timer1.Start();
            timer1.Enabled = true;
            




        }

        //botão para salvar registros 
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

        //botão para editar registros 
        private void btnRegChange_Click(object sender, EventArgs e)
        {
            if (txtRegID.Text.Length == 0)
            {
                MessageBox.Show("Digite um codigo identificador para alterar o registro!");
                txtRegID.Focus();
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Change");
            }
            
           
            else if (txtRegID.Text.Length > 0)
            {
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Save");
                txtRegID.Enabled = false;
                txtRegName.Focus();
            }

            operation = "Change";
        }

        private void btnRegDelete_Click(object sender, EventArgs e)
        {
            //verifica se campo nome esta vazio 
            if (txtRegName.Text.Length > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    CalledDAO calleddao = new CalledDAO();
                    if (calleddao.Delete(int.Parse(txtRegID.Text)) == false)
                    {
                        txtRegID.Focus();
                    }
                    else
                    {
                        Function.Clean(this);
                        Function.EnableButtons(this, "Init");
                        txtRegID.Focus();
                    }
                }
            }
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
             DateTime timerCalled = new DateTime();

            //variavel responsavel por atribuir a hora timer, falta zerar e enviar esse date time ao banco
            //_DateTime = DateTime.Now
            //timerCalled.ToString("01"); 
            lbRegTimer.Text = timerCalled.ToString("");
            
           
            

            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        //Botão pesquisa na grid view 
        private void btnSecSearch_Click(object sender, EventArgs e)
        {
            //nova instancia 
            CalledDAO calleddao = new CalledDAO();

            string name = txtSearch.Text;
            //calleddao.SearchGrid(dgvSecCalled, name);
         
            calleddao.ListarGrid(dgvSecCalled, name);

            //Passa texto do text box por parametro
            //dgvSecCalled.DataSource = calleddao.SearchName(txtSearch.Text);

        }

        private void dgvSecCalled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegisterCalled_Load(object sender, EventArgs e)
        {
            //Cria nova instância
            CalledDAO calleddao = new CalledDAO();
            //passa a data grid view por parametro
            string name=txtSearch.Text;
            calleddao.ListarGrid(dgvSecCalled, name);
            Refresh();
        }

        //Botão Cancelar 
        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a edição do registro ?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Function.EnableFields(this, true);
                Function.Clean(this);
                Function.EnableButtons(this, "Load");
                txtRegID.Focus();
                operation = "";
            }
        }
        //metodo resposavel pela validação dos dados 
        private Boolean ValidateData()
        {
            if (txtRegName.Text == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório!", "Atenção");
                txtRegName.Focus();
                return false;
            }
            return true;
        }

        private void tbpResgister_Click(object sender, EventArgs e)
        {

        }

        private void dgvSecCalled_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSecSearch_Click_1(object sender, EventArgs e)
        {

            //nova instancia 
            CalledDAO calleddao = new CalledDAO();

            string name = txtSearch.Text;
            //calleddao.SearchGrid(dgvSecCalled, name);

            calleddao.ListarGrid(dgvSecCalled, name);

            //Passa texto do text box por parametro
            //dgvSecCalled.DataSource = calleddao.SearchName(txtSearch.Text);
        }
    }
}
