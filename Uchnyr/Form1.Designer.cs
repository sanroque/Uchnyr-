namespace Uchnyr
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbArtistas = new System.Windows.Forms.ComboBox();
            this.lbMusicas = new System.Windows.Forms.ListBox();
            this.lblArtistas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bInsertTrack = new System.Windows.Forms.Button();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMusica = new System.Windows.Forms.Label();
            this.bLimparPlaylist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistaToolStripMenuItem,
            this.musicaToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // artistaToolStripMenuItem
            // 
            this.artistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.artistaToolStripMenuItem.Name = "artistaToolStripMenuItem";
            this.artistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artistaToolStripMenuItem.Text = "Artista";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // musicaToolStripMenuItem
            // 
            this.musicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.removerToolStripMenuItem1});
            this.musicaToolStripMenuItem.Name = "musicaToolStripMenuItem";
            this.musicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musicaToolStripMenuItem.Text = "Musica";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // removerToolStripMenuItem1
            // 
            this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            this.removerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removerToolStripMenuItem1.Text = "Remover";
            this.removerToolStripMenuItem1.Click += new System.EventHandler(this.removerToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cbArtistas
            // 
            this.cbArtistas.BackColor = System.Drawing.Color.MintCream;
            this.cbArtistas.FormattingEnabled = true;
            this.cbArtistas.Location = new System.Drawing.Point(129, 116);
            this.cbArtistas.Name = "cbArtistas";
            this.cbArtistas.Size = new System.Drawing.Size(121, 21);
            this.cbArtistas.TabIndex = 1;
            this.cbArtistas.SelectedIndexChanged += new System.EventHandler(this.cbArtistas_SelectedIndexChanged);
            this.cbArtistas.Click += new System.EventHandler(this.cbArtistas_Click);
            // 
            // lbMusicas
            // 
            this.lbMusicas.BackColor = System.Drawing.Color.MintCream;
            this.lbMusicas.FormattingEnabled = true;
            this.lbMusicas.Location = new System.Drawing.Point(129, 143);
            this.lbMusicas.Name = "lbMusicas";
            this.lbMusicas.Size = new System.Drawing.Size(120, 95);
            this.lbMusicas.TabIndex = 2;
            this.lbMusicas.SelectedIndexChanged += new System.EventHandler(this.lbMusicas_SelectedIndexChanged);
            // 
            // lblArtistas
            // 
            this.lblArtistas.AutoSize = true;
            this.lblArtistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistas.Location = new System.Drawing.Point(45, 117);
            this.lblArtistas.Name = "lblArtistas";
            this.lblArtistas.Size = new System.Drawing.Size(81, 20);
            this.lblArtistas.TabIndex = 3;
            this.lblArtistas.Text = "Artistas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Musicas: ";
            // 
            // bInsertTrack
            // 
            this.bInsertTrack.BackColor = System.Drawing.Color.MintCream;
            this.bInsertTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsertTrack.Location = new System.Drawing.Point(129, 253);
            this.bInsertTrack.Name = "bInsertTrack";
            this.bInsertTrack.Size = new System.Drawing.Size(120, 33);
            this.bInsertTrack.TabIndex = 5;
            this.bInsertTrack.Text = "Inserir Track";
            this.bInsertTrack.UseVisualStyleBackColor = false;
            this.bInsertTrack.Visible = false;
            this.bInsertTrack.Click += new System.EventHandler(this.bInsertTrack_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.duracao,
            this.artista});
            this.dgvPlaylist.Location = new System.Drawing.Point(310, 116);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.Size = new System.Drawing.Size(384, 151);
            this.dgvPlaylist.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // duracao
            // 
            this.duracao.HeaderText = "Duracao";
            this.duracao.Name = "duracao";
            this.duracao.ReadOnly = true;
            // 
            // artista
            // 
            this.artista.HeaderText = "Artista";
            this.artista.Name = "artista";
            this.artista.ReadOnly = true;
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.Location = new System.Drawing.Point(306, 80);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(63, 20);
            this.lblMusica.TabIndex = 7;
            this.lblMusica.Text = "Track: ";
            // 
            // bLimparPlaylist
            // 
            this.bLimparPlaylist.BackColor = System.Drawing.Color.MintCream;
            this.bLimparPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimparPlaylist.Location = new System.Drawing.Point(429, 273);
            this.bLimparPlaylist.Name = "bLimparPlaylist";
            this.bLimparPlaylist.Size = new System.Drawing.Size(157, 41);
            this.bLimparPlaylist.TabIndex = 8;
            this.bLimparPlaylist.Text = "Limpar Playlist";
            this.bLimparPlaylist.UseVisualStyleBackColor = false;
            this.bLimparPlaylist.Click += new System.EventHandler(this.bLimparPlaylist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 9);
            this.label2.TabIndex = 9;
            this.label2.Text = "Uchnyr © Gonçalo Sanroque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Uchnyr | A tua musica favorita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(783, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLimparPlaylist);
            this.Controls.Add(this.lblMusica);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.bInsertTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtistas);
            this.Controls.Add(this.lbMusicas);
            this.Controls.Add(this.cbArtistas);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbArtistas;
        private System.Windows.Forms.ListBox lbMusicas;
        private System.Windows.Forms.Label lblArtistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bInsertTrack;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn artista;
        private System.Windows.Forms.Button bLimparPlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

