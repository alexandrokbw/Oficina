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
                         tbL.idCliente,
                         tbL.idVeiculo,
                         tbL.cor,
                         tbL.marca,
                         tbL.modelo,
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
            //limpar();
            mensagem.Show();
            listarVeiculo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
