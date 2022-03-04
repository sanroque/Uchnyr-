namespace Uchnyr
{
    partial class AddMusica
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
            this.cbArtistas = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbArtistas
            // 
            this.cbArtistas.BackColor = System.Drawing.Color.MintCream;
            this.cbArtistas.FormattingEnabled = true;
            this.cbArtistas.Location = new System.Drawing.Point(109, 81);
            this.cbArtistas.Name = "cbArtistas";
            this.cbArtistas.Size = new System.Drawing.Size(121, 21);
            this.cbArtistas.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.MintCream;
            this.txtTitulo.Location = new System.Drawing.Point(109, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDuracao
            // 
            this.txtDuracao.BackColor = System.Drawing.Color.MintCream;
            this.txtDuracao.Location = new System.Drawing.Point(109, 55);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(121, 20);
            this.txtDuracao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duração:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artista: ";
            // 
            // bInserir
            // 
            this.bInserir.BackColor = System.Drawing.Color.MintCream;
            this.bInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInserir.Location = new System.Drawing.Point(109, 121);
            this.bInserir.Name = "bInserir";
            this.bInserir.Size = new System.Drawing.Size(121, 29);
            this.bInserir.TabIndex = 6;
            this.bInserir.Text = "Inserir";
            this.bInserir.UseVisualStyleBackColor = false;
            this.bInserir.Click += new System.EventHandler(this.bInserir_Click);
            // 
            // AddMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(285, 171);
            this.Controls.Add(this.bInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cbArtistas);
            this.Name = "AddMusica";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddMusica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArtistas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bInserir;
    }
}