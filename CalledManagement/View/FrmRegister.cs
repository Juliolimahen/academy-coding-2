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
            cbxRegID.Enabled = false;
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
                HourWorked hourworked = new HourWorked();
                called.Name = txtRegName.Text;
                if (rbRegCalledHoursSystem.Checked == true)
                {
                    dtpRegDate.Enabled = false;
                    called.Date = DateTime.Now;
                    hourworked.Manual = 'N';
                }
                else
                {
                    dtpRegDate.Enabled = true;
                    called.Date = Convert.ToDateTime(dtpRegDate.Text);
                    hourworked.Manual = 'S';
                }
                    called.Descripition = txtRegDescripition.Text;

                if (rbRegStatusFinished.Checked == true)
                {
                    called.Finished = "S";
                }
                else
                {
                    called.Finished = "N";
                }
                Priority priority = new Priority();
                called.PriorityId = priority;
                called.PriorityId.Id= Convert.ToInt32(cbxRegPriority.SelectedValue.ToString());

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
                    called.Id = Convert.ToInt32(cbxRegID.SelectedValue.ToString());
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
            cbxRegID.Enabled = true;
            cbxRegID.Focus();
            operation = "";
        }

        //botão para editar registros 
        private void btnRegChange_Click(object sender, EventArgs e)
        {
                    
            if (cbxRegID.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um codigo identificador para alterar o registro!");
                cbxRegID.Focus();
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Change");
            }

            else if (cbxRegID.SelectedIndex > -1)
            {
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Save");
                BuscarRegistroCalled();
                cbxRegID.Enabled = false;
                txtRegName.Focus();
            }

            operation = "Change";
        }
        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a edição do registro ?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Function.EnableFields(this, false);
                Function.Clean(this);
                Function.EnableButtons(this, "Load");
                cbxRegID.Focus();
                operation = "";
            }
        }

        private void btnRegDelete_Click(object sender, EventArgs e)
        {
            //verifica se campo nome esta vazio 

            if (cbxRegID.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    CalledDAO calleddao = new CalledDAO();
                    if (calleddao.Delete(Convert.ToInt32(cbxRegID.SelectedValue.ToString())) == false)
                    {
                        cbxRegID.Focus();
                    }
                    else
                    {
                        Function.Clean(this);
                        Function.EnableButtons(this, "Init");
                        cbxRegID.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um codigo identificador para excluir um registro!");
                Function.EnableFields(this, true);
            }
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
            //cbxRegID.Enabled=false;
            //txtRegName.Enabled = false;
            //txtRegDescripition.Enabled = false;
            //dtpRegDate.Enabled = false;
            //txtRegStatus.Enabled = false;

            CalledDAO calleddao = new CalledDAO();
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();
            PriorityDAO prioritydao = new PriorityDAO();
            cbxRegID.Focus();
            string name = txtSecSearchCalled.Text;
            calleddao.ListarGrid(dgvSecCalled, name);

            string SecSearchHours;
            SecSearchHours = txtSecSearchHours.Text;
            hourworkeddao.ListarGrid(dgvSecHours, SecSearchHours);

            calleddao.ListarComboBox(cbxRegHours);
            prioritydao.ListarComboBox(cbxRegPriority);
            calleddao.ListarComBoxID(cbxRegID);

            if (rbRegCalledHoursSystem.Checked == true)
            {
                dtpRegDate.Enabled = false;
            }
            else
            {
                dtpRegDate.Enabled = true;
            }

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
            //if (txtRegDescripition.Text == string.Empty)
           // {
               // MessageBox.Show("O campo nome é obrigatório!", "Atenção");
               // txtRegName.Focus();
                //return false;
          //  }
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
        }

        private void btnRegChangeHours_Click(object sender, EventArgs e)
        {
            if (cbxRegID.Text.Length == 0)
            {
                MessageBox.Show("Selecione o chamado para qual deseja alterar as horas!");
                cbxRegHours.Focus();
                Function.EnableFields(this, true);
                Function.EnableButtons(this, "Change");
            }
            BuscarRegistroHours();
            //else if (cbxRegHours)
            //  {
            Function.EnableFields(this, true);
            Function.EnableButtons(this, "Save");
            cbxRegID.Enabled = false;
            txtRegName.Focus();
            // }

            operation = "Change";
        }

        private void btnRegDeleteHours_Click(object sender, EventArgs e)
        {
            if (cbxRegID.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    HourWorkedDAO hourworkeddao = new HourWorkedDAO();
                    if (hourworkeddao.Delete(Convert.ToInt32(cbxRegHours.SelectedValue.ToString()), dgvSecCalled) == false)
                    {
                        cbxRegHours.Focus();
                    }
                    else
                    {
                        Function.Clean(this);
                        Function.EnableButtons(this, "Init");
                        cbxRegHours.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um codigo identificador para excluir um registro!");
                Function.EnableFields(this, true);
            }
        }
    
        private void btnRegSaveHours_Click(object sender, EventArgs e)
        {
            HourWorked hourworked = new HourWorked();
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();
            Called called = new Called();
            CalledDAO calleddao = new CalledDAO();
            
            MessageBox.Show(text: cbxRegHours.SelectedValue.ToString());
            hourworked.CalledId = called;
            hourworked.CalledId.Id = Convert.ToInt32(cbxRegHours.SelectedValue.ToString());
            if(operation == "Init")
            {
                hourworked.DateInserted = _DateTime = DateTime.Now;
            }

            if (Convert.ToDateTime(mstbRegDateTimeInit.Text) > Convert.ToDateTime(mstbRegDateTimeFinished.Text)){
               
                MessageBox.Show("A Data de termino não pode ser mais recente que a de inicio!");
                
            }
           
            else {
                hourworked.DateStarted = Convert.ToDateTime(mstbRegDateTimeInit.Text);
                hourworked.EndDate = Convert.ToDateTime(mstbRegDateTimeFinished.Text);

            }

            if (operation == "Change")
            {
                hourworked.DateChange =_DateTime = DateTime.Now;
            }
 
            if (operation == "Init")
            {
                hourworkeddao.Insert(hourworked, dgvSecHours);

            }
            else if (operation == "Change")
            {
                hourworked.CalledId.Id = Convert.ToInt32(cbxRegID.SelectedValue.ToString());
                if (calleddao.Change(called) == false)
                {
                    txtRegName.Focus();
                    return;
                }
            }

            Function.EnableFields(this, false);
            Function.Clean(this);
            Function.EnableButtons(this, "Init");
            operation = "";

        }

        private void btnRegCancelHours_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a edição do registro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Function.EnableFields(this, false);
                Function.Clean(this);
                Function.EnableButtons(this, "Load");
                cbxRegID.Focus();
                operation = "";
            }
        }

        private void btnRegFinishedHours_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegFinishedCalled_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar o cadastro?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gbxRegHours.Enabled = true;
                gbxRegCalled.Enabled = false;
            }
        }

        private void btnRegFinishedHours_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar o cadastro?", "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gbxRegCalled.Enabled = true;
                gbxRegHours.Enabled = false;
            }
        }

        private void BuscarRegistroCalled()
        {
            int id = int.Parse(cbxRegID.SelectedValue.ToString());
            Function.Clean(this);
            CalledDAO calleddao = new CalledDAO();
            Called called = new Called();

            called = calleddao.SearchID(id);

            if (called.Id > 0)
            {
                cbxRegID.SelectedValue = int.Parse(called.Id.ToString());
                txtRegName.Text = called.Name;
                txtRegDescripition.Text = called.Descripition;
                dtpRegDate.Text = called.Date.ToString();
                cbxRegPriority.SelectedValue = int.Parse(called.PriorityId.Id.ToString());
                if (called.Finished == "N")
                {
                    rbRegStatusProgress.Checked = true;
                }
                else
                {
                    rbRegStatusFinished.Checked = true;
                }

                Function.EnableButtons(this, "Change");
            }
            else MessageBox.Show("Codigo de cliente não encontrado!", "Atenção");
        }
        private void BuscarRegistroHours()
        {
            int id = int.Parse(cbxRegID.SelectedValue.ToString());
            Function.Clean(this);
            HourWorkedDAO hourworkeddao = new HourWorkedDAO();
            HourWorked hourworked = new HourWorked();

            hourworked = hourworkeddao.SearchID(id);

            if (hourworked.CalledId.Id > 0)
            {
                cbxRegID.SelectedValue = int.Parse(hourworked.CalledId.Id.ToString());
                mstbRegDateTimeInit.Text = hourworked.DateStarted.ToString();
                mstbRegDateTimeFinished.Text = hourworked.EndDate.ToString();
 
                Function.EnableButtons(this, "Change");
            }
            else MessageBox.Show("Codigo de cliente não encontrado!", "Atenção");
        }
        private void cbxRegID_SelectedIndex(object sender, KeyEventArgs e)
        {
            BuscarRegistroCalled();
        }
    }   
}

