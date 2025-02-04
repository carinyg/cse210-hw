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

        Video vid3 = new Video("TRADE WAR and Naked Grammys!", "Ben Shapiro", 50);
        Comment com8 = new Comment("@magwitch1712", "Congratulations Ben on winning Spotify award as #1 Conservative Podcaster with 100 million streams. Well done, you deserve it");
        vid3.AddComment(com8);
        Comment com9 = new Comment("@billm5555", "I love that Marco speaks fluent Spanish. That is going to be invaluable in this region");
        vid3.AddComment(com9);
        Comment com10 = new Comment("@thehunzz", "South Africa isn't a failing state, it's a failed state.");
        vid3.AddComment(com10);
        videos.Add(vid3);

        Video vid4 = new Video("Tariff Threats Get Results, and Absurdity at Grammys and DNC...", "Megyn Kelly", 110);
        Comment com11 = new Comment("@darrenmiller6927", "Keep your NBC, ABC, CNN, etc. We want Megyn! Top news show in the country!");
        vid4.AddComment(com11);
        Comment com12 = new Comment("@redphrmgrl2457", "I love Rick Grenell. Thank you for getting them home!");
        vid4.AddComment(com12);
        Comment com13 = new Comment("@barbaraponton8350", "This is why legacy media is dead, because we are watching Megan for the truth!!");
        vid4.AddComment(com13);
        Comment com14 = new Comment("@alejandraredmond2362", "Mr Grenell is an impressive diplomat!");
        vid4.AddComment(com14);
        videos.Add(vid4);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayVideoAndComments());
        }
    }
}