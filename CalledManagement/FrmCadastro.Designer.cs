namespace CalledManagement
{
    partial class FrmRegisterCalled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterCalled));
            this.tbpClosedCalled = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpOpenCalled = new System.Windows.Forms.TabPage();
            this.btnSecSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbpResgister = new System.Windows.Forms.TabPage();
            this.btnRegDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRegTimer = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRegDateTime = new System.Windows.Forms.Label();
            this.txtRegStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegSave = new System.Windows.Forms.Button();
            this.txtRegDescripition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.btnRegChange = new System.Windows.Forms.Button();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegFinish = new System.Windows.Forms.Button();
            this.btnRegInit = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcCalled = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvSecCalled = new System.Windows.Forms.DataGridView();
            this.tbpClosedCalled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpOpenCalled.SuspendLayout();
            this.tbpResgister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcCalled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecCalled)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpClosedCalled
            // 
            this.tbpClosedCalled.Controls.Add(this.button3);
            this.tbpClosedCalled.Controls.Add(this.textBox2);
            this.tbpClosedCalled.Controls.Add(this.label10);
            this.tbpClosedCalled.Controls.Add(this.dataGridView1);
            this.tbpClosedCalled.Location = new System.Drawing.Point(4, 22);
            this.tbpClosedCalled.Name = "tbpClosedCalled";
            this.tbpClosedCalled.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClosedCalled.Size = new System.Drawing.Size(768, 408);
            this.tbpClosedCalled.TabIndex = 1;
            this.tbpClosedCalled.Text = "Chamados Fechados";
            this.tbpClosedCalled.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbpOpenCalled
            // 
            this.tbpOpenCalled.Controls.Add(this.btnSecSearch);
            this.tbpOpenCalled.Controls.Add(this.txtSearch);
            this.tbpOpenCalled.Controls.Add(this.label9);
            this.tbpOpenCalled.Controls.Add(this.dgvSecCalled);
            this.tbpOpenCalled.Location = new System.Drawing.Point(4, 22);
            this.tbpOpenCalled.Name = "tbpOpenCalled";
            this.tbpOpenCalled.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOpenCalled.Size = new System.Drawing.Size(768, 408);
            this.tbpOpenCalled.TabIndex = 0;
            this.tbpOpenCalled.Text = "Chamados abertos ";
            this.tbpOpenCalled.UseVisualStyleBackColor = true;
            // 
            // btnSecSearch
            // 
            this.btnSecSearch.Location = new System.Drawing.Point(192, 355);
            this.btnSecSearch.Name = "btnSecSearch";
            this.btnSecSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSecSearch.TabIndex = 7;
            this.btnSecSearch.Text = "Pesquisar";
            this.btnSecSearch.UseVisualStyleBackColor = true;
            this.btnSecSearch.Click += new System.EventHandler(this.btnSecSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(52, 358);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nome";
            // 
            // tbpResgister
            // 
            this.tbpResgister.Controls.Add(this.btnRegDelete);
            this.tbpResgister.Controls.Add(this.groupBox1);
            this.tbpResgister.Controls.Add(this.txtRegStatus);
            this.tbpResgister.Controls.Add(this.label11);
            this.tbpResgister.Controls.Add(this.btnRegSave);
            this.tbpResgister.Controls.Add(this.txtRegDescripition);
            this.tbpResgister.Controls.Add(this.label8);
            this.tbpResgister.Controls.Add(this.txtRegID);
            this.tbpResgister.Controls.Add(this.label7);
            this.tbpResgister.Controls.Add(this.btnRegCancel);
            this.tbpResgister.Controls.Add(this.btnRegChange);
            this.tbpResgister.Controls.Add(this.txtRegName);
            this.tbpResgister.Controls.Add(this.label5);
            this.tbpResgister.Controls.Add(this.btnRegFinish);
            this.tbpResgister.Controls.Add(this.btnRegInit);
            this.tbpResgister.Controls.Add(this.dtpRegDate);
            this.tbpResgister.Controls.Add(this.label6);
            this.tbpResgister.Location = new System.Drawing.Point(4, 22);
            this.tbpResgister.Name = "tbpResgister";
            this.tbpResgister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResgister.Size = new System.Drawing.Size(768, 408);
            this.tbpResgister.TabIndex = 2;
            this.tbpResgister.Text = "Cadastrar";
            this.tbpResgister.UseVisualStyleBackColor = true;
            // 
            // btnRegDelete
            // 
            this.btnRegDelete.Location = new System.Drawing.Point(268, 327);
            this.btnRegDelete.Name = "btnRegDelete";
            this.btnRegDelete.Size = new System.Drawing.Size(58, 49);
            this.btnRegDelete.TabIndex = 28;
            this.btnRegDelete.Text = "Excluir";
            this.btnRegDelete.UseVisualStyleBackColor = true;
            this.btnRegDelete.Click += new System.EventHandler(this.btnRegDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRegTimer);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbRegDateTime);
            this.groupBox1.Location = new System.Drawing.Point(509, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 251);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chamado Atual";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbRegTimer
            // 
            this.lbRegTimer.AutoSize = true;
            this.lbRegTimer.Location = new System.Drawing.Point(24, 120);
            this.lbRegTimer.Name = "lbRegTimer";
            this.lbRegTimer.Size = new System.Drawing.Size(49, 13);
            this.lbRegTimer.TabIndex = 3;
            this.lbRegTimer.Text = "00:00:00";
            this.lbRegTimer.Click += new System.EventHandler(this.label13_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(24, 91);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Tempo no Chamado...";
            this.label33.Click += new System.EventHandler(this.lbRegTimer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Data/Hora cadastro";
            // 
            // lbRegDateTime
            // 
            this.lbRegDateTime.AutoSize = true;
            this.lbRegDateTime.Location = new System.Drawing.Point(24, 64);
            this.lbRegDateTime.Name = "lbRegDateTime";
            this.lbRegDateTime.Size = new System.Drawing.Size(81, 13);
            this.lbRegDateTime.TabIndex = 0;
            this.lbRegDateTime.Text = "dd-MM-yy h:m:s";
            this.lbRegDateTime.Click += new System.EventHandler(this.lbRegDateTime_Click);
            // 
            // txtRegStatus
            // 
            this.txtRegStatus.Location = new System.Drawing.Point(103, 287);
            this.txtRegStatus.Name = "txtRegStatus";
            this.txtRegStatus.Size = new System.Drawing.Size(307, 20);
            this.txtRegStatus.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Finalizado (s/n)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnRegSave
            // 
            this.btnRegSave.Location = new System.Drawing.Point(348, 327);
            this.btnRegSave.Name = "btnRegSave";
            this.btnRegSave.Size = new System.Drawing.Size(64, 49);
            this.btnRegSave.TabIndex = 24;
            this.btnRegSave.Text = "Salvar";
            this.btnRegSave.UseVisualStyleBackColor = true;
            this.btnRegSave.Click += new System.EventHandler(this.btnRegSave_Click);
            // 
            // txtRegDescripition
            // 
            this.txtRegDescripition.Location = new System.Drawing.Point(22, 114);
            this.txtRegDescripition.Multiline = true;
            this.txtRegDescripition.Name = "txtRegDescripition";
            this.txtRegDescripition.Size = new System.Drawing.Size(390, 99);
            this.txtRegDescripition.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descrição";
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(60, 23);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(350, 20);
            this.txtRegID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Codigo";
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(188, 327);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(58, 49);
            this.btnRegCancel.TabIndex = 19;
            this.btnRegCancel.Text = "Cancelar";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegChange
            // 
            this.btnRegChange.Location = new System.Drawing.Point(103, 327);
            this.btnRegChange.Name = "btnRegChange";
            this.btnRegChange.Size = new System.Drawing.Size(61, 49);
            this.btnRegChange.TabIndex = 18;
            this.btnRegChange.Text = "Alterar";
            this.btnRegChange.UseVisualStyleBackColor = true;
            this.btnRegChange.Click += new System.EventHandler(this.btnRegChange_Click);
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(60, 60);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(352, 20);
            this.txtRegName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome";
            // 
            // btnRegFinish
            // 
            this.btnRegFinish.Location = new System.Drawing.Point(509, 327);
            this.btnRegFinish.Name = "btnRegFinish";
            this.btnRegFinish.Size = new System.Drawing.Size(208, 49);
            this.btnRegFinish.TabIndex = 15;
            this.btnRegFinish.Text = "Finalizar Chamado";
            this.btnRegFinish.UseVisualStyleBackColor = true;
            this.btnRegFinish.Click += new System.EventHandler(this.btnRegFinish_Click);
            // 
            // btnRegInit
            // 
            this.btnRegInit.Location = new System.Drawing.Point(24, 327);
            this.btnRegInit.Name = "btnRegInit";
            this.btnRegInit.Size = new System.Drawing.Size(62, 49);
            this.btnRegInit.TabIndex = 14;
            this.btnRegInit.Text = "Iniciar";
            this.btnRegInit.UseVisualStyleBackColor = true;
            this.btnRegInit.Click += new System.EventHandler(this.btnRegInit_Click);
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.CustomFormat = "dd-MM-yyyy h:m";
            this.dtpRegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpRegDate.Location = new System.Drawing.Point(22, 248);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(388, 20);
            this.dtpRegDate.TabIndex = 11;
            this.dtpRegDate.Value = new System.DateTime(2021, 5, 13, 12, 34, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data e hora";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbcCalled
            // 
            this.tbcCalled.Controls.Add(this.tbpResgister);
            this.tbcCalled.Controls.Add(this.tbpOpenCalled);
            this.tbcCalled.Controls.Add(this.tbpClosedCalled);
            this.tbcCalled.Location = new System.Drawing.Point(12, 12);
            this.tbcCalled.Name = "tbcCalled";
            this.tbcCalled.SelectedIndex = 0;
            this.tbcCalled.Size = new System.Drawing.Size(776, 434);
            this.tbcCalled.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvSecCalled
            // 
            this.dgvSecCalled.AllowUserToAddRows = false;
            this.dgvSecCalled.AllowUserToDeleteRows = false;
            this.dgvSecCalled.AllowUserToResizeColumns = false;
            this.dgvSecCalled.AllowUserToResizeRows = false;
            this.dgvSecCalled.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSecCalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecCalled.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSecCalled.Location = new System.Drawing.Point(21, 19);
            this.dgvSecCalled.Name = "dgvSecCalled";
            this.dgvSecCalled.Size = new System.Drawing.Size(727, 318);
            this.dgvSecCalled.TabIndex = 0;
            this.dgvSecCalled.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecCalled_CellContentClick);
            // 
            // FrmRegisterCalled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.tbcCalled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegisterCalled";
            this.Text = "CHAMADOS";
            this.Load += new System.EventHandler(this.FrmRegisterCalled_Load);
            this.tbpClosedCalled.ResumeLayout(false);
            this.tbpClosedCalled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpOpenCalled.ResumeLayout(false);
            this.tbpOpenCalled.PerformLayout();
            this.tbpResgister.ResumeLayout(false);
            this.tbpResgister.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcCalled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecCalled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpClosedCalled;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbpOpenCalled;
        private System.Windows.Forms.TabPage tbpResgister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tbcCalled;
        private System.Windows.Forms.Button btnRegFinish;
        private System.Windows.Forms.Button btnRegInit;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Button btnRegChange;
        private System.Windows.Forms.TextBox txtRegDescripition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSecSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegSave;
        private System.Windows.Forms.TextBox txtRegStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRegDateTime;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lbRegTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvSecCalled;
    }
}