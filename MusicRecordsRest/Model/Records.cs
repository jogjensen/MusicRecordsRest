using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecordsRest.Model
{
    public class Records
    {

        #region Instance fields

        private int _id;
        private string _title;
        private string _artist;
        private int _yop;
        private int _albumRating;

        #endregion

        #region Constructors

        public Records(int id, string title, string artist, int yop, int albumRating)
        {
            _id = id;
            _title = title;
            _artist = artist;
            _yop = yop;
            _albumRating = albumRating;
        }

        public Records()
        { }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public int Yop
        {
            get => _yop;
            set => _yop = value;
        }

        public int AlbumRating
        {
            get => _albumRating;
            set => _albumRating = value;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Yop)}: {Yop}, {nameof(AlbumRating)}: {AlbumRating}";
        }

        #endregion


    }
}
