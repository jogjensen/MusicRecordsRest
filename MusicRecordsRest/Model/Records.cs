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
        private string albumRating;
        private string songName;
        private double length;


        #endregion

        #region Constructors
        public Records(string title, string artist, int yop, string albumRating, string songName, double length)
        {
            this.title = title;
            this.artist = artist;
            this.yop = yop;
            this.albumRating = albumRating;
            this.songName = songName;
            this.length = length;
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

        public string AlbumRating
        {
            get => albumRating;
            set => albumRating = value;
        }

        public string SongName
        {
            get => songName;
            set => songName = value;
        }

        public double Length
        {
            get => length;
            set => length = value;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Yop)}: {Yop}, {nameof(AlbumRating)}: {AlbumRating}, {nameof(SongName)}: {SongName}, {nameof(Length)}: {Length}";
        }

        #endregion


    }
}
