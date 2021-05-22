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
            txtRegID.Focus();
            operation = "";

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timerCalled = new DateTime();

            //variavel responsavel por atribuir a hora timer, falta zerar e enviar esse date time ao banco
            //_DateTime = DateTime.Now
            //timerCalled.ToString("01"); 
            lbRegTimer.Text = timerCalled.ToString("");

        }

        //Botão pesquisa na grid view 
        private void btnSecSearch_Click(object sender, EventArgs e)
        {
            //nova instancia 
            CalledDAO calleddao = new CalledDAO();
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();

            string SecSearchCalled = txtSecSearchCalled.Text;
            //calleddao.SearchGrid(dgvSecCalled, name);

            calleddao.ListarGrid(dgvSecCalled, SecSearchCalled);

            string SecSearchHours;
            SecSearchHours = txtSecSearchHours.Text;
            hourworkeddao.ListarGrid(dgvSecHours, SecSearchHours);
        }

        private void FrmRegisterCalled_Load(object sender, EventArgs e)
        {
            //Cria nova instância
            CalledDAO calleddao = new CalledDAO();
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();
            //passa a data grid view por parametro

            string name = txtSecSearchCalled.Text;
            calleddao.ListarGrid(dgvSecCalled, name);
            string SecSearchHours;

            SecSearchHours = txtSecSearchHours.Text;
            hourworkeddao.ListarGrid(dgvSecHours, SecSearchHours);

            calleddao.ListarComboBox(cbxRegHours);

        }

        //Botão Cancelar 

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

        private void btnSecSearch_Click_1(object sender, EventArgs e)
        {

            //nova instancia 
            CalledDAO calleddao = new CalledDAO();
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();

            string name = txtSecSearchCalled.Text;
           
            calleddao.ListarGrid(dgvSecCalled, name);

            string SecSearchHours;
            SecSearchHours = txtSecSearchHours.Text;
            hourworkeddao.ListarGrid(dgvSecHours, SecSearchHours);

            //Passa texto do text box por parametro
            //dgvSecCalled.DataSource = calleddao.SearchName(txtSearch.Text);

        }

        private void btnRegInitHours_Click(object sender, EventArgs e)
        {
            Function.EnableFields(this, true);
            Function.Clean(this);
            Function.EnableButtons(this, "Save");
            cbxRegHours.Focus();
            operation = "Init";
            _DateTime = DateTime.Now;
            lbRegDateTime.Text = _DateTime.ToString();
            // ativa o timer ao iniciar um chamado
            timer1.Start();
            timer1.Enabled = true;
        }

        private void btnRegChangeHours_Click(object sender, EventArgs e)
        {
            if (txtRegID.Text.Length == 0)
            {
                MessageBox.Show("Selecione o chamado para qual deseja alterar as horas!");
                cbxRegHours.Focus();
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Change");
            }

            //else if (cbxRegHours)
          //  {
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Save");
                txtRegID.Enabled = false;
                txtRegName.Focus();
           // }

            operation = "Change";
        }

        private void btnRegDeleteHours_Click(object sender, EventArgs e)
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

        private void btnRegSaveHours_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                HourWorked hourworked = new HourWorked();
                //hourworked.CalledId = cbxRegHours.;
               // hourworked.Date = dtpRegDate.Value;
               // hourworked.Descripition = txtRegDescripition.Text;
               // hourworked.Finished = txtRegStatus.Text;

                if (operation == "Init")
                {
                    CalledDAO calleddao = new CalledDAO();
                   // if (calleddao.Insert(called) == false)
                    {
                        txtRegName.Focus();
                        return;
                    }

                }
                else if (operation == "Change")
                {

                    CalledDAO calleddao = new CalledDAO();
                 //   called.Id = int.Parse(txtRegID.Text);
                   // if (calleddao.Change(called) == false)
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

        private void btnRegCancelHours_Click(object sender, EventArgs e)
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

        private void cbxRegHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CalledDAO calleddao = new CalledDAO();
            //passa a data grid view por parametro
            //string name ="";
            //calleddao.ListarComboBox(cbxRegHours);
        }
    }
}
