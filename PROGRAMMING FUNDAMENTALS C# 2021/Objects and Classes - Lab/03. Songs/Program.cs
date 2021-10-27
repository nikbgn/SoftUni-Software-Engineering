using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song() { TypeList = type, Name = name, Time = time };

                songs.Add(song);
            }


            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                //Filtering the list using System.LINQ 
                List<Song> filteredSongList = songs.Where(s => s.TypeList == typeList).ToList();

                foreach (Song song in filteredSongList)
                {
                    Console.WriteLine(song.Name);
                }

            }



        }
    }


    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
