namespace CadastroDeLanche
{
    partial class TelaDeCadastros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.nrQuant = new System.Windows.Forms.NumericUpDown();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor R$";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(112, 9);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(169, 22);
            this.tbxNome.TabIndex = 3;
            // 
            // nrQuant
            // 
            this.nrQuant.Location = new System.Drawing.Point(112, 50);
            this.nrQuant.Name = "nrQuant";
            this.nrQuant.Size = new System.Drawing.Size(169, 22);
            this.nrQuant.TabIndex = 4;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(112, 99);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(169, 22);
            this.tbxValor.TabIndex = 5;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(12, 138);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(202, 77);
            this.Salvar.TabIndex = 6;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // TelaDeCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 228);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.nrQuant);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeCadastros";
            this.Text = "TelaDeCadastros";
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.NumericUpDown nrQuant;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button Salvar;
    }
}