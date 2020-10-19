using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecordsRest.Model
{
    public class Records
    {

        #region Instance fields
        private string title;
        private string artist;
        private int yop;
        private int albumRating;


        #endregion

        #region Constructors
        public Records(string title, string artist, int yop, int albumRating)
        {
            this.title = title;
            this.artist = artist;
            this.yop = yop;
            this.albumRating = albumRating;
        }

        public Records()
        { }

        #endregion

        #region Properties

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Artist
        {
            get => artist;
            set => artist = value;
        }

        public int Yop
        {
            get => yop;
            set => yop = value;
        }

        public int AlbumRating
        {
            get => albumRating;
            set => albumRating = value;
        }


        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Yop)}: {Yop}, {nameof(AlbumRating)}: {AlbumRating}";
        }

        #endregion


    }
}
