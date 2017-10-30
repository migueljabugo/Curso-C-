using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify
{
    public class Song
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private string author;
        public string Author
        {
            get { return author; }
        }

        private int duration;
        public int Duration
        {
            get { return duration; }
        }

        private int year;
        public int Year
        {
            get { return year; }
        }

        private Genre genre;
        public Genre Genre
        {
            get { return genre; }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    this.score = value;
                }
                else { Console.WriteLine("Puntuación no valida."); }
            }
        }

        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public Song(string name, string author, int duration, int year, Genre genre, int score)
        {
            this.name = name;
            this.author = author;
            if (duration >= 0)
            {
                this.duration = duration;
            }
            else { Console.WriteLine("Duración no valida."); }

            if (year >= 1800 && year <= 2017)
            {
                this.year = year;
            }
            else { Console.WriteLine("Año no valido."); }

            this.genre = genre;

            if (score >= 0 && score <= 5)
            {
                this.score = score;
            }
            else
            {
                Console.WriteLine("Puntuación no valida.");
            }
        }

        public Song(string dataString)
        {
            string[] data = dataString.Split('-');
            this.name = data[0];
            this.author = data[1];
            this.duration = int.Parse(data[2]);
            this.year = int.Parse(data[3]);
            this.genre = (Genre)Enum.Parse(typeof(Genre), data[4]);
            this.score = int.Parse(data[5]);
        }

        public override bool Equals(object obj)
        {
            if (obj is Song)
            {
                Song aux = (Song)obj;
                if (aux.Name == this.Name && aux.Author == this.Author)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} - ({1} - {2}). {3}", Name, Author, Year, Score);
        }




    }
}
