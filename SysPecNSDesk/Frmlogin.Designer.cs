namespace SysPecNSDesk
{
    partial class Frmlogin
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
            btnCancelar = new Button();
            btnLogar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(89, 196);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "&Entrar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 96);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 140);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "pedro.henrique@gmail.com";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(89, 158);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(163, 23);
            txtSenha.TabIndex = 6;
            txtSenha.Text = "123456";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 37);
            label3.Name = "label3";
            label3.Size = new Size(209, 25);
            label3.TabIndex = 7;
            label3.Text = "Area de Login SysPec";
            // 
            // Frmlogin
            // 
            AcceptButton = btnLogar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            CancelButton = btnCancelar;
            ClientSize = new Size(333, 266);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Controls.Add(btnCancelar);
            Name = "Frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnLogar;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label3;
    }
}