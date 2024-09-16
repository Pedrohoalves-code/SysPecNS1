using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.DatCad;

                cont++;

            }

        }




        private void btnInserir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            double entrada = double.Parse(txtDisponivelEstoque.Text);
            entrada += double.Parse(txtEntradaEstoque.Text);
            string estqMin = txtEstoqueMinimo.Text;
            double estqDisponivel = double.Parse(txtDisponivelEstoque.Text);
            string qtdeEstoqueMin = estqMin.Substring(0, 3);
            double estoqueMin = double.Parse(qtdeEstoqueMin);

            if (entrada < estoqueMin && estqDisponivel < estoqueMin)
            {
                MessageBox.Show($"É necessário inserir no mínimo {txtEstoqueMinimo.Text} desse produto no estoque.");
            }
            else
            {

                Estoque estoque = new(
                    Produto.ObterPorId(id),
                    entrada,
                    DateTime.Now
                    );

                estoque.Atualizar(id, entrada);


                MessageBox.Show($"O produto {txtDescricao.Text} foi inserido no estoque, agora com {estoque.Quantidade} {txtUnidadedeVenda.Text}s disponíveis para compra!");
                txtId.Clear();
                txtCodBarras.Clear();
                txtDescricao.Clear();
                txtUnidadedeVenda.Clear();
                txtEstoqueMinimo.Clear();
                txtDisponivelEstoque.Clear();
                txtEntradaEstoque.Clear();

                FrmEstoque_Load(sender, e);

            }


        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {

            int id = 0;
            
            int posicaoLinha = dgvProdutos.CurrentRow.Index;

            //Atribui o valor da celula 0 da linha atual(id)
            id = Convert.ToInt32(dgvProdutos.Rows[posicaoLinha].Cells[0].Value);

            txtEntradaEstoque.Clear();
            //Ativa os campos de entrada no estoque
            gpEstoque.Enabled = true;

            Produto produto = Produto.ObterPorId(id);


            txtId.Text = produto.Id.ToString();
            txtCodBarras.Text = produto.CodBar;
            txtDescricao.Text = produto.Descricao;
            txtUnidadedeVenda.Text = produto.UnidadeVenda;
            txtEstoqueMinimo.Text = produto.EstoqueMinimo.ToString() + $" {produto.UnidadeVenda}s";

            Estoque estoque = Estoque.ObterPorProduto(id);
            txtDisponivelEstoque.Text = estoque.Quantidade.ToString();
        }
    }
}
