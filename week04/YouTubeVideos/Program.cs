using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.Clear();
        Video vid1 = new Video("JD Vance Makes Host Go Quiet", "The Rubin Report", 62);
        Comment com1 = new Comment("@livingfortheplot", "Puerto Rico has avocados, coffee, and sugar. It needs money and jobs and it's part of the U.S. We'll be ok.");
        vid1.AddComment(com1);
        Comment com2 = new Comment("@anne-marienordin7636", "Make Vance the next president!");
        vid1.AddComment(com2);
        Comment com3 = new Comment("@CinematicVoiceActor1971", "America is closing its blank checkbook");
        vid1.AddComment(com3);
        videos.Add(vid1);

        Video vid2 = new Video("How Blake Lively Ended Her Own Career", "Brett Cooper", 45);
        Comment com4 = new Comment("@Pamela-t4x", "I'm sorry but I want it televised. The Amber Herd trial was pure gold, I believe this one would be equally as entertaining.");
        vid2.AddComment(com4);
        Comment com5 = new Comment("@MichaelOrtega", "1.2 million and only at her second episode is amazing. Brett is on a roll!");
        vid2.AddComment(com5);
        Comment com6 = new Comment("@The RealTomCruise1", "Love the new longer episodes Brett!");
        vid2.AddComment(com6);
        Comment com7 = new Comment("@OceanzyOfficial", "Literally love that you're back, the Internet is healing!");
        vid2.AddComment(com7);
        videos.Add(vid2);

        




    }
}