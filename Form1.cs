using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente clientes = new frmCliente();
            clientes.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.ShowDialog();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPedidoFor_Click(object sender, EventArgs e)
        {
            frmPedidoFornecedor pedidoFor = new frmPedidoFornecedor();
            pedidoFor.Show();
        }
    }
}
