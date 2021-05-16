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
    public partial class FrmRepCalled : Form
    {
        public FrmRepCalled()
        {
            InitializeComponent();
        }

        private void FrmRepCalled_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academycoding2DataSet1.CALLED'. Você pode movê-la ou removê-la conforme necessário.
            this.CALLEDTableAdapter.Fill(this.academycoding2DataSet1.CALLED);

            this.reportViewer1.RefreshReport();
        }
    }
}
