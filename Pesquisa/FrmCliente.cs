using Pesquisa.dao.cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesquisa
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        Cliente Metodo_Cliente = new Cliente();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisar(tBoxPesquisa.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MontaTela(int p_parametro, string botao)
        {
            butIncluir.Enabled = false;
            butAlterar.Enabled = false;
            butExcluir.Enabled = false;


            if (p_parametro == 0)
            {
                grBoxDados.Visible = true;
                butNovo.Visible = false;
                tBoxNome.Focus();
            }

            else
            {
                grBoxDados.Visible = false;
                butNovo.Visible = true;
                tBoxPesquisa.Focus();
            }

            switch (botao)
            {
                case "INCLUIR":
                    butIncluir.Enabled = true;
                    tBoxNome.Focus();
                    break;
                case "ALTERAR":
                    butAlterar.Enabled = true;
                    tBoxNome.Focus();
                    break;
                case "EXCLUIR":
                    butExcluir.Enabled = true;
                    tBoxNome.Focus();
                    break;
                default:
                    butIncluir.Enabled = false;
                    butAlterar.Enabled = false;
                    butExcluir.Enabled = false;
                    break;
            }
        }

        private void Pesquisar(string pesquisar)
        {
            DataSet DataSetResultadoPesquisa = new DataSet();

            DataSetResultadoPesquisa = Metodo_Cliente.Lista_Cliente(tBoxPesquisa.Text);
            dgCliente.DataSource = DataSetResultadoPesquisa.Tables[0];

            dgCliente.Refresh();
        }

        private void butNovo_Click(object sender, EventArgs e)
        {
            MontaTela(0, "INCLUIR");
        }

        private void butIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Metodo_Cliente.Incluir(tBoxNome.Text, tBoxContato.Text, tBoxEndereco.Text, int.Parse(tBoxCredito.Text));
                tBoxPesquisa.Text = tBoxNome.Text;
                MessageBox.Show("Cadastrado com sucesso!");

                grBoxDados.Visible = false;
                butNovo.Visible = true;

                Pesquisar(tBoxPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void dgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MontaTela(0, "ALTERAR");
            DataGridViewRow row = this.dgCliente.SelectedRows[0];
            tBoxNome.Text = row.Cells["Name"].Value.ToString();
        }
    }
}
