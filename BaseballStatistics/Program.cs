using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player;
            List<Player> roster = new List<Player>();
            bool morePlayers = true;

            while (morePlayers)
            {
                Console.WriteLine("Enter a baseball player's name or 'exit':");
                string userInput = Console.ReadLine();
                    if (userInput.ToLower() != "exit")
                {
                    player = new Player(userInput);
                    player.AddPlayerStats();
                    Console.WriteLine("{0}'s slugging percentage is {1:.000}", player.GetPlayerName(), player.calculateSluggingPercentage());
                    roster.Add(player);
                }
                else
                {
                    morePlayers = false;
                }

            }

            foreach (Player playerID in roster)
            {
                {
                    Console.WriteLine("{0}: {1}/{2:.000}", playerID.GetPlayerName(), playerID.GetPlayerStats(), playerID.calculateSluggingPercentage());
                }
            }
            Console.ReadLine();                
    }
    }
}
