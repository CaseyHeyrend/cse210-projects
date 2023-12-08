//Youtube
using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> vidsList = new List<Video>();

        //Video 1
        Video vid1 = new Video("Who is Grace Hopper? Meet the Queen of Code", "HoneyPot", 608);//Real Video and Comments
        Comment vid1Comment1 = new Comment("mohamedaityoussef9965", "this is great, i love the editing and this a great story, as CS student i'm forever grateful for grace hopper");
        Comment vid1Comment2 = new Comment("whoisryosuke", "Really good energy + inspo for the morning. Great video!");
        Comment vid1Comment3 = new Comment("Climacticc_Chaos", "Kinda ready to hear how she uses the compiler to translate words into binary across transistor logic gates");

        vid1.ListComment(vid1Comment1);
        vid1.ListComment(vid1Comment2);
        vid1.ListComment(vid1Comment3);

        vidsList.Add(vid1);

        //Video 2
        Video vid2 = new Video("How This Guy Uses A.I. to Create Art", "WIRED", 1032);//Real Video and Comments
        Comment vid2Comment1 = new Comment("hanblue4413", "For someone who deals with such abstract and personal concepts, he's amazing at articulating exactly what he's thinking");
        Comment vid2Comment2 = new Comment("austininkosi1494", "This is actually gorgeous. People bash on how computers make everything really easy, with music and art etc. But this is true art. He loves the way it makes the designs, he loves the phenomena. It's beautiful to hear him talk so passionately about A.I. generated art.");
        Comment vid2Comment3 = new Comment("arpitjaiswal3794", "art is an expression of human emotions and feelings and it touch the soul of the watcher, AI can copy and improvise but this art will always loose the essence ,no  matter how beautiful it might seems");

        vid2.ListComment(vid2Comment1);
        vid2.ListComment(vid2Comment2);
        vid2.ListComment(vid2Comment3);

        vidsList.Add(vid2);

        //Video 3
        Video vid3 = new Video("", "", 403);

        Comment vid3Comment1 = new Comment("Adam", "It is Good");
        Comment vid3Comment2 = new Comment("Adam", "It is Good");
        Comment vid3Comment3 = new Comment("Adam", "It is Good");

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