using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Song, which holds the following information about songs: Type List, Name and Time.
            //On the first line you will receive the number of songs - N.
            //On the next N-lines you will be receiving data in the following format: "{typeList}_{name}_{time}".
            //On the last line you will receive Type List / "all". Print only the Names of the songs, which are 
            //from that Type List / All songs. 
            //    3
            //    favourite_DownTown_3:14
            //    favourite_Kiss_4:16
            //    favourite_Smooth Criminal_4:01
            //    favourite
            //                                        DownTown
            //                                        Kiss
            //                                        Smooth Criminal
            //    4
            //    favourite_DownTown_3:14
            //    listenLater_Andalouse_3:24
            //    favourite_In To The Night_3:58
            //    favourite_Live It Up_3:48
            //    listenLater
            //                                        Andalouse
            //    2
            //    like_Replay_3:15
            //    ban_Photoshop_3:48
            //    all
            //                                        Replay
            //                                        Photoshop

            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>(numberOfSongs);

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine().Split('_');

                Song song = new Song();
                song.TypeList = songData[0];
                song.Name = songData[1];
                song.Time = songData[2];

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
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
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
