using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify
{
    public class Playlist
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }



        public int SongCount
        {
            get { return Songs.Count; }
        }

        private List<Song> list;

        public List<Song> Songs
        {
            get { return list; }
            set { list = value; }
        }

        public Playlist(string name, List<Song> songs)
        {
            this.name = name;
            this.Songs = songs;
        }

        public Playlist()
        {
            this.name = "Unknow";
            this.Songs = new List<Song>();
        }

        public Playlist(string dataString)
        {
            string[] splitterData = dataString.Split('-');
            this.name = splitterData[0];
            string[] splitterSongs = splitterData[1].Split(',');
            foreach (string songString in splitterSongs)
            {
                string[] splitterSong = songString.Split(':');
                string songName = splitterSongs[0];
                string authorName = splitterSongs[1];
                Musify.GetSongByNameAndAuthor(songName, authorName);
            }

        }

        public bool exitsSongOnPlaylist(Song song)
        {
            return this.Songs.Contains(song);
        }


        public override string ToString()
        {
            string res = string.Format("--- {0} ---\n", this.Name);
            foreach (Song song in Songs)
            {
                res += string.Format(" - {0}\n", song);
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            if (obj is Playlist)
            {
                Playlist aux = (Playlist)obj;
                if (this.Name == aux.Name && this.Songs.Count == aux.Songs.Count)
                {
                    foreach (Song song in this.Songs)
                    {
                        if (!aux.Songs.Contains(song))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public int TotalDuration()
        {
            int totalDurarion = 0;
            foreach (Song song in Songs)
            {
                totalDurarion += song.Duration;
            }
            return totalDurarion;
        }

        public float AverageScore()
        {
            int acum = 0;
            foreach (Song song in Songs)
            {
                acum += song.Score;
            }
            return acum / (float)Songs.Count;
        }

    }
}
