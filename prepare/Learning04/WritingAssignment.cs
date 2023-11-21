using System;

public class WritingAssignment : Assignment
{
     //Attributes
     private string _title;

     //Constructors
     public WritingAssignment()
     {

     }
     public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
        {
            //Varibles for Writing
            _title = title;
        }
        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            _title = title;
        }
        //Methods
        public string GetWritingInformation()
        {
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }
}