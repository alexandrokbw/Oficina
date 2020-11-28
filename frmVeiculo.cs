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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        public int idCliente;
        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = idCliente.ToString();
           listarVeiculo();
        }
        private void listarVeiculo()
        {
            DatabaseEntities dataBase = new DatabaseEntities();
            var dt = from tbL in dataBase.tbVeiculo
                     where tbL.idCliente == idCliente
                     select new
                     {
                         tbL.idVeiculo,
                         tbL.modelo,
                         tbL.marca,
                         tbL.placa,
                         tbL.cor,
                     };
            dtgVeiculo.DataSource = dt.ToList();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var context = new DatabaseEntities();
            if (txtCodigoVeiculo.Text == "")
            {

                var veiculo = new tbVeiculo()
                {
                    idCliente = Convert.ToInt32(txtCodigoCliente.Text),
                    modelo = txtModelo.Text,
                    marca = txtFabricante.Text,
                    placa = txtPlaca.Text,
                    cor = txtCor.Text,
                };
                context.tbVeiculo.Add(veiculo);
                context.SaveChanges();

                mensagem = new frmMensagem
                {
                    mensagem = "Salvar"
                };
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigoVeiculo.Text);
                tbVeiculo veiculo = context.tbVeiculo.First(p => p.idVeiculo == codigo);
                veiculo.modelo = txtModelo.Text;
                veiculo.marca = txtFabricante.Text;
                veiculo.placa = txtPlaca.Text;
                veiculo.cor = txtCor.Text;

                context.SaveChanges();
                mensagem = new frmMensagem
                {
                    mensagem = "Atualizar"
                };
            }
            limpar();
            mensagem.Show();
            listarVeiculo();
        }

        private void limpar()
        {
            txtCodigoVeiculo.Clear();
            txtCor.Clear();
            txtFabricante.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoVeiculo.Text = dtgVeiculo.Rows[e.RowIndex].Cells["idVeiculo"].Value.ToString();
            txtCor.Text = dtgVeiculo.Rows[e.RowIndex].Cells["cor"].Value.ToString();
            txtFabricante.Text = dtgVeiculo.Rows[e.RowIndex].Cells["marca"].Value.ToString();
            txtModelo.Text = dtgVeiculo.Rows[e.RowIndex].Cells["modelo"].Value.ToString();
            txtPlaca.Text = dtgVeiculo.Rows[e.RowIndex].Cells["placa"].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoVeiculo.Text != "")
            {
                var context = new DatabaseEntities();
                int codigo = Convert.ToInt32(txtCodigoVeiculo.Text);

                tbVeiculo veiculo = context.tbVeiculo.First(p => p.idVeiculo == codigo);

                context.tbVeiculo.Attach(veiculo);
                context.Set<tbVeiculo>().Remove(veiculo);
                context.SaveChanges();
            }
            mensagem = new frmMensagem
            {
                mensagem = "Excluir"
            };
            listarVeiculo();
            limpar();
            mensagem.Show();
        }
    }
}
