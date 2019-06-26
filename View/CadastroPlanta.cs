using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroPlanta : Form
    {
        public CadastroPlanta()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtxtAltura.Clear();
            mtxtPeso.Clear();
            rbNao.Checked = false;
            rbSim.Checked = true;
        }
        private void CadastroPlanta_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            dataGridView1.Rows.Clear();
            PlantaRepositorio repositorio = new PlantaRepositorio();
            string busca = txtBusca.Text;
            List<Planta> plantas = repositorio.ObterTodos(busca);
            for (int i = 0; i < plantas.Count; i++)
            {
                Planta planta = plantas[i];
                dataGridView1.Rows.Add(new object[] { planta.Id, planta.Nome });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
            LimparCampos();
        }

        private void Inserir()
        {
            Planta planta = new Planta();
            planta.Nome = txtNome.Text;
            planta.Altura = Convert.ToDecimal(mtxtAltura.Text);
            planta.Peso = Convert.ToDecimal(mtxtPeso.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            MessageBox.Show(repositorio.Inserir(planta), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarTabela();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTabela();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Planta planta = new Planta();
            PlantaRepositorio repositorio = new PlantaRepositorio();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            planta = repositorio.ObterPeloId(id);
            if (planta == null)
            {
                MessageBox.Show("Não foi possivel obter o registro selecionado","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblId.Text = planta.Id.ToString();
            txtNome.Text = planta.Nome;
            mtxtAltura.Text = planta.Altura.ToString();
            mtxtPeso.Text = planta.Peso.ToString();
            if (planta.Carnivora == true)
            {
                rbSim.Checked = true;
            }
            else
            {
                rbNao.Checked = true;
            }
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Planta planta = new Planta();
            planta.Id = Convert.ToInt32(lblId.Text);
            planta.Nome = txtNome.Text;
            planta.Peso = Convert.ToDecimal(mtxtPeso.Text);
            planta.Altura = Convert.ToDecimal(mtxtAltura.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Alterar(planta);

            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            MessageBox.Show("Editado com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            AtualizarTabela();
        }
    }
}
