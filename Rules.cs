// Rules.cs script

using System;
using System.Threading;


public class Rules
{
    public static void Ruler()
    {
        Console.WriteLine("There are three elements in this game.");
        Thread.Sleep(1000);
        Console.WriteLine("Rock, Paper, and Scissors");
		Thread.Sleep(1000); // Wait for 1 second
        Console.WriteLine("Rock beats Scissor.");
		Thread.Sleep(1000);
        Console.WriteLine("Scissor beats Paper.");
		Thread.Sleep(1000);
        Console.WriteLine("Paper beats Rock.");
		Thread.Sleep(1000); 
        Console.WriteLine("And so on!");
		Thread.Sleep(1000);
        Console.WriteLine("To exit the game write: Exit");
        Thread.Sleep(1000);
    }
}