﻿namespace SysPecNSDesk
{
    partial class FrmCliente
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            dtpDataNasc = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInserir = new Button();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnEditar = new Button();
            txtBusca = new TextBox();
            label7 = new Label();
            btnDeletar = new Button();
            btnCadastrarEnd = new Button();
            groupBox1 = new GroupBox();
            tabCliente = new TabControl();
            tabPageDadosCliente = new TabPage();
            tabPageEnderecos = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            tabCliente.SuspendLayout();
            tabPageDadosCliente.SuspendLayout();
            tabPageEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(457, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(578, 93);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(166, 23);
            txtCpf.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(420, 147);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 23);
            txtEmail.TabIndex = 4;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(78, 205);
            dtpDataNasc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(135, 23);
            dtpDataNasc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 75);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 75);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 129);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 129);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 187);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(258, 207);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(115, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnAtivo });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.Location = new Point(78, 286);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(666, 286);
            dgvClientes.TabIndex = 14;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 160;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 110;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 120;
            // 
            // clnDataNasc
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            clnDataNasc.DefaultCellStyle = dataGridViewCellStyle3;
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 90;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 45;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(632, 207);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(78, 257);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(666, 23);
            txtBusca.TabIndex = 16;
            txtBusca.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 239);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 17;
            label7.Text = "Buscar Cliente";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(632, 589);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(112, 23);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarEnd
            // 
            btnCadastrarEnd.Enabled = false;
            btnCadastrarEnd.Location = new Point(429, 207);
            btnCadastrarEnd.Name = "btnCadastrarEnd";
            btnCadastrarEnd.Size = new Size(145, 23);
            btnCadastrarEnd.TabIndex = 19;
            btnCadastrarEnd.Text = "Cadastrar endereço";
            btnCadastrarEnd.UseVisualStyleBackColor = true;
            btnCadastrarEnd.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabCliente);
            groupBox1.Location = new Point(333, 371);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 154);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPageDadosCliente);
            tabCliente.Controls.Add(tabPageEnderecos);
            tabCliente.Location = new Point(22, 31);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(200, 100);
            tabCliente.TabIndex = 0;
            // 
            // tabPageDadosCliente
            // 
            tabPageDadosCliente.Controls.Add(button1);
            tabPageDadosCliente.Location = new Point(4, 24);
            tabPageDadosCliente.Name = "tabPageDadosCliente";
            tabPageDadosCliente.Padding = new Padding(3);
            tabPageDadosCliente.Size = new Size(192, 72);
            tabPageDadosCliente.TabIndex = 0;
            tabPageDadosCliente.Text = "Dados do Cliente";
            tabPageDadosCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageEnderecos
            // 
            tabPageEnderecos.Controls.Add(dataGridView1);
            tabPageEnderecos.Location = new Point(4, 24);
            tabPageEnderecos.Name = "tabPageEnderecos";
            tabPageEnderecos.Padding = new Padding(3);
            tabPageEnderecos.Size = new Size(192, 72);
            tabPageEnderecos.TabIndex = 1;
            tabPageEnderecos.Text = "Endereços";
            tabPageEnderecos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(57, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(66, 38);
            dataGridView1.TabIndex = 0;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 678);
            Controls.Add(groupBox1);
            Controls.Add(btnCadastrarEnd);
            Controls.Add(btnDeletar);
            Controls.Add(label7);
            Controls.Add(txtBusca);
            Controls.Add(btnEditar);
            Controls.Add(dgvClientes);
            Controls.Add(btnInserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDataNasc);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmCliente";
            Text = "Cadastro de Cliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            tabPageDadosCliente.ResumeLayout(false);
            tabPageEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private DateTimePicker dtpDataNasc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInserir;
        private DataGridView dgvClientes;
        private Button btnEditar;
        private TextBox txtBusca;
        private Label label7;
        private Button btnDeletar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btnCadastrarEnd;
        private GroupBox groupBox1;
        private TabControl tabCliente;
        private TabPage tabPageDadosCliente;
        private TabPage tabPageEnderecos;
        private Button button1;
        private DataGridView dataGridView1;
    }
}