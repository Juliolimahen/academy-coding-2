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
            // TODO: esta linha de código carrega dados na tabela 'academycoding2DataSet.Query_Called_Report'. Você pode movê-la ou removê-la conforme necessário.
            this.Query_Called_ReportTableAdapter.Fill(this.academycoding2DataSet.Query_Called_Report);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
