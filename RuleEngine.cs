// RuleEngine.cs

using System;


public enum GameChoice
{
    Rock,
    Paper,
    Scissors,
    Exit
}
class RuleEngine
{
    public void ruleEngine(string PlayerInput, string AIInput, Player player , AI ai)
    {
        GameChoice PlayerChoice = ParseChoice(PlayerInput);
        GameChoice AIChoice = ParseChoice(AIInput);
        if (PlayerChoice == GameChoice.Exit)
        {
            Exit.ExitProgram(player, ai);
        }

        Console.WriteLine($"AI choice: {AIChoice}");

        if (PlayerChoice == AIChoice)
        {
            Console.WriteLine("Tie.");
            player.PlayerScore++;
            ai.AIScore++;
        }

        else if (PlayerChoice == GameChoice.Rock && AIChoice == GameChoice.Scissors || 
            PlayerChoice == GameChoice.Paper && AIChoice == GameChoice.Rock ||
            PlayerChoice == GameChoice.Scissors && AIChoice == GameChoice.Paper)
        {
            Console.WriteLine("Player wins!");
            player.PlayerScore++;
        }
        else
        {
            Console.WriteLine("Ai wins!");
            ai.AIScore++;
        }
        
    }

    GameChoice ParseChoice(string input)
    {
        string lower = input.ToLower();

        return lower switch
        {
            "rock" => GameChoice.Rock,
            "paper" => GameChoice.Paper,
            "scissors" => GameChoice.Scissors,
            "exit" => GameChoice.Exit,
            _=> throw new ArgumentException("Invalid choice.")
        };
    }
}