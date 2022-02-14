using CalledManagement.EntitiesDAO;

using CalledManagement.Views;
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashBoard = new FrmDashboard();
            frmDashBoard.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
        }
        public void ListarChamadosAbertos()
        {
            CalledDAO calleddao = new CalledDAO();
            string name = "";
            dataGridView1.DataSource = calleddao.ToListGrid(name);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academycoding2DataSet.CALLED'. Você pode movê-la ou removê-la conforme necessário.
            ListarChamadosAbertos();
        }
      
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // método executado somente quando o dado um
            // duplo clique no DataGridView
            LevarID();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // método executado somente quando
                // dado um ENTER no datagridview
                LevarID();
            }
        }

        private void LevarID()
        {
            /*if (dataGridView1. > 0)
            {
                /*txtCodigo.Text = listBox1.CurrentRow.Cells[0].Value.ToString();
                //Pega o valor da celula [0] que é referente
                // o <<ID>> e passa para o campo txtcodigo
                tabControl1.SelectedTab = tbpCadastro;
                txtCodigo.Focus();
                BuscarRegistro();

            }*/
        }

    }
}
