// See https://aka.ms/new-console-template for more information
using System;

namespace TP_MODUL6_NIM
{
    class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"Track ID   : {this.id}");
            Console.WriteLine($"Title      : {this.title}");
            Console.WriteLine($"Play Count : {this.playCount}");
            Console.WriteLine("---------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("RUDE! - Hearts2Hearts");

            Console.WriteLine("Kondisi Awal:");
            track1.PrintTrackDetails();

            Console.WriteLine("Setelah ditambah play count:");
            track1.IncreasePlayCount(500);
            track1.PrintTrackDetails();
        }
    }
}