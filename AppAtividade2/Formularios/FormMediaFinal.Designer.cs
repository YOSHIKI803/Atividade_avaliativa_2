namespace SimuladorMedia.Formularios
{
    partial class FormMediaFinal
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
            this.txtNotaExame = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(246, 255);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(97, 23);
            this.btNovo.TabIndex = 36;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Tan;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(61, 255);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(97, 23);
            this.btCalcular.TabIndex = 35;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtMediaFinalAluno
            // 
            this.txtMediaFinalAluno.Location = new System.Drawing.Point(77, 148);
            this.txtMediaFinalAluno.Name = "txtMediaFinalAluno";
            this.txtMediaFinalAluno.Size = new System.Drawing.Size(151, 20);
            this.txtMediaFinalAluno.TabIndex = 33;
            this.txtMediaFinalAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMediaFinalAluno_KeyUp);
            this.txtMediaFinalAluno.Leave += new System.EventHandler(this.txtMediaFinalAluno_Leave);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(77, 90);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(151, 20);
            this.txtNomeAluno.TabIndex = 32;
            // 
            // lbMenssagem
            // 
            this.lbMenssagem.AutoSize = true;
            this.lbMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenssagem.Location = new System.Drawing.Point(27, 290);
            this.lbMenssagem.Name = "lbMenssagem";
            this.lbMenssagem.Size = new System.Drawing.Size(110, 20);
            this.lbMenssagem.TabIndex = 31;
            this.lbMenssagem.Text = "Menssagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Média final do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome do Aluno:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 63);
            this.label1.TabIndex = 28;
            this.label1.Text = "VERIFICAR A MÉDIA FINAL APÓS NOTA DO EXAME FINAL\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotaExame
            // 
            this.txtNotaExame.Location = new System.Drawing.Point(77, 200);
            this.txtNotaExame.Name = "txtNotaExame";
            this.txtNotaExame.Size = new System.Drawing.Size(151, 20);
            this.txtNotaExame.TabIndex = 34;
            this.txtNotaExame.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotaExame_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pontução no Exame:";
            // 
            // FormMediaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(427, 418);
            this.Controls.Add(this.txtNotaExame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtMediaFinalAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lbMenssagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMediaFinal";
            this.Text = "FormMediaFinal";
            this.Load += new System.EventHandler(this.FormMediaFinal_Load);
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
        private System.Windows.Forms.TextBox txtNotaExame;
        private System.Windows.Forms.Label label3;
    }
}