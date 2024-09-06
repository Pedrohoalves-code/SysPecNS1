namespace SysPecNSDesk
{
    partial class FrmProduto
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            npEstoqueMinimo = new NumericUpDown();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label9 = new Label();
            cmbCategoria = new ComboBox();
            label8 = new Label();
            txtUnidadedeVenda = new TextBox();
            label7 = new Label();
            txtValorUnitario = new TextBox();
            label6 = new Label();
            txtDesconto = new TextBox();
            label5 = new Label();
            txtDescrição = new TextBox();
            label4 = new Label();
            txtCodigodeBarras = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigodeBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnitario = new DataGridViewTextBoxColumn();
            clnUnidadedeVenda = new DataGridViewTextBoxColumn();
            clnCategori = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDatadeCadastro = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 33);
            label1.TabIndex = 0;
            label1.Text = "PRODUTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(npEstoqueMinimo);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtUnidadedeVenda);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDescrição);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCodigodeBarras);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 242);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(531, 101);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(44, 23);
            npEstoqueMinimo.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(390, 210);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(299, 210);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(208, 210);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 139);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 15;
            label9.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(291, 158);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(313, 23);
            cmbCategoria.TabIndex = 6;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(517, 83);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 13;
            label8.Text = "Estoque Minimo";
            // 
            // txtUnidadedeVenda
            // 
            txtUnidadedeVenda.ForeColor = SystemColors.ScrollBar;
            txtUnidadedeVenda.Location = new Point(382, 101);
            txtUnidadedeVenda.Name = "txtUnidadedeVenda";
            txtUnidadedeVenda.Size = new Size(116, 23);
            txtUnidadedeVenda.TabIndex = 3;
            txtUnidadedeVenda.Text = "Ex: Caixa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 83);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 10;
            label7.Text = "Unidade de venda";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(208, 101);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(116, 23);
            txtValorUnitario.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 83);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 8;
            label6.Text = "Valor unitario";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(27, 210);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(97, 23);
            txtDesconto.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 192);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Desconto";
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(27, 157);
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(158, 23);
            txtDescrição.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 139);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Descrição";
            label4.Click += label4_Click;
            // 
            // txtCodigodeBarras
            // 
            txtCodigodeBarras.Location = new Point(27, 101);
            txtCodigodeBarras.Name = "txtCodigodeBarras";
            txtCodigodeBarras.Size = new Size(123, 23);
            txtCodigodeBarras.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 83);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Codigo de barras";
            // 
            // txtId
            // 
            txtId.Location = new Point(27, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(43, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 25);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigodeBarras, clnDescricao, clnValorUnitario, clnUnidadedeVenda, clnCategori, clnEstoqueMinimo, clnDesconto, clnDatadeCadastro });
            dgvProdutos.Location = new Point(13, 293);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(775, 155);
            dgvProdutos.TabIndex = 0;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodigodeBarras
            // 
            clnCodigodeBarras.Frozen = true;
            clnCodigodeBarras.HeaderText = "Codigo de barras";
            clnCodigodeBarras.Name = "clnCodigodeBarras";
            clnCodigodeBarras.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnitario
            // 
            clnValorUnitario.Frozen = true;
            clnValorUnitario.HeaderText = "Valor Unitario";
            clnValorUnitario.Name = "clnValorUnitario";
            clnValorUnitario.ReadOnly = true;
            // 
            // clnUnidadedeVenda
            // 
            clnUnidadedeVenda.Frozen = true;
            clnUnidadedeVenda.HeaderText = "Unidade de Venda";
            clnUnidadedeVenda.Name = "clnUnidadedeVenda";
            clnUnidadedeVenda.ReadOnly = true;
            // 
            // clnCategori
            // 
            clnCategori.Frozen = true;
            clnCategori.HeaderText = "Categoria";
            clnCategori.Name = "clnCategori";
            clnCategori.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.Frozen = true;
            clnEstoqueMinimo.HeaderText = "Estoque Minimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDatadeCadastro
            // 
            clnDatadeCadastro.Frozen = true;
            clnDatadeCadastro.HeaderText = "Data de Cadastro";
            clnDatadeCadastro.Name = "clnDatadeCadastro";
            clnDatadeCadastro.ReadOnly = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgvProdutos;
        private Label label4;
        private TextBox txtCodigodeBarras;
        private Label label3;
        private Label label6;
        private TextBox txtDesconto;
        private Label label5;
        private TextBox txtDescrição;
        private Label label9;
        private ComboBox cmbCategoria;
        private Label label8;
        private TextBox txtUnidadedeVenda;
        private Label label7;
        private TextBox txtValorUnitario;
        private Button btnAdicionar;
        private Button btnConsultar;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigodeBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadedeVenda;
        private DataGridViewTextBoxColumn clnCategori;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDatadeCadastro;
        private NumericUpDown npEstoqueMinimo;
    }
}