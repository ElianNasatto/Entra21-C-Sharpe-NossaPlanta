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

        private void CadastroPlanta_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            PlantaRepositorio repositorio = new PlantaRepositorio();
            string busca = textBox1.Text;
            List<Planta> plantas = repositorio.ObterTodos(busca);
            for (int i = 0; i < plantas.Count; i++)
            {
                Planta planta = plantas[i];
                dataGridView1.Rows.Add(new object[] { planta.Id, planta.Nome });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Planta planta = new Planta();
            planta.Nome = textBox1.Text;
            planta.Altura = Convert.ToDecimal(maskedTextBox1.Text);
            planta.Peso = Convert.ToDecimal(maskedTextBox2.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            MessageBox.Show(repositorio.Inserir(planta),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTabela();
            }
        }
    }
}
