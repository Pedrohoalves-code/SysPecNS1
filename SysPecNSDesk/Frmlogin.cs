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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu Usuario esta inativo. \n Procure a Gerencia!!! ");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalidos, ou inexistente. \n Procute a Gerencia!!");
                    Application.Exit();
                }
            }

            else
            {
                MessageBox.Show("Vove deve preencher Email e Senha");
                txtEmail.Focus();
            }


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
