namespace Uchnyr
{
    partial class RemoveMusica
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
            this.cbArtistas = new System.Windows.Forms.ComboBox();
            this.lbMusicas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkConfirmar = new System.Windows.Forms.CheckBox();
            this.bRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista: ";
            // 
            // cbArtistas
            // 
            this.cbArtistas.BackColor = System.Drawing.Color.MintCream;
            this.cbArtistas.FormattingEnabled = true;
            this.cbArtistas.Location = new System.Drawing.Point(113, 42);
            this.cbArtistas.Name = "cbArtistas";
            this.cbArtistas.Size = new System.Drawing.Size(121, 21);
            this.cbArtistas.TabIndex = 1;
            this.cbArtistas.SelectedIndexChanged += new System.EventHandler(this.cbArtistas_SelectedIndexChanged);
            // 
            // lbMusicas
            // 
            this.lbMusicas.BackColor = System.Drawing.Color.MintCream;
            this.lbMusicas.FormattingEnabled = true;
            this.lbMusicas.Location = new System.Drawing.Point(114, 69);
            this.lbMusicas.Name = "lbMusicas";
            this.lbMusicas.Size = new System.Drawing.Size(120, 95);
            this.lbMusicas.TabIndex = 2;
            this.lbMusicas.SelectedIndexChanged += new System.EventHandler(this.lbMusicas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Musica: ";
            // 
            // checkConfirmar
            // 
            this.checkConfirmar.AutoSize = true;
            this.checkConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConfirmar.Location = new System.Drawing.Point(114, 170);
            this.checkConfirmar.Name = "checkConfirmar";
            this.checkConfirmar.Size = new System.Drawing.Size(79, 17);
            this.checkConfirmar.TabIndex = 4;
            this.checkConfirmar.Text = "Confirmar";
            this.checkConfirmar.UseVisualStyleBackColor = true;
            this.checkConfirmar.CheckedChanged += new System.EventHandler(this.checkConfirmar_CheckedChanged);
            // 
            // bRemover
            // 
            this.bRemover.BackColor = System.Drawing.Color.MintCream;
            this.bRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemover.Location = new System.Drawing.Point(114, 203);
            this.bRemover.Name = "bRemover";
            this.bRemover.Size = new System.Drawing.Size(120, 33);
            this.bRemover.TabIndex = 5;
            this.bRemover.Text = "Remover";
            this.bRemover.UseVisualStyleBackColor = false;
            this.bRemover.Click += new System.EventHandler(this.bRemover_Click);
            // 
            // RemoveMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(289, 272);
            this.Controls.Add(this.bRemover);
            this.Controls.Add(this.checkConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMusicas);
            this.Controls.Add(this.cbArtistas);
            this.Controls.Add(this.label1);
            this.Name = "RemoveMusica";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.RemoveMusica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArtistas;
        private System.Windows.Forms.ListBox lbMusicas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkConfirmar;
        private System.Windows.Forms.Button bRemover;
    }
}