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
    public partial class RemoveArtista : Form
    {
        public RemoveArtista()
        {
            InitializeComponent();
        }

        
        private void RemoveArtista_Load(object sender, EventArgs e)
        {
            try
            {
                bRemover.Enabled = false;

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

        private void checkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkConfirm.Checked == true)
                {
                    bRemover.Enabled = true;
                }
                else
                {
                    bRemover.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Exception exc;

                string ar = "";

                if (cbArtistas.Text == "")
                {
                    exc = new Exception("Erro: Indique um artista!");
                    MessageBox.Show(exc.Message);
                }
                else
                {
                    foreach (Artista artista in ListaArtistas.listaArtistas)
                    {

                        if (artista.Nome == cbArtistas.Text)
                        {

                            ListaArtistas.listaArtistas.Remove(artista);
                            ar = artista.Nome;
                            break;
                        }
                    }
                    this.Close();
                    MessageBox.Show("Artista " + ar + " removido com sucesso!");

                    Form1 form = new Form1();
                    form.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }  
        }
    }
}
