using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStatistics
{
    class BaseballDataEntry
    {
        Player player;
        List<Player> roster = new List<Player>();
        bool morePlayers = true;

        public BaseballDataEntry()
        {

        }

        public void RunDataEntry()
        {
            while (morePlayers)
            {
                Console.WriteLine("Enter a baseball player's name or 'exit':");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    player = new Player(userInput);
                    player.AddPlayerStats();
                    player.DisplayPlayerStatistics();
                    roster.Add(player);
                }
                else
                {
                    morePlayers = false;
                }

            }

            DisplayRoster();


        }

        public void DisplayRoster()
        {
            foreach (Player name in roster)
            {
                {
                    Console.WriteLine("{0}: {1}/{2:.000}", name.GetPlayerName(), name.GetPlayerStats(), name.calculateSluggingPercentage());
                }
            }
            Console.ReadLine();
        }


    }
}
