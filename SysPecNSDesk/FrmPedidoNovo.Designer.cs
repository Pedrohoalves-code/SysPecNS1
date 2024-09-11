namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIntendificao = new GroupBox();
            btnInserePedido = new Button();
            txtCliente = new TextBox();
            txtIdCliente = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtIdPedido = new TextBox();
            grbItens = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtTotal1 = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            Btnfechar = new Button();
            btnAddItem = new Button();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            dgvItensPedido = new DataGridView();
            clnSeg = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            btnCliente = new Button();
            grbIntendificao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIntendificao
            // 
            grbIntendificao.Controls.Add(btnCliente);
            grbIntendificao.Controls.Add(btnInserePedido);
            grbIntendificao.Controls.Add(txtCliente);
            grbIntendificao.Controls.Add(txtIdCliente);
            grbIntendificao.Controls.Add(txtUsuario);
            grbIntendificao.Controls.Add(label1);
            grbIntendificao.Location = new Point(36, 76);
            grbIntendificao.Name = "grbIntendificao";
            grbIntendificao.Size = new Size(390, 140);
            grbIntendificao.TabIndex = 0;
            grbIntendificao.TabStop = false;
            grbIntendificao.Text = "Indentificação";
            grbIntendificao.Enter += grbIntendificao_Enter;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(304, 96);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 38);
            btnInserePedido.TabIndex = 2;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(163, 67);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(189, 23);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(83, 67);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(59, 23);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(123, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(218, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtIdPedido
            // 
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(606, 38);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(105, 23);
            txtIdPedido.TabIndex = 1;
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label15);
            grbItens.Controls.Add(label14);
            grbItens.Controls.Add(label13);
            grbItens.Controls.Add(label12);
            grbItens.Controls.Add(label11);
            grbItens.Controls.Add(txtTotal1);
            grbItens.Controls.Add(txtDescontoPedido);
            grbItens.Controls.Add(txtDescontoItens);
            grbItens.Controls.Add(txtSubTotal);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(Btnfechar);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(38, 222);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(807, 293);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Item do Pedido";
            grbItens.Enter += grbItens_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Snow;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(727, 46);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 22;
            label15.Text = "R$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(688, 205);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 21;
            label14.Text = "Total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(688, 163);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 20;
            label13.Text = "Desconto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(688, 121);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 19;
            label12.Text = "Desconto Itens";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(688, 79);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 18;
            label11.Text = "Sub Total";
            // 
            // txtTotal1
            // 
            txtTotal1.Location = new Point(688, 222);
            txtTotal1.Name = "txtTotal1";
            txtTotal1.ReadOnly = true;
            txtTotal1.Size = new Size(100, 23);
            txtTotal1.TabIndex = 17;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(688, 180);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 16;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(688, 138);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 15;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(688, 96);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(519, 252);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(432, 255);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 26);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 26);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 10;
            label8.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 26);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 30);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 30);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Codigo de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(480, 46);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(82, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextChanged += textBox5_TextChanged;
            // 
            // Btnfechar
            // 
            Btnfechar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btnfechar.Location = new Point(688, 247);
            Btnfechar.Name = "Btnfechar";
            Btnfechar.Size = new Size(75, 35);
            Btnfechar.TabIndex = 6;
            Btnfechar.Text = "&Fechar";
            Btnfechar.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(568, 41);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(105, 31);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "&A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(394, 46);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(80, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(316, 46);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(72, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(17, 46);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(123, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(187, 23);
            txtDescricao.TabIndex = 1;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeg, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(15, 75);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(620, 150);
            dgvItensPedido.TabIndex = 0;
            dgvItensPedido.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnSeg
            // 
            clnSeg.Frozen = true;
            clnSeg.HeaderText = "#SEQ";
            clnSeg.Name = "clnSeg";
            clnSeg.ReadOnly = true;
            clnSeg.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(500, 34);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 3;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(226, 23);
            label4.Name = "label4";
            label4.Size = new Size(151, 27);
            label4.TabIndex = 4;
            label4.Text = "Novo Pedido";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(6, 60);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(71, 35);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 585);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(grbItens);
            Controls.Add(txtIdPedido);
            Controls.Add(grbIntendificao);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIntendificao.ResumeLayout(false);
            grbIntendificao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIntendificao;
        private Button btnInserePedido;
        private TextBox txtCliente;
        private TextBox txtIdCliente;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtIdPedido;
        private GroupBox grbItens;
        private Label label3;
        private Label label4;
        private DataGridView dgvItensPedido;
        private Button btnAddItem;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTotal;
        private Label label10;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private TextBox txtSubTotal;
        private Button Btnfechar;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtTotal1;
        private DataGridViewTextBoxColumn clnSeg;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Label label15;
        private Button btnCliente;
    }
}