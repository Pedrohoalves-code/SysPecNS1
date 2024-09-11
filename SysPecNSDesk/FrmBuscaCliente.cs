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
    public partial class FrmBuscaCliente : Form
    {
        public int ClienteId;
        public string NomeCliente;
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            //Obtem lista de clientes
            var lista = Cliente.ObterLista(nome);

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvClientes.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            foreach (var cliente in lista)
            {
                //Adiciona uma nova linha a tabela
                dgvClientes.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[cont].Cells[5].Value = cliente.Data_Nasc;
                dgvClientes.Rows[cont].Cells[6].Value = cliente.Ativo;

                //Soma +1 ao contador de cliente
                cont++;


            }

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            //Identifica a linha atual(que foi clicada)
            int posicaoLinha = dgvClientes.CurrentRow.Index;

            //Atribui o valor da celula 0 da linha atual(id)
            id = Convert.ToInt32(dgvClientes.Rows[posicaoLinha].Cells[0].Value);
            //string nome = dgvClientes.Rows[posicaoLinha].Cells[1].Value.ToString();

            //Busca o cliente com o ID da linha selecionada
            Cliente cliente = Cliente.ObterPorId(id);

            //Associa o ID do cliente encontrado a propriedade ClienteId
            ClienteId = cliente.Id;

            //Associa o Nome do cliente encontrado a propriedade NomeCliente
            NomeCliente = cliente.Nome;


            Close();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
           
 
        }
    }
}
