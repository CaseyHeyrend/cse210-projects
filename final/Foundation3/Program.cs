// Events
using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("Hello Foundation3 World!");

       //Lecture
       Address addressL = new Address("2014 Lady Bug Drive", "Queens", "NY", "USA");

       Lecture lecture = new Lecture("Literary Reading: ", "", "April 22, 2024", "9 AM", addressL, "", 100);
       Console.WriteLine();

       Console.WriteLine("Event Number: 1");
       Console.WriteLine();
       Console.WriteLine(lecture.GenerateStandardDet());

       Console.WriteLine();
       Console.WriteLine(lecture.GenerateDetailLect());

       Console.WriteLine();
       Console.WriteLine(lecture.GenerateShortLect());

       // Reception
       Address addressR = new Address("4958 Cambridge Place", "Lutz", "FL", "USA");
       Reception reception = new Reception("", "", "May 18, 2024", "9 PM", addressR, "");
       Console.WriteLine();

       Console.WriteLine("Event Number: 2");
       Console.WriteLine();
       Console.WriteLine(reception.GenerateStandardDet());

       Console.WriteLine();
       Console.WriteLine(reception.GenerateDetailReception());

       Console.WriteLine();
       Console.WriteLine(reception.GenerateShortReception());

       //Outdoor Gathering
       Address addressOG = new Address("2726 Sunset Drive", "Pueblo", "CO", "USA");
       OutdoorGathering outdoorGathering = new OutdoorGathering("", "The Celebration of the Trees", "August 16, 2024", "12 PM", addressOG, "sunny");
       Console.WriteLine();

       Console.WriteLine("Event Number: 3");
       Console.WriteLine();
       Console.WriteLine(outdoorGathering.GenerateStandardDet());

       Console.WriteLine();
       Console.WriteLine(outdoorGathering.GenerateDetailOG());

       Console.WriteLine();
       Console.WriteLine(outdoorGathering.GenerateShortOG());
    }
}
