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
    public partial class FrmRepHours : Form
    {
        public FrmRepHours()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academycoding2DataSet2.HOURWORKED'. Você pode movê-la ou removê-la conforme necessário.
            this.HOURWORKEDTableAdapter.Fill(this.academycoding2DataSet2.HOURWORKED);

            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.HOURWORKEDTableAdapter.FillBy(this.academycoding2DataSet2.HOURWORKED);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.HOURWORKEDTableAdapter.FillBy(this.academycoding2DataSet2.HOURWORKED);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
