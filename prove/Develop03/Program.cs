using System;
using System.Text.Json;
using System.Text.Json.Serialization;

//Console.WriteLine("Hello Develop03 World!");
// Clear the Console.
Console.Clear();

// Load Reference
Reference reference = new Reference();
reference.LoadReference();

//Load Scripture
Scripture scripture = new Scripture();
scripture.LoadScriptures();

//Word
Word word = new Word();

Console.Write("Welcome to the Scripture App");

int userOption = 0;

while (userOption != 3)
{
    // Asking for the input 1,2,Q
    // Q to Quit
    // Options
    userOption = UserOption();

    switch (userOption)
    {
        case 1:
            reference.ReferenceDisplay();
            break;

        case 2:
            string script = scripture.RandomScripture();
            string refer1 = reference.GetReference(scripture);

            word.GetRenderedText(scripture);
            word.GetRenderedRefer(scripture);

            while (word._hidden.Count < word._result.Length)//Problem child
            {
                word.Show(refer1);
                word.GetReadKey();
            }
            word.Show(refer1);
            break;

        case 3:
            Console.WriteLine("Thanks for playing!!!!");
            break;

        default:
            Console.WriteLine($"Sorry, Try Again.");
            break;
    }
}
int UserOption()
//The Method to display options to user.
{
    Reference reference = new Reference();
    string options = $@"
        Please select one of the following choices:
        1. Display all availble scriptures references
        2. Randomly select scripture to work on
        3. Quit
        
        What would you like to do? ";

    Console.Write(options);
    string userInput = Console.ReadLine();
    userInput.ToLower();
    int userOption = 0;

    //Block/Catches any int vaules

    try
    {
        if (userInput == "q")
        {
            userInput = "3";
        }
        userOption = int.Parse(userInput);
    }

    catch (FormatException)
    {
        userOption = 0;
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception Error:  {exception.Message}");
    }
    return userOption;

}
