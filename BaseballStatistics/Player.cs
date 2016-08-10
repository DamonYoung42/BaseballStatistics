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
            stats = new double[4];

            for (int i=0; i < stats.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Enter number of singles:");
                        break;                        
                    case 1:
                        Console.WriteLine("Enter number of doubles:");
                        break;
                    case 2:
                        Console.WriteLine("Enter number of triples:");
                        break;
                    case 3:
                        Console.WriteLine("Enter number of home runs:");
                        break;
                }

                stats[i] = Convert.ToDouble(Console.ReadLine());
            }

            
        }

        public string GetPlayerName()
        {
            return this.name;
        }
    }
}
