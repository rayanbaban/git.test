using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiii
{
    class artistInfo
    {
        public string artistNavn;
        public string albumNavn;
        public int utgivelseÅr;
        public float albumSolgt;
    
        public artistInfo (string argArtistNavn, string argAlbumNavn, int argUtgivelsesÅr, float argAlbumSolgt)
        {
            artistNavn = argArtistNavn;
            albumNavn = argAlbumNavn;
            utgivelseÅr = argUtgivelsesÅr;
            albumSolgt = argAlbumSolgt;

        }
    }
}
