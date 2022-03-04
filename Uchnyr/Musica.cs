using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchnyr
{
    internal class Musica
    {
        public string Titulo { get; set; }
        public string Duracao { get; set; }
        public Artista Artista { get; set; }

        public Musica()
        {
        }

        public Musica(string titulo, string duracao, Artista artista)
        {
            Titulo = titulo;
            Duracao = duracao;
            Artista = artista;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
