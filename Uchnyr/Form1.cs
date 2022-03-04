using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchnyr
{
    public partial class Form1 : Form
    {

        int ids = 0;
        //Artista a = new Artista();
        //Musica m = new Musica();

        List<Artista> listaArtistas = new List<Artista>();
        List<Musica> lMusicas = new List<Musica>();

        public Form1()
        {
            InitializeComponent();
            
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Deseja mesmo sair?";
                string caption = "Fechar programa";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private Artista ReturnArtista(int id)
        {
           
                foreach (Artista artista in ListaArtistas.listaArtistas)
                {
                    if (artista.IdArtista == id)
                        return artista;
                }

                return null;
          
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblMusica.Visible = false;
                lblMusica.Text = " ";
                bLimparPlaylist.Enabled = false;

                cbArtistas.Items.Clear();
                lMusicas.Clear();

                foreach (Artista item in ListaArtistas.listaArtistas)
                {
                    listaArtistas.Add(item);
                }
                //Adiciona Itens nas listas por defeito;
                AddMerdices();

                foreach (Artista a in listaArtistas)
                {

                    cbArtistas.Items.Add(a);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void cbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbMusicas.Items.Clear();

                foreach (Musica music in ListaMusicas.listaMusicas)
                {
                    if (music.Artista.ToString() == cbArtistas.Text)
                    {
                        lbMusicas.Items.Add(music.Titulo);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void lbMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bInsertTrack.Visible = true;

            lblMusica.Visible = true;

            lblMusica.Text = cbArtistas.Text + " - " + lbMusicas.SelectedItem;

        }

        private void bInsertTrack_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbMusicas.SelectedIndex == -1) return;
                else
                {

                    int ex = 0;

                    string item = lbMusicas.SelectedItem.ToString();
                    foreach (DataGridViewRow d in dgvPlaylist.Rows)
                    {

                        string itemP = Convert.ToString(d.Cells[0].Value);

                        if (item == itemP)
                        {
                            MessageBox.Show("Essa musica ja esta na playlist");
                            ex = 1;
                            break;
                        }
                    }


                    foreach (Musica m in ListaMusicas.listaMusicas)
                    {
                        if (m.Titulo.ToString() == lbMusicas.SelectedItem.ToString())
                        {
                            ids++;


                            dgvPlaylist.Rows.Add(ids.ToString(), m.Titulo, m.Duracao, m.Artista);
                        }
                    }


                    bLimparPlaylist.Enabled = true;
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
            

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            var newArtist = new AddArtista();
            newArtist.Show();
           
            
        }

        public void AddMerdices()
        {
            ListaArtistas.listaArtistas.Add(new Artista(1, "2Pac"));
            ListaArtistas.listaArtistas.Add(new Artista(2, "Biggie Smalls"));
            ListaArtistas.listaArtistas.Add(new Artista(3, "J.Cole"));

            //2Pac default
            ListaMusicas.listaMusicas.Add(new Musica("Changes", "4:29", ReturnArtista(1)));
            ListaMusicas.listaMusicas.Add(new Musica("Gheto Gospel", "3:58", ReturnArtista(1)));
            ListaMusicas.listaMusicas.Add(new Musica("All Eyez On Me", "5:08", ReturnArtista(1)));

            //biggie default
            ListaMusicas.listaMusicas.Add(new Musica("Juicy", "5:03", ReturnArtista(2)));
            ListaMusicas.listaMusicas.Add(new Musica("Big Poppa", "4:13", ReturnArtista(2)));
            ListaMusicas.listaMusicas.Add(new Musica("Hypnotize", "3:50", ReturnArtista(2)));


            //jcole default
            ListaMusicas.listaMusicas.Add(new Musica("MIDDLE CHILD", "3:33", ReturnArtista(3)));
            ListaMusicas.listaMusicas.Add(new Musica("No Role Modelz", "4:52", ReturnArtista(3)));
            ListaMusicas.listaMusicas.Add(new Musica("Work Out", "3:56", ReturnArtista(3)));

        }

        private void cbArtistas_Click(object sender, EventArgs e)
        {
            try
            {
                cbArtistas.Items.Clear();

                foreach (Artista item in ListaArtistas.listaArtistas)
                {
                    cbArtistas.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMusica addMusica = new AddMusica();

            addMusica.Show();

        }

        private void bLimparPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPlaylist.Rows.Clear();
                bLimparPlaylist.Enabled = false;
                ids = 0;

                lbMusicas.Items.Clear();
                cbArtistas.SelectedIndex = -1;
                lblMusica.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveArtista form = new RemoveArtista();
            form.Show();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveMusica form = new RemoveMusica();
            form.Show();
        }
    }
}

