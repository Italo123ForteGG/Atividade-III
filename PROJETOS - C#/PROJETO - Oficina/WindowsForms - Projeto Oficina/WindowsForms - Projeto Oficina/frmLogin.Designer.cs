namespace WindowsForms___Projeto_Oficina
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelSup = new System.Windows.Forms.Panel();
            this.panelInf = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnLogar = new System.Windows.Forms.Button();
            this.panelLogar = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblESenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Enabled = false;
            this.picLogo.Location = new System.Drawing.Point(91, 32);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(136, 117);
            this.picLogo.TabIndex = 25;
            this.picLogo.TabStop = false;
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSup.Enabled = false;
            this.panelSup.Location = new System.Drawing.Point(113, 32);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(96, 1);
            this.panelSup.TabIndex = 26;
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelInf.Enabled = false;
            this.panelInf.Location = new System.Drawing.Point(113, 148);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(96, 1);
            this.panelInf.TabIndex = 27;
            // 
            // panelSenha
            // 
            this.panelSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelSenha.Enabled = false;
            this.panelSenha.Location = new System.Drawing.Point(55, 270);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(209, 1);
            this.panelSenha.TabIndex = 36;
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelUsuario.Enabled = false;
            this.panelUsuario.Location = new System.Drawing.Point(55, 226);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(209, 1);
            this.panelUsuario.TabIndex = 35;
            // 
            // btnLogar
            // 
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Georgia", 10F);
            this.btnLogar.ForeColor = System.Drawing.Color.Red;
            this.btnLogar.Location = new System.Drawing.Point(55, 316);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(209, 31);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            this.btnLogar.MouseEnter += new System.EventHandler(this.btnLogar_MouseEnter);
            this.btnLogar.MouseLeave += new System.EventHandler(this.btnLogar_MouseLeave);
            // 
            // panelLogar
            // 
            this.panelLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogar.Enabled = false;
            this.panelLogar.Location = new System.Drawing.Point(55, 348);
            this.panelLogar.Name = "panelLogar";
            this.panelLogar.Size = new System.Drawing.Size(209, 1);
            this.panelLogar.TabIndex = 38;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(55, 204);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(209, 16);
            this.txtUsuario.TabIndex = 39;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter_1);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave_1);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(55, 245);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(209, 16);
            this.txtSenha.TabIndex = 40;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter_1);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave_1);
            // 
            // lblESenha
            // 
            this.lblESenha.AutoSize = true;
            this.lblESenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblESenha.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblESenha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblESenha.Location = new System.Drawing.Point(90, 360);
            this.lblESenha.Name = "lblESenha";
            this.lblESenha.Size = new System.Drawing.Size(135, 14);
            this.lblESenha.TabIndex = 4;
            this.lblESenha.Text = "Esqueceu a sua senha?";
            this.lblESenha.MouseEnter += new System.EventHandler(this.lblESenha_MouseEnter);
            this.lblESenha.MouseLeave += new System.EventHandler(this.lblESenha_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 442);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblESenha);
            this.Controls.Add(this.panelLogar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.panelSenha);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Panel panelLogar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblESenha;
    }
}

