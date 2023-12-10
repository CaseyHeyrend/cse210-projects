using System;

public class Reception : Event
{
    //Attributes
    private string _rsvpEmail;
    //Constructors
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    //Methods
     public string GetRsvpEmail()
     {
        return _rsvpEmail;
     }

     public string ReturnEventType()
     {
        return "Receptions";
     }
     public string GenerateDetailReception()
     {
        string detailed = GenerateStandardDet() + "\n";
        detailed += "RSVP: " + _rsvpEmail;
        return detailed;
     }
     public string GenerateShortReception()
     {
      string shortReception = "";
      string eventType = ReturnEventType();
      shortReception += "Event Type: " + eventType + "\n";
      shortReception += GenerateShortDes();
      return shortReception;
     }
    
}
