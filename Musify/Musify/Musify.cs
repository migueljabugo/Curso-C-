using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Musify
{
    public static class Musify
    {
        private static List<Song> songs;
        public static List<Song> Songs
        {
            get { return songs; }
            set { songs = value; }
        }

        private static List<Playlist> playlist;
        public static List<Playlist> Playlist
        {
            get { return playlist; }
            set { playlist = value; }
        }

        

        /*public Musify(List<Song> songs, List<Playlist> playlists)
        {
            Songs = songs;
            Playlists = playlists;
        }*/

        /*public Musify()
        {
            Songs = new List<Song>();
            Playlists = new List<Playlist>();
        }*/

        private static string convertSongToString()
        {
            string res = "";
            foreach (Song song in songs)
            {
                res += string.Format("{0}-{1}-{2}-{3}-{4}-{5}\n", song.Name, song.Author, song.Duration, song.Year, song.Genre, song.Score);
            }
            return res;
        }

        private static string convertPlaylistToString()
        {
            string res = "";
            foreach (Playlist playlist in playlist)
            {
                res += string.Format("{0}-", playlist.Name);
                foreach (Song song in playlist.Songs)
                {
                    res += string.Format("{0}:{1}", song.Name, song.Author);
                    if (!song.Equals(playlist.Songs.Last<Song>()))
                    {
                        res += ",";
                    }
                }
                res += "\n";
            }
            for (int i = 0; i < 2; i++)
            {
                
            }
            return res;
        }

        public static void Export(string path)
        {
            string dataResult = "";

            dataResult += convertSongToString();
            dataResult += "*+++*\n";
            dataResult += convertPlaylistToString();
            
            try
            {
                StreamWriter file = File.CreateText(path);
                file.WriteLine(dataResult);
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al abrir o crear el fichero.\n\n\n" + e);
            }
        }

        public static void ImportProfe(string path)
        {
            List<string> lines = ReadFile(path);
            List<string> linesSongs = new List<string>();
            List<string> linesPlaylists = new List<string>();
            bool isPlaylist = false;

            foreach (String line in lines)
            {
                if (line=="*+++*")
                {
                    isPlaylist = true;
                }else
                {
                    if (!isPlaylist)
                    {
                        linesSongs.Add(line);
                    }
                    else
                    {
                        linesPlaylists.Add(line);
                    }
                }
            }

            Songs = new List<Song>();
            Playlist = new List<Playlist>();

            foreach (string lineSong in linesSongs)
            {
                Songs.Add(new Song(lineSong));
            }

            foreach (string line in linesPlaylists)
            {

            }


        }

        public static Song GetSongByNameAndAuthor(string name, string author) {
            Song s = null;
            foreach (Song song in Songs)
            {
                if (song.Name== name && song.Author==author)
                {
                    s= song;
                }
            }
            return s;
        }

        private static List<string> ReadFile(string path)
        {
            List<string> lines = new List<string>();
            try
            {
                StreamReader file = File.OpenText(path);
                string linea = "";
                while (linea != null)
                {
                    if (linea!=null)
                    {
                        lines.Add(file.ReadLine());
                    }
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el fichero\n"+e);
            }
            return lines;
        }

        public static void Import(string path)
        {
            try
            {
                StreamReader file = File.OpenText(path);
                string line = "";
                bool isSong = true;
                while (line != null)
                {
                    if (line != null) { 
                        line = file.ReadLine();
                        //Console.WriteLine(line);
                        Console.WriteLine("'" + line + "'");
                        if (line == "*+++*")
                        {
                            isSong = false;
                        }
                        else if (line == "") { Console.WriteLine("Linea vacia."); }
                        else if (isSong == true)
                        {
                            Songs.Add(new Song(line));
                        }
                        else
                        {
                            string[] data = line.Split('-');
                            string name = data[0];
                            List<Song> songsOfPlaylist = new List<Song>();


                            foreach (string songDataString in data[1].Split(','))
                            {
                                //Console.WriteLine(songDataString);
                                string[] songString = songDataString.Split(':');
                                //Console.WriteLine(songString[0]);
                                //Console.WriteLine(songString[1]);
                                if (Songs.Contains(new Song(songString[0], songString[1])))
                                {
                                    foreach (Song item in Songs)
                                    {
                                        if (item.Equals(new Song(songString[0], songString[1])))
                                        {
                                            //añadimos las canciones a una lista temporal
                                            songsOfPlaylist.Add(item);
                                        }
                                    }
                                }
                            }
                            //creamos la playlist con su nombre y sus canciones
                            playlist.Add(new Playlist(name, songsOfPlaylist));
                        }
                    }
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el fichero.\n\n\n" + e);
            }
        }

        public static void ImprimeDatos()
        {
            string stringData = "**** Canciones ****\n";
            foreach (Song song in Songs)
            {
                stringData += song+"\n";
            }
            stringData += "\n\n**** Playlists ****\n";
            foreach (Playlist playlist in playlist)
            {
                stringData += playlist + "\n";
            }
            Console.WriteLine(stringData);
        }


    }
}
