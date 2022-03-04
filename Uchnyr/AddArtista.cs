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
    public partial class AddArtista : Form
    {
      
        

        public AddArtista()
        {
            InitializeComponent();
        }

        private void bNovoArtista_Click(object sender, EventArgs e)
        {

            try
            {
                string nome = txtArtista.Text;
                int i = 0;
                int IdArtista = 0;
                Form1 form1 = new Form1();

                foreach (Artista a in ListaArtistas.listaArtistas)
                {
                    i++;
                }

                IdArtista = i++;

                if (nome == "")
                {
                    Exception ex = new Exception("Indique o nome do artista!");
                    MessageBox.Show(ex.Message);
                    
                }
                else
                {
                    ListaArtistas.listaArtistas.Add(new Artista(IdArtista, nome));

                    form1.Focus();
                    this.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
        }

    }
}
