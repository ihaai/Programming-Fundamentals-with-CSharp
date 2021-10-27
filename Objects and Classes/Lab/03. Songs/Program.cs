using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string type, string name, string time)
        {
            this.Type = type;
            this.Name = name;
            this.Time = time;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songStorage = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                var newSongInfo = Console.ReadLine().Split("_").ToList();
                songStorage.Add(new Song(newSongInfo[0], newSongInfo[1], newSongInfo[2]));
            }

            var songType = Console.ReadLine();

            foreach(Song sng in songStorage)
            {
                if (sng.Type == songType)
                {
                    Console.WriteLine(sng.Name);
                }

                else if (songType == "all")
                {
                    Console.WriteLine(sng.Name);
                }
            }
        }
    }
}
