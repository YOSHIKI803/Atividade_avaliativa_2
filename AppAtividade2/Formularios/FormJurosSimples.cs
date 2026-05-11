using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AppAtividade2.Formularios
{
    public partial class FormJurosSimples : Form
    {
        public FormJurosSimples()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int tipoCalculo = ComboBox.SelectedIndex;

            
            switch (tipoCalculo)
            {
                case 0: //Cálcular Montante
                    {
                        double taxa = txtTaxa.Text != "" ? Convert.ToDouble(txtTaxa.Text) / 100 : 0;
                        double capital = Convert.ToDouble(txtCapital.Text);
                        int tempo = Convert.ToInt32(txtTempo.Text);
                        double montante = 0;

                        montante = capital * (1 + taxa * tempo);
                        txtMontante.Text = montante.ToString("C2");
                        break;
                    }
                case 1: //Calcular Capital
                    {
                        double taxa = txtTaxa.Text != "" ? Convert.ToDouble(txtTaxa.Text) / 100 : 0;
                        double capital = 0;
                        int tempo = Convert.ToInt32(txtTempo.Text);
                        double montante = Convert.ToDouble(txtMontante.Text);

                        capital = montante/ (1 + taxa * tempo);
                        txtCapital.Text = capital.ToString("C2");

                        break;
                    }
                case 2: //Calcular taxa
                    {
                        double taxa = 0;
                        double capital = Convert.ToDouble(txtCapital.Text);
                        int tempo = Convert.ToInt32(txtTempo.Text);
                        double montante = Convert.ToDouble(txtMontante.Text);

                        taxa = (montante - capital) / (capital * tempo);
                        txtTaxa.Text = taxa.ToString();

                        break;
                    }
                case 3: //Calcular tempo
                    {
                        double taxa = txtTaxa.Text != "" ? Convert.ToDouble(txtTaxa.Text) / 100 : 0;
                        double capital = Convert.ToDouble(txtCapital.Text);
                        double tempo = 0;
                        double montante = Convert.ToDouble(txtMontante.Text);

                        tempo = (montante - capital) / (capital * taxa);
                        txtTempo.Text = tempo.ToString();

                        break;
                    }
                case 4: //Calcular juros
                    {
                        double capital = Convert.ToDouble(txtCapital.Text);
                        double montante = Convert.ToDouble(txtMontante.Text);
                        double juros = 0;

                        juros = montante - capital;
                        txtJuros.Text = juros.ToString("C2");
                        break;
                    }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = ComboBox.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0: //Cálcular Montante
                    {
                        txtMontante.BackColor = Color.LightGreen;
                        txtCapital.BackColor = Color.White;
                        txtTaxa.BackColor = Color.White;
                        txtTempo.BackColor = Color.White;
                        txtJuros.Visible = false;
                        lbJuros.Visible = false;
                        txtTaxa.Visible = true;
                        lbTaxa.Visible = true;
                        txtTempo.Visible = true;
                        lbTempo.Visible = true;
                        break;
                    }
                case 1://Calcular Capital
                    {
                        txtMontante.BackColor = Color.White;
                        txtCapital.BackColor = Color.LightGreen;
                        txtTaxa.BackColor = Color.White;
                        txtTempo.BackColor = Color.White;
                        txtJuros.Visible = false;
                        lbJuros.Visible = false;
                        txtTaxa.Visible = true;
                        lbTaxa.Visible = true;
                        txtTempo.Visible = true;
                        lbTempo.Visible = true;
                        break;
                    }
                case 2: //Calcular taxa
                    {
                        txtMontante.BackColor = Color.White;
                        txtCapital.BackColor = Color.White;
                        txtTaxa.BackColor = Color.LightGreen;
                        txtTempo.BackColor = Color.White;
                        txtJuros.Visible = false;
                        lbJuros.Visible = false;
                        txtTaxa.Visible = true;
                        lbTaxa.Visible = true;
                        txtTempo.Visible = true;
                        lbTempo.Visible = true;
                        break;
                    }
                case 3: //Calcular tempo
                    {
                        txtMontante.BackColor = Color.White;
                        txtCapital.BackColor = Color.White;
                        txtTaxa.BackColor = Color.White;
                        txtTempo.BackColor = Color.LightGreen;
                        txtJuros.Visible = false;
                        lbJuros.Visible = false;
                        txtTaxa.Visible = true;
                        lbTaxa.Visible = true;
                        txtTempo.Visible = true;
                        lbTempo.Visible = true;
                        break;
                    }
                case 4: //Calcular juros
                    {
                        txtMontante.BackColor = Color.White;
                        txtCapital.BackColor = Color.White;
                        txtTaxa.Visible = false;
                        lbTaxa.Visible= false;
                        txtTempo.Visible = false;
                        lbTempo.Visible= false;
                        txtJuros.BackColor = Color.LightGreen;
                        txtJuros.Visible = true;
                        lbJuros.Visible = true;
                        break;
                    }

            }

        }

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            txtCapital.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtMontante.Clear();
            txtJuros.Clear();
          
            ComboBox.SelectedIndex = -1;
        }
    }
}
