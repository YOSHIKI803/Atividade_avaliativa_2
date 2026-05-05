namespace AppAtividade2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCalculadora = new System.Windows.Forms.Button();
            this.btNotaMinima = new System.Windows.Forms.Button();
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.btPosExame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculadora
            // 
            this.btCalculadora.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculadora.Location = new System.Drawing.Point(212, 247);
            this.btCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.btCalculadora.Name = "btCalculadora";
            this.btCalculadora.Size = new System.Drawing.Size(407, 44);
            this.btCalculadora.TabIndex = 10;
            this.btCalculadora.Text = "CALCULADORA DE JUROS";
            this.btCalculadora.UseVisualStyleBackColor = false;
            this.btCalculadora.Click += new System.EventHandler(this.btCalculadora_Click);
            // 
            // btNotaMinima
            // 
            this.btNotaMinima.BackColor = System.Drawing.Color.Gold;
            this.btNotaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotaMinima.Location = new System.Drawing.Point(212, 104);
            this.btNotaMinima.Margin = new System.Windows.Forms.Padding(2);
            this.btNotaMinima.Name = "btNotaMinima";
            this.btNotaMinima.Size = new System.Drawing.Size(407, 44);
            this.btNotaMinima.TabIndex = 9;
            this.btNotaMinima.Text = "NOTA MÍNIMA PARA SER APROVADO NO EXAME\r\n";
            this.btNotaMinima.UseVisualStyleBackColor = false;
            this.btNotaMinima.Click += new System.EventHandler(this.btNotaMinima_Click);
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.BackColor = System.Drawing.Color.Orange;
            this.btSimularMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(212, 40);
            this.btSimularMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(407, 44);
            this.btSimularMedia.TabIndex = 8;
            this.btSimularMedia.Text = "SIMULAR MÉDIA";
            this.btSimularMedia.UseVisualStyleBackColor = false;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // btPosExame
            // 
            this.btPosExame.BackColor = System.Drawing.Color.YellowGreen;
            this.btPosExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosExame.Location = new System.Drawing.Point(212, 170);
            this.btPosExame.Margin = new System.Windows.Forms.Padding(2);
            this.btPosExame.Name = "btPosExame";
            this.btPosExame.Size = new System.Drawing.Size(407, 44);
            this.btPosExame.TabIndex = 7;
            this.btPosExame.Text = "VERIFICAR A MÉDIA FINAL APÓS \r\nNOTA DO EXAME FINAL";
            this.btPosExame.UseVisualStyleBackColor = false;
            this.btPosExame.Click += new System.EventHandler(this.btPosExame_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 84);
            this.label1.TabIndex = 11;
            this.label1.Text = "Autores do Projeto: \r\nAutor 1: \r\nAutor 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalculadora);
            this.Controls.Add(this.btNotaMinima);
            this.Controls.Add(this.btSimularMedia);
            this.Controls.Add(this.btPosExame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCalculadora;
        private System.Windows.Forms.Button btNotaMinima;
        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Button btPosExame;
        private System.Windows.Forms.Label label1;
    }
}

