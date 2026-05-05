namespace SimuladorMedia.Formularios
{
    partial class FormNotaMinima
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtMediaFinalAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lbMenssagem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(247, 224);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(97, 23);
            this.btNovo.TabIndex = 27;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Tan;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(62, 224);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(97, 23);
            this.btCalcular.TabIndex = 26;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtMediaFinalAluno
            // 
            this.txtMediaFinalAluno.Location = new System.Drawing.Point(78, 167);
            this.txtMediaFinalAluno.Name = "txtMediaFinalAluno";
            this.txtMediaFinalAluno.Size = new System.Drawing.Size(151, 20);
            this.txtMediaFinalAluno.TabIndex = 25;
            this.txtMediaFinalAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMediaFinalAluno_KeyUp);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(78, 90);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(151, 20);
            this.txtNomeAluno.TabIndex = 22;
            // 
            // lbMenssagem
            // 
            this.lbMenssagem.AutoSize = true;
            this.lbMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenssagem.Location = new System.Drawing.Point(80, 282);
            this.lbMenssagem.Name = "lbMenssagem";
            this.lbMenssagem.Size = new System.Drawing.Size(110, 20);
            this.lbMenssagem.TabIndex = 21;
            this.lbMenssagem.Text = "Menssagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Média final do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do Aluno:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 53);
            this.label1.TabIndex = 16;
            this.label1.Text = "NOTA MÍNIMA PARA APROVAÇÂO NO EXAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNotaMinima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(430, 436);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtMediaFinalAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lbMenssagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNotaMinima";
            this.Text = "FormNotaMinima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtMediaFinalAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lbMenssagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}