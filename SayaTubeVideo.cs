using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null && title.Length <= 100, "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null");

            this.id = RandomNumber();
            this.title = title;
            this.playCount = 0;
        }

        private int RandomNumber()
        {
            Random random = new Random();
            return random.Next(00000, 99999);
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count > 0 && count <= 10000000, "Input penambahan Play Count 10000000");
            Contract.Requires(playCount <= int.MaxValue - count, "Play Count melebihi jumlah");
            try
            {
                checked
                {
                playCount += count;
                }
            }
            catch (OverflowException)
            {
            Console.WriteLine("Error: Penambahan play count melebihi batas");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Play Count : {playCount}");

        }
}
