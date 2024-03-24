class Program
{
    static void Main()
    {
        SayaTubeVideo video = null;

        try
        {
            video = new SayaTubeVideo("Tutorial Design by Contract - Reinhard Situmeang");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}