using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchnyr
{
    internal class Playlist
    {

        public static readonly int MAX_ARTISTAS = 100;
        public static readonly int MAX_MUSICAS = 500;
        public Artista[] Artistas { get; set; }
        public Musica[] Musicas { get; set; }
        public int nArtistas { get; set; }
        public int nMusicas { get; set; }

        public Playlist()
        {
            Artistas = new Artista[MAX_ARTISTAS];
            Musicas = new Musica[MAX_MUSICAS];
            this.nArtistas = 0;
            this.nMusicas = 0;
        }

        public void AdicionaCategoria(Artista e)
        {
            Artistas[nArtistas++] = e;
        }

        public void AdicionaProduto(Musica e)
        {
            Musicas[nMusicas++] = e;
        }
    }
}
