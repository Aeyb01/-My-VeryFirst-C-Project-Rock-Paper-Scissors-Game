// Program.cs script

using System;

class Program
{
    static void Main()
    {
        Rules.Ruler();
        Launch.Play();

        Player player = new Player();

        AI ai = new AI();

        RuleEngine Engine = new RuleEngine();

        while (true)
        {
            string PlayerInput = player.Start();
            if (PlayerInput == null)
            {
                continue;
            }
            string AIInput = ai.Ai();
            Engine.ruleEngine(PlayerInput, AIInput, player, ai);

            if (Engine == null)
            {
                continue;
            }
            continue;
        }
    }
}
