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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            listarProduto();
        }

        private void listarProduto()
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
                };
                dtgProduto.DataSource = dt.ToList();
        }
    }
}
