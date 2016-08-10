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

            Console.WriteLine("Enter a baseball player's name:");
            player = new Player(Console.ReadLine());
            player.AddPlayerStats();
            Console.WriteLine("{0}'s slugging percentage is {1:.000}", player.GetPlayerName(), player.calculateSluggingPercentage());
            Console.ReadLine();                
    }
    }
}
