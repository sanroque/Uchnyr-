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
    public partial class AddMusica : Form
    {
        public AddMusica()
        {
            InitializeComponent();
        }

        private void AddMusica_Load(object sender, EventArgs e)
        {
            try
            {
                cbArtistas.Items.Clear();

                foreach (Artista artista in ListaArtistas.listaArtistas)
                {
                    cbArtistas.Items.Add(artista.Nome);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void bInserir_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbArtistas.Text == "" || txtDuracao.Text == "" || txtTitulo.Text == "")
                {
                    Exception ex = new Exception("Insira dados em todos os campos!");
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    foreach (Artista item in ListaArtistas.listaArtistas)
                    {
                        if (item.Nome == cbArtistas.Text)
                        {
                            ListaMusicas.listaMusicas.Add(new Musica(txtTitulo.Text, txtDuracao.Text, item));
                        }
                    }
                }

                this.Close();
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
