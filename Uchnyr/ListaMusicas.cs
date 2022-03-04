using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchnyr
{
    internal class ListaMusicas
    {
        public string Titulo { get; set; }
        public string Duracao { get; set; }
        public Artista Artista { get; set; }

        public static List<Musica> listaMusicas = new List<Musica>();

        public ListaMusicas()
        {
        }

        public ListaMusicas(string titulo, string duracao, Artista artista)
        {
            Titulo = titulo;
            Duracao = duracao;
            Artista = artista;
        }

        public override string ToString()
        {
            return Titulo.ToString();
        }

        public void AddLista()
        {
            listaMusicas.Add(new Musica(Titulo, Duracao, Artista));
        }


    }
}
