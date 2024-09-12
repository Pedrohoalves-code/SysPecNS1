﻿using SysPecNSLib;
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
    public partial class FrmPedidoNovo : Form
    {
        public int ClienteId;

        public string NomeCliente;

        Produto produto;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true;
            grbIntendificao.Enabled = false;
            txtCodBar.Focus();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + "-" + Program.UsuarioLogado.Nome;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            item.Inserir();
            produto = new();
            txtDescontoItem.Text = "";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuantidade.Text = "1";
            txtCodBar.Clear();
            txtCodBar.Focus();

            PreencherGridItens();

        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double desconto = 0;
            double total = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade.ToString("#0.000");
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");
                linha++;
                total += item.ValorUnit * item.Quantidade - item.Desconto;
                desconto += item.Desconto;
            }
            txtTotal.Text = total.ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");
            //txtDescontoItens.Text = (desconto / );
            txtSubTotal.Text = (total + desconto).ToString("#0.00");
            txtTotal.Text = total.ToString("#0.00");

            txtTotal1.Text = (desconto + total).ToString();
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                if (produto.ClasseDesconto == 0)
                {
                    txtDescontoItens.Enabled = false;
                }
                else
                {
                    txtDescontoItens.Enabled = true;
                    label15.Text = "R$" + (produto.ValorUnit * produto.ClasseDesconto).ToString("#0.00");

                }
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbItens_Enter(object sender, EventArgs e)
        {

        }

        private void grbIntendificao_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Nome;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmBuscaCliente frmBuscaCliente = new();
            frmBuscaCliente.ShowDialog();

            ClienteId = frmBuscaCliente.ClienteId;

            //Associa o valor da propriedade da tabela de busca a variavel NomeCliente
            NomeCliente = frmBuscaCliente.NomeCliente;

            //Preenche os campos com as respectivas informações do cliente
            txtIdCliente.Text = ClienteId.ToString();
            txtCliente.Text = NomeCliente;
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoPedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
