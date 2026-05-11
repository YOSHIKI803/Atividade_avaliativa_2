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
    public partial class FormMediaFinal : Form
    {
        public FormMediaFinal()
        {
            InitializeComponent();
            lbMenssagem.Visible = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAluno.Text;
            double mediaFinal = Convert.ToDouble(txtMediaFinalAluno.Text);
            double notaExame = Convert.ToDouble(txtNotaExame.Text);
            double MAEX = 0;

           
            MAEX = ((6 * mediaFinal) + (4 * notaExame)) / 10;

            if(MAEX >= 50)
            {
                lbMenssagem.Text = $"{nome}, você foi aprovado(a), com {MAEX} pontos";
                lbMenssagem.Visible = true;
            }
            else
            {
                lbMenssagem.Text = $"{nome}, você não foi aprovado(a) ";
                lbMenssagem.Visible = true;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtMediaFinalAluno.Clear();
            txtNotaExame.Clear();
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

        private void txtNotaExame_KeyUp(object sender, KeyEventArgs e)
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

                int qtdVirgula = txtNotaExame.Text.Count(v => v == ',');  //contar vírgula

                if (qtdVirgula > 1) verificarVirgula = false;  //verificar vírgula

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNotaExame.Text = txtNotaExame.Text.Remove(txtNotaExame.Text.Length - 1);
            }
            if (verificarVirgula == false)
            {
                MessageBox.Show("Muitas vírgulas", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNotaExame.Text = txtNotaExame.Text.Remove(txtNotaExame.Text.Length - 1);
            }
        }

        private void FormMediaFinal_Load(object sender, EventArgs e)
        {

        }
        private void txtMediaFinalAluno_Leave(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(txtMediaFinalAluno.Text);
            string nome = txtNomeAluno.Text;

            if (nota >= 60)
            {
                MessageBox.Show($"O Aluno {nome}, já passou na matéria", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMediaFinalAluno.Clear();
            }
        }

     
    }
}
