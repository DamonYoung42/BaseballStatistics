using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStatistics
{
    class Player
    {
        string name;
        double[] stats;
        List<string> statNames;

        public Player(string name)
        {
            this.name = name;
            this.statNames = new List<string> {"at-bats", "singles", "doubles", "triples", "home runs"};
        }

        public double calculateSluggingPercentage()
        {
            double hits = 0;
            double totalBases = 0;

            for (int i = 1; i < stats.Length; i++)
            {
                hits += stats[i];
                totalBases += (stats[i] * i);
            }
            return (totalBases/stats[0]);
        }

        public void AddPlayerStats()
        {
            stats = new double[5];

            for (int i=0; i < stats.Length; i++)
            {
                Console.WriteLine("Enter number of {0}", this.statNames[i]);
                stats[i] = Convert.ToDouble(Console.ReadLine());
            }

            
        }

        public string GetPlayerName()
        {
            return this.name;
        }

        public string GetPlayerStats()
        {
            return string.Join("/", this.stats);
        }

        public void DisplayPlayerStatistics()
        {
            Console.WriteLine("{0}'s slugging percentage (total bases divided by total at-bats) is {1:.000}", this.GetPlayerName(), this.calculateSluggingPercentage());

        }
    }
}
