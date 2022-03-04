namespace Uchnyr
{
    partial class RemoveArtista
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
            this.label1 = new System.Windows.Forms.Label();
            this.bRemover = new System.Windows.Forms.Button();
            this.checkConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbArtistas
            // 
            this.cbArtistas.BackColor = System.Drawing.Color.MintCream;
            this.cbArtistas.FormattingEnabled = true;
            this.cbArtistas.Location = new System.Drawing.Point(100, 38);
            this.cbArtistas.Name = "cbArtistas";
            this.cbArtistas.Size = new System.Drawing.Size(121, 21);
            this.cbArtistas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artista: ";
            // 
            // bRemover
            // 
            this.bRemover.BackColor = System.Drawing.Color.MintCream;
            this.bRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemover.Location = new System.Drawing.Point(100, 89);
            this.bRemover.Name = "bRemover";
            this.bRemover.Size = new System.Drawing.Size(121, 29);
            this.bRemover.TabIndex = 2;
            this.bRemover.Text = "Remover";
            this.bRemover.UseVisualStyleBackColor = false;
            this.bRemover.Click += new System.EventHandler(this.bRemover_Click);
            // 
            // checkConfirm
            // 
            this.checkConfirm.AutoSize = true;
            this.checkConfirm.BackColor = System.Drawing.Color.SlateGray;
            this.checkConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConfirm.Location = new System.Drawing.Point(100, 66);
            this.checkConfirm.Name = "checkConfirm";
            this.checkConfirm.Size = new System.Drawing.Size(79, 17);
            this.checkConfirm.TabIndex = 3;
            this.checkConfirm.Text = "Confirmar";
            this.checkConfirm.UseVisualStyleBackColor = false;
            this.checkConfirm.CheckedChanged += new System.EventHandler(this.checkConfirm_CheckedChanged);
            // 
            // RemoveArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(257, 149);
            this.Controls.Add(this.checkConfirm);
            this.Controls.Add(this.bRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArtistas);
            this.Name = "RemoveArtista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.RemoveArtista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArtistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRemover;
        private System.Windows.Forms.CheckBox checkConfirm;
    }
}