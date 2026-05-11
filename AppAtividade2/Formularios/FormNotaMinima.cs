using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMedia.Formularios
{
    public partial class FormNotaMinima : Form
    {
        public FormNotaMinima()
        {
            InitializeComponent();
            lbMenssagem.Visible = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAluno.Text;
            double mediaFinal = Convert.ToDouble(txtMediaFinalAluno.Text);
            double NPEX = 0;
            

            if (mediaFinal >= 60)
            {
                MessageBox.Show($"O Acadêmico(a) {nome} já esta aprovado(a) ", "ADS/IFRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMediaFinalAluno.Clear();
                txtMediaFinalAluno.Focus();
            }


            else
            {
                NPEX = (500 - 6 * mediaFinal) / 4;
                lbMenssagem.Text = $"O acadêmico(a) {nome} precisa de \n {NPEX} pontos para ser aprovado(a)";
                lbMenssagem.Visible = true;
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMediaFinalAluno.Clear();
            txtNomeAluno.Clear();
            txtNomeAluno.Focus();
            lbMenssagem.Visible = false;
            lbMenssagem.Text = "Menssagem";
        }

        private void txtMediaFinalAluno_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;
            bool verificarVirgula = true;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;  //liberar a vírgula
                if (e.KeyCode == Keys.Enter) verificarNumero = true; //liberar a tecla enter
                if (e.KeyCode == Keys.Back) verificarNumero = true;  //Liberar a tecla back
                if (e.KeyCode == Keys.Tab) verificarNumero = true;

                int qtdVirgula = txtMediaFinalAluno.Text.Count(v => v == ',');  //contar vírgula

                if (qtdVirgula > 1) verificarVirgula = false;  //verificar vírgula

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMediaFinalAluno.Text = txtMediaFinalAluno.Text.Remove(txtMediaFinalAluno.Text.Length - 1);
            }
            if (verificarVirgula == false)
            {
                MessageBox.Show("Muitas vírgulas", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMediaFinalAluno.Text = txtMediaFinalAluno.Text.Remove(txtMediaFinalAluno.Text.Length - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormNotaMinima_Load(object sender, EventArgs e)
        {

        }
    }
}
