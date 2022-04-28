// STATIC ATTRIBUTE

namespace cs_ClassGather
{
    class classSong
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "led Zepplin", 15);
            Console.WriteLine(Song.songCount);

        }
    }
}
