using AppAtividade2.Formularios;
using SimuladorMedia.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            FormSimuladorMedia form = new FormSimuladorMedia();
            form.ShowDialog();
        }

        private void btNotaMinima_Click(object sender, EventArgs e)
        {
            FormNotaMinima form = new FormNotaMinima();
            form.ShowDialog();
        }

        private void btPosExame_Click(object sender, EventArgs e)
        {
            FormMediaFinal form = new FormMediaFinal(); 
            form.ShowDialog();
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            FormJurosSimples form = new FormJurosSimples(); 
            form.ShowDialog();
        }
    }
}
