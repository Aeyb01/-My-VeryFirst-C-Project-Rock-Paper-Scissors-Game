// Player.cs

using System;
using System.Linq;


public class Player
{
    public int PlayerScore {get; set;} = 0;
    public string Start()
    {
        string input = "";
        
        Console.Write("Choose: ");

        input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        return input;

    }
}