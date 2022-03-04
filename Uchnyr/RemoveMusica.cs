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
    public partial class RemoveMusica : Form
    {
        public RemoveMusica()
        {
            InitializeComponent();
        }

        private void RemoveMusica_Load(object sender, EventArgs e)
        {
            try
            {
                bRemover.Enabled = false;
                checkConfirmar.Enabled = false;

                foreach (Artista item in ListaArtistas.listaArtistas)
                {
                    cbArtistas.Items.Add(item);
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

        private void checkConfirmar_CheckedChanged(object sender, EventArgs e)
        {
                if (checkConfirmar.Checked == true)
                {
                    bRemover.Enabled = true;
                }
                else
                {
                    bRemover.Enabled = false;
                }

        }

        private void lbMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMusicas.SelectedIndex != -1)
            {
                checkConfirmar.Enabled = true;
            }
        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            try
            {
                string mus = "";

                foreach (Musica item in ListaMusicas.listaMusicas)
                {
                    if (item.Titulo == lbMusicas.SelectedItem.ToString())
                    {
                        ListaMusicas.listaMusicas.Remove(item);
                        mus = item.Titulo;
                        break;
                    }
                }
                this.Close();
                MessageBox.Show("Musica " + mus + " removida com sucesso!");
                Form1 form = new Form1();
                form.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
