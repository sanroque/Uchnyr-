namespace Uchnyr
{
    partial class AddArtista
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
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.bNovoArtista = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArtista
            // 
            this.txtArtista.BackColor = System.Drawing.Color.MintCream;
            this.txtArtista.Location = new System.Drawing.Point(84, 17);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(100, 20);
            this.txtArtista.TabIndex = 0;
            // 
            // bNovoArtista
            // 
            this.bNovoArtista.BackColor = System.Drawing.Color.MintCream;
            this.bNovoArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovoArtista.Location = new System.Drawing.Point(84, 43);
            this.bNovoArtista.Name = "bNovoArtista";
            this.bNovoArtista.Size = new System.Drawing.Size(100, 29);
            this.bNovoArtista.TabIndex = 1;
            this.bNovoArtista.Text = "Inserir";
            this.bNovoArtista.UseVisualStyleBackColor = false;
            this.bNovoArtista.Click += new System.EventHandler(this.bNovoArtista_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: ";
            // 
            // AddArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(215, 109);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.bNovoArtista);
            this.Controls.Add(this.txtArtista);
            this.Name = "AddArtista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Button bNovoArtista;
        private System.Windows.Forms.Label lblNome;
    }
}