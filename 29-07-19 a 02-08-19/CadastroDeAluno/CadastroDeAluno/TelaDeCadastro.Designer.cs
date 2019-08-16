namespace CadastroDeAluno
{
    partial class TelaDeCadastro
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
            this.tbxNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNomeV = new System.Windows.Forms.TextBox();
            this.nrIdade = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.AutoSize = true;
            this.tbxNome.Location = new System.Drawing.Point(22, 9);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(45, 17);
            this.tbxNome.TabIndex = 0;
            this.tbxNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // tbxNomeV
            // 
            this.tbxNomeV.Location = new System.Drawing.Point(94, 13);
            this.tbxNomeV.Name = "tbxNomeV";
            this.tbxNomeV.Size = new System.Drawing.Size(171, 22);
            this.tbxNomeV.TabIndex = 2;
            // 
            // nrIdade
            // 
            this.nrIdade.Location = new System.Drawing.Point(94, 57);
            this.nrIdade.Name = "nrIdade";
            this.nrIdade.Size = new System.Drawing.Size(171, 22);
            this.nrIdade.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 5;
            //this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 230);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrIdade);
            this.Controls.Add(this.tbxNomeV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNome);
            this.Name = "TelaDeCadastro";
            this.Text = "TabelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNomeV;
        private System.Windows.Forms.NumericUpDown nrIdade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}