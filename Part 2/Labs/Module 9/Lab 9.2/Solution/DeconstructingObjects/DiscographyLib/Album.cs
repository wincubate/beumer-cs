using System;

namespace DiscographyLib
{
    public sealed class Album
    {
        public Guid Id { get; }
        public string Artist { get; }
        public string AlbumName { get; }
        public DateTime ReleaseDate { get; }

        public Album( string artist, string albumName, DateTime releaseDate )
        {
            Id = Guid.NewGuid();
            Artist = artist;
            AlbumName = albumName;
            ReleaseDate = releaseDate;
        }
    }
}
