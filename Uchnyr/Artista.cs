using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchnyr
{
    internal class Artista
    {
        public int IdArtista { get; set; }
        public string Nome { get; set; }


        public Artista()
        {
        }

        public Artista(int idArtista, string nome)
        {
            IdArtista = idArtista;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            //Permite fazer a comparaçao do nome da combobox com o seu id
            var artista = obj as Artista;
            return artista != null && IdArtista == artista.IdArtista;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
