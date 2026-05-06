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
    public partial class FormSimuladorMedia : Form
    {
        public FormSimuladorMedia()
        {
            InitializeComponent();
            lbMenssagem.Visible = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nome = (txtNomeAluno.Text);
            double nota1, nota2, media;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);

            media = (nota1 + nota2) / 2;

            txtMediaAluno.Text = media.ToString("F2");

            if(media>=60)
            {
                lbMenssagem.Text = $"{nome}, você foi aprovado(a)";
                lbMenssagem.Visible = true;
            }
            else
            {
                lbMenssagem.Text = $"{nome}, você não foi aprovado(a)";
                lbMenssagem.Visible = true;
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMediaAluno.Clear();
            lbMenssagem.Text = "Menssagem";
            lbMenssagem.Visible = false;
        }

        private void FormSimuladorMedia_Load(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_KeyUp(object sender, KeyEventArgs e)
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

                int qtdVirgula = txtNota1.Text.Count(v => v == ',');  //contar vírgula

                if (qtdVirgula > 1) verificarVirgula = false;  //verificar vírgula

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNota1.Text = txtNota1.Text.Remove(txtNota1.Text.Length - 1);
            }
            if (verificarVirgula == false)
            {
                MessageBox.Show("Muitas vírgulas", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNota1.Text = txtNota1.Text.Remove(txtNota1.Text.Length - 1);
            }
        }

        private void txtNota2_KeyUp(object sender, KeyEventArgs e)
        {
            TesteCampo(txtNota1.Text, e);
        }

        //Função para a lib de teste criar a lib depois para reutilizar código
        public static void TesteCampo (string Testo, KeyEventArgs e)
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

                int qtdVirgula = Testo.Count(v => v == ',');  //contar vírgula

                if (qtdVirgula > 1) verificarVirgula = false;  //verificar vírgula

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Testo = Testo.Remove(Testo.Length - 1);
            }
            if (verificarVirgula == false)
            {
                MessageBox.Show("Muitas vírgulas", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Testo = Testo.Remove(Testo.Length - 1); 
            }
        }
            }
}
