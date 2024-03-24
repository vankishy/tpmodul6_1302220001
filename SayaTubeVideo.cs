using System;

public class SayaTubeVideo
{
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
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
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Play Count : {playCount}");

        }
}
