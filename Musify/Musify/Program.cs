using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>() {
                new Song("Nombre cancion1", "Autor cancion1", 3, 2015, Genre.Classic, 2),
                new Song("Nombre cancion2", "Autor cancion2", 2, 2015, Genre.Jazz, 1),
                new Song("Nombre cancion3", "Autor cancion3", 5, 2011, Genre.Folk, 3),
                new Song("Nombre cancion4", "Autor cancion4", 4, 2000, Genre.Pop, 5),
                new Song("Nombre cancion5", "Autor cancion5", 3, 2005, Genre.Metal, 4)
            };
            List<Playlist> playlists = new List<Playlist>() {
                new Playlist("Playlist1", songs),
                new Playlist("Playlist2", songs),
                new Playlist("Playlist3", songs)
            };

            Musify.Songs = songs;
            Musify.Playlist = playlists;
            Musify.ImprimeDatos();

            string rutaFichero = "../../musify.txt";
            Console.WriteLine("Exportando al fichero: " + rutaFichero);
            Musify.Export(rutaFichero);
            Console.WriteLine("Leyendo fichero: " + rutaFichero);

            Musify.Import(rutaFichero);
            


            Console.ReadLine();
        }
    }


}
