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

        
    }
}
