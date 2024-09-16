namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            gpEstoque = new GroupBox();
            label7 = new Label();
            txtEntradaEstoque = new TextBox();
            btnInserir = new Button();
            label6 = new Label();
            txtDisponivelEstoque = new TextBox();
            label5 = new Label();
            txtEstoqueMinimo = new TextBox();
            label4 = new Label();
            txtUnidadedeVenda = new TextBox();
            label3 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtCodBarras = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
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
            gpEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gpEstoque
            // 
            gpEstoque.Controls.Add(label7);
            gpEstoque.Controls.Add(txtEntradaEstoque);
            gpEstoque.Controls.Add(btnInserir);
            gpEstoque.Controls.Add(label6);
            gpEstoque.Controls.Add(txtDisponivelEstoque);
            gpEstoque.Controls.Add(label5);
            gpEstoque.Controls.Add(txtEstoqueMinimo);
            gpEstoque.Controls.Add(label4);
            gpEstoque.Controls.Add(txtUnidadedeVenda);
            gpEstoque.Controls.Add(label3);
            gpEstoque.Controls.Add(txtDescricao);
            gpEstoque.Controls.Add(label2);
            gpEstoque.Controls.Add(txtCodBarras);
            gpEstoque.Controls.Add(label1);
            gpEstoque.Controls.Add(txtId);
            gpEstoque.Location = new Point(0, 2);
            gpEstoque.Name = "gpEstoque";
            gpEstoque.Size = new Size(712, 205);
            gpEstoque.TabIndex = 1;
            gpEstoque.TabStop = false;
            gpEstoque.Text = "Adicionar Poduto Estoque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 146);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 14;
            label7.Text = "Entrada";
            // 
            // txtEntradaEstoque
            // 
            txtEntradaEstoque.Location = new Point(247, 164);
            txtEntradaEstoque.Name = "txtEntradaEstoque";
            txtEntradaEstoque.Size = new Size(181, 23);
            txtEntradaEstoque.TabIndex = 13;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(487, 157);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(139, 34);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 146);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 11;
            label6.Text = "Disponivel em estoque";
            // 
            // txtDisponivelEstoque
            // 
            txtDisponivelEstoque.Location = new Point(6, 164);
            txtDisponivelEstoque.Name = "txtDisponivelEstoque";
            txtDisponivelEstoque.Size = new Size(181, 23);
            txtDisponivelEstoque.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 94);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Estoque Minimo";
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(497, 112);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(181, 23);
            txtEstoqueMinimo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 94);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Unidade de Venda";
            // 
            // txtUnidadedeVenda
            // 
            txtUnidadedeVenda.Location = new Point(247, 112);
            txtUnidadedeVenda.Name = "txtUnidadedeVenda";
            txtUnidadedeVenda.Size = new Size(224, 23);
            txtUnidadedeVenda.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição Produto";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(6, 112);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(224, 23);
            txtDescricao.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 31);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo de Barras";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(165, 49);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigodeBarras, clnDescricao, clnValorUnitario, clnUnidadedeVenda, clnCategori, clnEstoqueMinimo, clnDesconto, clnDatadeCadastro });
            dgvProdutos.Location = new Point(0, 213);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(904, 236);
            dgvProdutos.TabIndex = 2;
            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;
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
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(gpEstoque);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            Load += FrmEstoque_Load;
            gpEstoque.ResumeLayout(false);
            gpEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gpEstoque;
        private Label label4;
        private TextBox txtUnidadedeVenda;
        private Label label3;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtCodBarras;
        private Label label1;
        private TextBox txtId;
        private Button btnInserir;
        private Label label6;
        private TextBox txtDisponivelEstoque;
        private Label label5;
        private TextBox txtEstoqueMinimo;
        private Label label7;
        private TextBox txtEntradaEstoque;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigodeBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadedeVenda;
        private DataGridViewTextBoxColumn clnCategori;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDatadeCadastro;
    }
}