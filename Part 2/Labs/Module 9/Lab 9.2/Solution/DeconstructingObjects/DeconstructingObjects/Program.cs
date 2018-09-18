using DiscographyLib;
using System;

namespace Wincubate.CS7.DeconstructingObjectsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album(
                "Depeche Mode",
                "Violator",
                new DateTime( 1990, 3, 19 )
            );

            (_, string summary, int age) = album;
            Console.WriteLine( $"{summary} is {age} years old");
        }
    }

    static class AlbumExtensions
    {
        public static void Deconstruct( this Album album, out Guid id, out string summary, out int age )
        {
            id = album.Id;

            summary = $"\"{album.AlbumName}\" by {album.Artist}";

            DateTime today = DateTime.Now;
            age = today.Year - album.ReleaseDate.Year - (album.ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }
}