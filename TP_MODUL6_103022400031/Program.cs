using System;
using System.Diagnostics;

namespace TP_MODUL6_NIM
{
    class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Error: Judul track tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Error: Judul track maksimal 100 karakter.");

            this.title = title;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Error: Input penambahan play count maksimal 10.000.000.");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine(">> [Exception Ditangkap] Error: Penambahan play count melebihi batas maksimum integer (overflow).");
            }
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
            Console.WriteLine("=== MENGUJI OVERFLOW ===");
            SayaMusicTrack track2 = new SayaMusicTrack("RUDE! - Hearts2Hearts");

            Console.WriteLine("Memulai looping untuk memicu overflow...");
            for (int i = 0; i < 300; i++)
            {
                track2.IncreasePlayCount(10000000);
            }

            Console.WriteLine("\nKondisi akhir track setelah Exception terjadi:");
            track2.PrintTrackDetails();
        }
    }
}