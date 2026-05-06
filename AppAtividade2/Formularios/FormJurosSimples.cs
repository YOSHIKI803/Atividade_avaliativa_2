using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividade2.Formularios
{
    public partial class FormJurosSimples : Form
    {
        public FormJurosSimples()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCapital.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtCapital.Focus();
        }

        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            double taxa = txtTaxa.Text != "" ? Convert.ToDouble(txtTaxa.Text) / 100 : 0;
            double capital = Convert.ToDouble(txtCapital.Text);
            int tempo = Convert.ToInt32(txtTempo.Text);
            double juros = 0, montante = 0;
            
            montante = capital * (1 + taxa * tempo);

            txtMontante.Text = montante.ToString("C2");

            juros = montante - capital;

            txtJuros.Text = juros.ToString("C2");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            
        }
    }
}
