using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchnyr
{
    internal class ListaArtistas
    {
        public int IdArtista { get; set; }
        public string Nome { get; set; }

        public static List<Artista> listaArtistas = new List<Artista>();
        public ListaArtistas()
        {
            IdArtista = 0;
            Nome = "";
        }

        public ListaArtistas(int idArtista, string nome)
        {
            IdArtista = idArtista;
            Nome = nome;

        }

        public override string ToString()
        {
            return Nome.ToString();
        }

        public void AddLista()
        {
            listaArtistas.Add(new Artista(IdArtista, Nome));
        }

       
    }
}
