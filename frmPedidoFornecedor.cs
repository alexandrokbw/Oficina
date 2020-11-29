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
    public partial class frmPedidoFornecedor : Form
    {
        public frmPedidoFornecedor()
        {
            InitializeComponent();
        }

        private void frmPedidoFornecedor_Load(object sender, EventArgs e)
        {
            listarPedidoAguardando();
        }

        private void listarPedidoAguardando()
        {
            DatabaseEntities dataBase = new DatabaseEntities();
            var dt = from Fornecedor in dataBase.tbFornecedor
                     join Produto in dataBase.tbProduto
                     on Fornecedor.idFornecedor equals Produto.idFornecedor
                     select new
                     {
                         Fornecedor.idFornecedor,
                         Fornecedor.nome,
                         Produto.idProduto,
                         Produto.codigo,
                         Produto.descricao,
                         Produto.precoCusto,
                         Produto.precoVenda,
                         Produto.estoque,
                         Produto.estoqueMinimo,
                         Produto.tipo,
                     };
            dtgProduto.DataSource = dt.ToList();
        }
    }
}
