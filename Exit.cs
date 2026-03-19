// Exit.cs

using System;
using System.Diagnostics.CodeAnalysis;


class Exit
{
    static public void ExitProgram(Player player, AI ai)
    {

        int PlayerScore = player.PlayerScore;
        int AIScore = ai.AIScore;

        Console.WriteLine($"Player's score: {PlayerScore}");
        Console.WriteLine($"AI's score: {AIScore}");

        if (PlayerScore > AIScore)
        {
            Console.WriteLine("Winner is: Player!");
        }
        else if (AIScore > PlayerScore)
        {
            Console.WriteLine("Winner is: AI!");
        }
        else
        {
            Console.WriteLine("Tie!");
        }

        Environment.Exit(0); 
    }
}