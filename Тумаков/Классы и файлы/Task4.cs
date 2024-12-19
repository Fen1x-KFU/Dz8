using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    public class Song
    {
        public string name;
        public string author;
        public Song prev;

        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.prev = null;
        }

        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        //Создадим конструктор для того, чтобы не было ошибки!
        public Song()
        {
            // Инициализация объекта без параметров
            name = "";
            author = "";
            prev = null;
        }

        public string Title()
        {
            return $"{name} - {author}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song other = (Song)obj;
            return name.Equals(other.name) && author.Equals(other.author);
        }
    }
}
