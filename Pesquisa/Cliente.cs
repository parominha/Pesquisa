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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butPesquisa_Click(object sender, EventArgs e)
        {
            Cliente Metodo_Cliente = new Cliente();
            DataSet DataSetResultadoPesquisa = new DataSet();

            DataSetResultadoPesquisa = Metodo_Cliente.Lista_Cliente(tBoxPesquisa.Text);
            dgCliente.DataSource = DataSetResultadoPesquisa.Tables[0];

            dgCliente.Refresh();
        }
      
    }
}
