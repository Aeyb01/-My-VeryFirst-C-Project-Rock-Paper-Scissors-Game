// AI.cs

using System;
using System.Linq;

public class AI
{
    public int AIScore {get; set;} = 0;
    public string Ai()
    {        
        string[] chosen = {"rock", "paper", "scissors"};

        int length = chosen.Length;
        
        Random random = new Random();

        int randomIndex = random.Next(length);

        string randomElement = chosen[randomIndex];
        
        return randomElement;
    }
}