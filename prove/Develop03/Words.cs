using System;

// Code Template for the category for text known as ...
public class Word
{
    //The Variables
    public string _words = "";
    public string _refer = "";
    public string[] _result;
    public List <int> _hidden;

    public Word()
    {

    }
    public Word(string text, string visible)
    {

    }
    
    public void GetRenderedText(Scripture scripture)
    {

    }
    public void GetRenderedRefer(Scripture scripture)
    {

    }
     public void Show(string refer1)
     {
        _refer = refer1;
        Console.Clear();
        Console.Write("Press Space or Enter to hide the word");
        Console.Write("Press 0 to Quit the program.");
        //Console.Write($"{_hidden.Count}, {_result.Length}");
        Console.WriteLine($"{_refer}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new string('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine}");
            }
            else
            {
                Console.Write($"{str}");
            }
        }

     }
     public void GetReadKey()
     {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            // Getting a New Hidden word
            GetNewHiddenWord();

        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
     }
     public void GetNewHiddenWord()
     {
        //var limit =_hidden.Capacity;
        //limit = _result.Length;

        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            GetNewHiddenWord();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);
        }

     }
}