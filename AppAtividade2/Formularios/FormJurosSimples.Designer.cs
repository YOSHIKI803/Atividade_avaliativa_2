namespace AppAtividade2.Formularios
{
    partial class FormJurosSimples
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCapital = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.lbMontante = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(605, 494);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(176, 49);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(628, 227);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(154, 22);
            this.txtCapital.TabIndex = 3;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(628, 292);
            this.txtTaxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(154, 22);
            this.txtTaxa.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(628, 363);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(154, 22);
            this.txtTempo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "CALCULADORA DE JUROS";
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Location = new System.Drawing.Point(375, 230);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(52, 16);
            this.lbCapital.TabIndex = 7;
            this.lbCapital.Text = "Capital:";
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Location = new System.Drawing.Point(375, 292);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(132, 16);
            this.lbTaxa.TabIndex = 8;
            this.lbTaxa.Text = "Taxa (porcentagem):";
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Location = new System.Drawing.Point(375, 363);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(106, 16);
            this.lbTempo.TabIndex = 9;
            this.lbTempo.Text = "Tempo (meses):";
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Location = new System.Drawing.Point(375, 436);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(43, 16);
            this.lbJuros.TabIndex = 11;
            this.lbJuros.Text = "Juros:";
            // 
            // lbMontante
            // 
            this.lbMontante.AutoSize = true;
            this.lbMontante.Location = new System.Drawing.Point(375, 164);
            this.lbMontante.Name = "lbMontante";
            this.lbMontante.Size = new System.Drawing.Size(65, 16);
            this.lbMontante.TabIndex = 13;
            this.lbMontante.Text = "Montante:";
            // 
            // txtMontante
            // 
            this.txtMontante.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontante.Location = new System.Drawing.Point(628, 159);
            this.txtMontante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(154, 22);
            this.txtMontante.TabIndex = 12;
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.SystemColors.Window;
            this.txtJuros.Location = new System.Drawing.Point(628, 431);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(154, 22);
            this.txtJuros.TabIndex = 14;
            // 
            // ComboBox
            // 
            this.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "CALCULAR O MONTANTE SIMPLES",
            "CALCULAR O CAPITAL",
            "CALCULAR A TAXA",
            "CALCULAR O TEMPO",
            "CALCULAR JUROS"});
            this.ComboBox.Location = new System.Drawing.Point(379, 101);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(377, 24);
            this.ComboBox.TabIndex = 15;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Selecione o que desejar calcular:";
            // 
            // FormJurosSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 598);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lbMontante);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.lbJuros);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.lbTaxa);
            this.Controls.Add(this.lbCapital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJurosSimples";
            this.Text = "FormJurosSimples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Label lbJuros;
        private System.Windows.Forms.Label lbMontante;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label label7;
    }
}