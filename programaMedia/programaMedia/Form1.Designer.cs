namespace programaMedia
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(153, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calcular Média";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(164, 320);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(212, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(244, 82);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(132, 23);
            this.txtNota1.TabIndex = 2;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(244, 248);
            this.txtNota4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(132, 23);
            this.txtNota4.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(244, 135);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(132, 23);
            this.txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(244, 191);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(132, 23);
            this.txtNota3.TabIndex = 5;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblN1.Location = new System.Drawing.Point(161, 86);
            this.lblN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(56, 17);
            this.lblN1.TabIndex = 6;
            this.lblN1.Text = "Nota 1:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblN2.Location = new System.Drawing.Point(161, 135);
            this.lblN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(56, 17);
            this.lblN2.TabIndex = 7;
            this.lblN2.Text = "Nota 2:";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblN3.Location = new System.Drawing.Point(161, 192);
            this.lblN3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(56, 17);
            this.lblN3.TabIndex = 8;
            this.lblN3.Text = "Nota 3:";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN4.Location = new System.Drawing.Point(161, 250);
            this.lblN4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(56, 17);
            this.lblN4.TabIndex = 9;
            this.lblN4.Text = "Nota 4:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(198, 415);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 28);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 523);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblResultado;
    }
}

