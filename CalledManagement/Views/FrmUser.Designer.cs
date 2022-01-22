
namespace CalledManagement.Views
{
    partial class FrmUser
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
            this.tbcUser = new System.Windows.Forms.TabControl();
            this.tbpRegUser = new System.Windows.Forms.TabPage();
            this.gbxCadUsers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbxRegID = new System.Windows.Forms.ComboBox();
            this.btnRegDelete = new System.Windows.Forms.Button();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.btnRegSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.btnRegChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegFinish = new System.Windows.Forms.Button();
            this.btnRegInit = new System.Windows.Forms.Button();
            this.dtpRegDateAlteracao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSecSearchUser = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tbpSecUser = new System.Windows.Forms.TabPage();
            this.tbcUser.SuspendLayout();
            this.tbpRegUser.SuspendLayout();
            this.gbxCadUsers.SuspendLayout();
            this.gbxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcUser
            // 
            this.tbcUser.Controls.Add(this.tbpRegUser);
            this.tbcUser.Controls.Add(this.tbpSecUser);
            this.tbcUser.Location = new System.Drawing.Point(12, 6);
            this.tbcUser.Name = "tbcUser";
            this.tbcUser.SelectedIndex = 0;
            this.tbcUser.Size = new System.Drawing.Size(1288, 685);
            this.tbcUser.TabIndex = 1;
            // 
            // tbpRegUser
            // 
            this.tbpRegUser.Controls.Add(this.gbxCadUsers);
            this.tbpRegUser.Controls.Add(this.gbxUsers);
            this.tbpRegUser.Location = new System.Drawing.Point(4, 22);
            this.tbpRegUser.Name = "tbpRegUser";
            this.tbpRegUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegUser.Size = new System.Drawing.Size(1280, 659);
            this.tbpRegUser.TabIndex = 0;
            this.tbpRegUser.Text = "Cadastrar";
            this.tbpRegUser.UseVisualStyleBackColor = true;
            // 
            // gbxCadUsers
            // 
            this.gbxCadUsers.Controls.Add(this.label1);
            this.gbxCadUsers.Controls.Add(this.txtEmail);
            this.gbxCadUsers.Controls.Add(this.cbxRegID);
            this.gbxCadUsers.Controls.Add(this.btnRegDelete);
            this.gbxCadUsers.Controls.Add(this.txtRegPassword);
            this.gbxCadUsers.Controls.Add(this.txtRegName);
            this.gbxCadUsers.Controls.Add(this.btnRegSave);
            this.gbxCadUsers.Controls.Add(this.label8);
            this.gbxCadUsers.Controls.Add(this.label7);
            this.gbxCadUsers.Controls.Add(this.btnRegCancel);
            this.gbxCadUsers.Controls.Add(this.btnRegChange);
            this.gbxCadUsers.Controls.Add(this.label5);
            this.gbxCadUsers.Controls.Add(this.btnRegFinish);
            this.gbxCadUsers.Controls.Add(this.btnRegInit);
            this.gbxCadUsers.Controls.Add(this.dtpRegDateAlteracao);
            this.gbxCadUsers.Controls.Add(this.label6);
            this.gbxCadUsers.Location = new System.Drawing.Point(7, 13);
            this.gbxCadUsers.Name = "gbxCadUsers";
            this.gbxCadUsers.Size = new System.Drawing.Size(462, 515);
            this.gbxCadUsers.TabIndex = 51;
            this.gbxCadUsers.TabStop = false;
            this.gbxCadUsers.Text = "Cadastro Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 20);
            this.txtEmail.TabIndex = 82;
            // 
            // cbxRegID
            // 
            this.cbxRegID.FormattingEnabled = true;
            this.cbxRegID.Location = new System.Drawing.Point(71, 29);
            this.cbxRegID.Name = "cbxRegID";
            this.cbxRegID.Size = new System.Drawing.Size(353, 21);
            this.cbxRegID.TabIndex = 81;
            this.cbxRegID.Text = "selicione um id";
            // 
            // btnRegDelete
            // 
            this.btnRegDelete.Location = new System.Drawing.Point(225, 373);
            this.btnRegDelete.Name = "btnRegDelete";
            this.btnRegDelete.Size = new System.Drawing.Size(58, 49);
            this.btnRegDelete.TabIndex = 45;
            this.btnRegDelete.Text = "Excluir";
            this.btnRegDelete.UseVisualStyleBackColor = true;
            this.btnRegDelete.Click += new System.EventHandler(this.btnRegDelete_Click);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(72, 96);
            this.txtRegPassword.Multiline = true;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(352, 25);
            this.txtRegPassword.TabIndex = 40;
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(72, 63);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(352, 20);
            this.txtRegName.TabIndex = 34;
            // 
            // btnRegSave
            // 
            this.btnRegSave.Location = new System.Drawing.Point(289, 373);
            this.btnRegSave.Name = "btnRegSave";
            this.btnRegSave.Size = new System.Drawing.Size(64, 49);
            this.btnRegSave.TabIndex = 41;
            this.btnRegSave.Text = "Salvar";
            this.btnRegSave.UseVisualStyleBackColor = true;
            this.btnRegSave.Click += new System.EventHandler(this.btnRegSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Codigo";
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(161, 373);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(58, 49);
            this.btnRegCancel.TabIndex = 36;
            this.btnRegCancel.Text = "Cancelar";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // btnRegChange
            // 
            this.btnRegChange.Location = new System.Drawing.Point(94, 373);
            this.btnRegChange.Name = "btnRegChange";
            this.btnRegChange.Size = new System.Drawing.Size(61, 49);
            this.btnRegChange.TabIndex = 35;
            this.btnRegChange.Text = "Alterar";
            this.btnRegChange.UseVisualStyleBackColor = true;
            this.btnRegChange.Click += new System.EventHandler(this.btnRegChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome";
            // 
            // btnRegFinish
            // 
            this.btnRegFinish.Location = new System.Drawing.Point(361, 373);
            this.btnRegFinish.Name = "btnRegFinish";
            this.btnRegFinish.Size = new System.Drawing.Size(67, 49);
            this.btnRegFinish.TabIndex = 32;
            this.btnRegFinish.Text = "Sair";
            this.btnRegFinish.UseVisualStyleBackColor = true;
            this.btnRegFinish.Click += new System.EventHandler(this.btnRegFinish_Click);
            // 
            // btnRegInit
            // 
            this.btnRegInit.Location = new System.Drawing.Point(26, 373);
            this.btnRegInit.Name = "btnRegInit";
            this.btnRegInit.Size = new System.Drawing.Size(62, 49);
            this.btnRegInit.TabIndex = 31;
            this.btnRegInit.Text = "Iniciar";
            this.btnRegInit.UseVisualStyleBackColor = true;
            this.btnRegInit.Click += new System.EventHandler(this.btnRegInit_Click);
            // 
            // dtpRegDateAlteracao
            // 
            this.dtpRegDateAlteracao.CustomFormat = "dd-MM-yyyy h:m";
            this.dtpRegDateAlteracao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpRegDateAlteracao.Location = new System.Drawing.Point(29, 275);
            this.dtpRegDateAlteracao.Name = "dtpRegDateAlteracao";
            this.dtpRegDateAlteracao.Size = new System.Drawing.Size(395, 20);
            this.dtpRegDateAlteracao.TabIndex = 30;
            this.dtpRegDateAlteracao.Value = new System.DateTime(2021, 5, 16, 15, 0, 9, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data e hora";
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.lblNome);
            this.gbxUsers.Controls.Add(this.txtSecSearchUser);
            this.gbxUsers.Controls.Add(this.btnPesquisar);
            this.gbxUsers.Controls.Add(this.dgvUser);
            this.gbxUsers.Location = new System.Drawing.Point(502, 12);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(720, 516);
            this.gbxUsers.TabIndex = 50;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Usuários Cadastrados";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 406);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 49;
            this.lblNome.Text = "Nome";
            // 
            // txtSecSearchUser
            // 
            this.txtSecSearchUser.Location = new System.Drawing.Point(91, 403);
            this.txtSecSearchUser.Name = "txtSecSearchUser";
            this.txtSecSearchUser.Size = new System.Drawing.Size(376, 20);
            this.txtSecSearchUser.TabIndex = 48;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(498, 402);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(163, 20);
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(31, 45);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(630, 293);
            this.dgvUser.TabIndex = 46;
            // 
            // tbpSecUser
            // 
            this.tbpSecUser.Location = new System.Drawing.Point(4, 22);
            this.tbpSecUser.Name = "tbpSecUser";
            this.tbpSecUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecUser.Size = new System.Drawing.Size(1280, 659);
            this.tbpSecUser.TabIndex = 1;
            this.tbpSecUser.Text = "Cadastrados";
            this.tbpSecUser.UseVisualStyleBackColor = true;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tbcUser);
            this.Name = "FrmUser";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.tbcUser.ResumeLayout(false);
            this.tbpRegUser.ResumeLayout(false);
            this.gbxCadUsers.ResumeLayout(false);
            this.gbxCadUsers.PerformLayout();
            this.gbxUsers.ResumeLayout(false);
            this.gbxUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcUser;
        private System.Windows.Forms.TabPage tbpRegUser;
        private System.Windows.Forms.Button btnRegDelete;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Button btnRegSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Button btnRegChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegFinish;
        private System.Windows.Forms.Button btnRegInit;
        private System.Windows.Forms.DateTimePicker dtpRegDateAlteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbpSecUser;
        private System.Windows.Forms.GroupBox gbxCadUsers;
        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSecSearchUser;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.ComboBox cbxRegID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}