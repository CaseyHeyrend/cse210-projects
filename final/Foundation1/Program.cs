//Youtube
using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> vidsList = new List<Video>();

        //Video 1
        Video vid1 = new Video("How to care for trees", "Meadow Le", 310);
        Comment vid1Comment1 = new Comment("Uriah Waters", "I didn't know there was so much info for taking care of trees.");
        Comment vid1Comment2 = new Comment("Emmy Bean", "The knowledge of taking care of something is incredible to know about.");
        Comment vid1Comment3 = new Comment("Grant Montoya", "Picking where the tree is going to go is important and stay on the decision for the tree.");

        vid1.ListComment(vid1Comment1);
        vid1.ListComment(vid1Comment2);
        vid1.ListComment(vid1Comment3);

        vidsList.Add(vid1);

        //Video 2
        Video vid2 = new Video("What not to do with trees care", "Molly Carpenter", 500);
        Comment vid2Comment1 = new Comment("Ross Erickson", "Oh, trees need lots of water to live. Note to self.");
        Comment vid2Comment2 = new Comment("Miley Potter", "Spacing for the tree so it can grow and trimming is good as well.");
        Comment vid2Comment3 = new Comment("Cale Goodman", "Sometimes you gonna make a mistake and take a mulch needed a break.");

        vid2.ListComment(vid2Comment1);
        vid2.ListComment(vid2Comment2);
        vid2.ListComment(vid2Comment3);

        vidsList.Add(vid2);

        //Video 3
        Video vid3 = new Video("What you need to care for trees guide", "Coby Bush", 603);
        Comment vid3Comment1 = new Comment("Heath Paul", "Trees can get sick!");
        Comment vid3Comment2 = new Comment("Karen Bell", "There is tree food. Is it the same as plant food?");
        Comment vid3Comment3 = new Comment("Jeremy Blender", "There are many different products, and some are quite similar to each other.");

        vid3.ListComment(vid3Comment1);
        vid3.ListComment(vid3Comment2);
        vid3.ListComment(vid3Comment3);

        vidsList.Add(vid3);

        foreach (Video video in vidsList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
            
        }
        
    }
}
