﻿
namespace CalledManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.tbcUser = new System.Windows.Forms.TabControl();
            this.tbpRegUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegLogin = new System.Windows.Forms.TextBox();
            this.btnRegDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRegDateTime = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegDescripition = new System.Windows.Forms.TextBox();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.btnRegSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.btnRegChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegFinish = new System.Windows.Forms.Button();
            this.btnRegInit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpSecUser = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbcUser.SuspendLayout();
            this.tbpRegUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcUser
            // 
            this.tbcUser.Controls.Add(this.tbpRegUser);
            this.tbcUser.Controls.Add(this.tbpSecUser);
            this.tbcUser.Location = new System.Drawing.Point(12, 12);
            this.tbcUser.Name = "tbcUser";
            this.tbcUser.SelectedIndex = 0;
            this.tbcUser.Size = new System.Drawing.Size(807, 457);
            this.tbcUser.TabIndex = 0;
            // 
            // tbpRegUser
            // 
            this.tbpRegUser.Controls.Add(this.comboBox1);
            this.tbpRegUser.Controls.Add(this.label2);
            this.tbpRegUser.Controls.Add(this.label1);
            this.tbpRegUser.Controls.Add(this.txtRegLogin);
            this.tbpRegUser.Controls.Add(this.btnRegDelete);
            this.tbpRegUser.Controls.Add(this.groupBox1);
            this.tbpRegUser.Controls.Add(this.txtRegPassword);
            this.tbpRegUser.Controls.Add(this.txtRegDescripition);
            this.tbpRegUser.Controls.Add(this.txtRegID);
            this.tbpRegUser.Controls.Add(this.txtRegName);
            this.tbpRegUser.Controls.Add(this.btnRegSave);
            this.tbpRegUser.Controls.Add(this.label8);
            this.tbpRegUser.Controls.Add(this.label7);
            this.tbpRegUser.Controls.Add(this.btnRegCancel);
            this.tbpRegUser.Controls.Add(this.btnRegChange);
            this.tbpRegUser.Controls.Add(this.label5);
            this.tbpRegUser.Controls.Add(this.btnRegFinish);
            this.tbpRegUser.Controls.Add(this.btnRegInit);
            this.tbpRegUser.Controls.Add(this.label6);
            this.tbpRegUser.Location = new System.Drawing.Point(4, 22);
            this.tbpRegUser.Name = "tbpRegUser";
            this.tbpRegUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegUser.Size = new System.Drawing.Size(799, 431);
            this.tbpRegUser.TabIndex = 0;
            this.tbpRegUser.Text = "Cadastrar";
            this.tbpRegUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Senha";
            // 
            // txtRegLogin
            // 
            this.txtRegLogin.Location = new System.Drawing.Point(81, 106);
            this.txtRegLogin.Name = "txtRegLogin";
            this.txtRegLogin.Size = new System.Drawing.Size(354, 20);
            this.txtRegLogin.TabIndex = 46;
            // 
            // btnRegDelete
            // 
            this.btnRegDelete.Location = new System.Drawing.Point(286, 343);
            this.btnRegDelete.Name = "btnRegDelete";
            this.btnRegDelete.Size = new System.Drawing.Size(58, 49);
            this.btnRegDelete.TabIndex = 45;
            this.btnRegDelete.Text = "Excluir";
            this.btnRegDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbRegDateTime);
            this.groupBox1.Location = new System.Drawing.Point(539, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 251);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrados";
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
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(81, 137);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(354, 20);
            this.txtRegPassword.TabIndex = 43;
            // 
            // txtRegDescripition
            // 
            this.txtRegDescripition.Location = new System.Drawing.Point(40, 246);
            this.txtRegDescripition.Multiline = true;
            this.txtRegDescripition.Name = "txtRegDescripition";
            this.txtRegDescripition.Size = new System.Drawing.Size(395, 57);
            this.txtRegDescripition.TabIndex = 40;
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(81, 39);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(354, 20);
            this.txtRegID.TabIndex = 38;
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(81, 76);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(354, 20);
            this.txtRegName.TabIndex = 34;
            // 
            // btnRegSave
            // 
            this.btnRegSave.Location = new System.Drawing.Point(367, 343);
            this.btnRegSave.Name = "btnRegSave";
            this.btnRegSave.Size = new System.Drawing.Size(64, 49);
            this.btnRegSave.TabIndex = 41;
            this.btnRegSave.Text = "Salvar";
            this.btnRegSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Codigo";
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(203, 343);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(58, 49);
            this.btnRegCancel.TabIndex = 36;
            this.btnRegCancel.Text = "Cancelar";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegChange
            // 
            this.btnRegChange.Location = new System.Drawing.Point(124, 343);
            this.btnRegChange.Name = "btnRegChange";
            this.btnRegChange.Size = new System.Drawing.Size(61, 49);
            this.btnRegChange.TabIndex = 35;
            this.btnRegChange.Text = "Alterar";
            this.btnRegChange.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome";
            // 
            // btnRegFinish
            // 
            this.btnRegFinish.Location = new System.Drawing.Point(539, 343);
            this.btnRegFinish.Name = "btnRegFinish";
            this.btnRegFinish.Size = new System.Drawing.Size(208, 49);
            this.btnRegFinish.TabIndex = 32;
            this.btnRegFinish.Text = "Sair";
            this.btnRegFinish.UseVisualStyleBackColor = true;
            this.btnRegFinish.Click += new System.EventHandler(this.btnRegFinish_Click_1);
            // 
            // btnRegInit
            // 
            this.btnRegInit.Location = new System.Drawing.Point(40, 343);
            this.btnRegInit.Name = "btnRegInit";
            this.btnRegInit.Size = new System.Drawing.Size(62, 49);
            this.btnRegInit.TabIndex = 31;
            this.btnRegInit.Text = "Iniciar";
            this.btnRegInit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Login";
            // 
            // tbpSecUser
            // 
            this.tbpSecUser.Location = new System.Drawing.Point(4, 22);
            this.tbpSecUser.Name = "tbpSecUser";
            this.tbpSecUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecUser.Size = new System.Drawing.Size(799, 431);
            this.tbpSecUser.TabIndex = 1;
            this.tbpSecUser.Text = "Cadastrados";
            this.tbpSecUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Grupo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "normal"});
            this.comboBox1.Location = new System.Drawing.Point(79, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.Text = "Selecione um grupo";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.tbcUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.Text = "Usuário";
            this.tbcUser.ResumeLayout(false);
            this.tbpRegUser.ResumeLayout(false);
            this.tbpRegUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcUser;
        private System.Windows.Forms.TabPage tbpRegUser;
        private System.Windows.Forms.TabPage tbpSecUser;
        private System.Windows.Forms.Button btnRegDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRegDateTime;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Button btnRegSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Button btnRegChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegFinish;
        private System.Windows.Forms.Button btnRegInit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegLogin;
        private System.Windows.Forms.TextBox txtRegDescripition;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}