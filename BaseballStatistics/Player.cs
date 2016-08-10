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

        public Player(string name)
        {
            this.name = name;
        }

        public double calculateSluggingPercentage()
        {
            double hits = 0;
            double totalBases = 0;

            for (int i = 0; i < stats.Length; i++)
            {
                hits += stats[i];
                totalBases += stats[i] * (i + 1);
            }
            return (hits / totalBases);
        }

        public void AddPlayerStats()
        {
            stats = new double[] { 40, 13, 5, 16 };
        }

    }
}
