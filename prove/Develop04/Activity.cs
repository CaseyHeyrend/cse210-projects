using System;
using System.Diagnostics;

// The Head of the Code.
public class Activity
{
    //Variables
    private string _startMessage;//Starting Message
    private string _endMessage;//Ending Message
    private string _activityName;
    private string _activityDescription;
    static int _spinCounter = 0;//Spinner Counter
    static int _userSessionLenInput = 0;//Session Length Input
    //Len = Length

    public Activity()
    {
        _spinCounter = _userSessionLenInput = 0;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public int GetUserSessionLenInput()//Session Length Input
    {
        return _userSessionLenInput;//Session Length Input
    }
    public void DisplayStartMessage()//Starting Message
    {
        _startMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startMessage);
        Console.WriteLine();
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public void DisplayEndMessage()//Ending Message
    {
        _endMessage = $"You have complete {_userSessionLenInput} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine();//.
        Console.WriteLine(_endMessage);
        DisplaySpinner(5);
        Console.Clear();
    }
    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinCounter++;//Spinner Counter
            switch (_spinCounter % 4)
            {
                case 0: Console.Write("/");
                        break;
                case 1: Console.Write("-");
                        break;
                case 2: Console.Write("\\");
                        break;
                case 3: Console.Write("|");
                        break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLen()//Len = Length
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLenInput = int.Parse(Console.ReadLine());
    }
    public void DisplayGetReady()
    {
        Console.WriteLine("Get Ready ...");
        DisplaySpinner(5);
    }
    public void RunActivityParentStart()
    {
        DisplayStartMessage();
        DisplayDescription();
        DisplayGetSessionLen();
        DisplayGetReady();
        Console.Clear();
    }
    public void RunActivityParentEnd()
    {
        DisplayEndMessage();
    }
}