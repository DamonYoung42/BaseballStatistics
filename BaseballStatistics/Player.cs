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
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Enter number of at-bats:");
                        break;                        
                    case 1:
                        Console.WriteLine("Enter number of singles:");
                        break;
                    case 2:
                        Console.WriteLine("Enter number of doubles:");
                        break;
                    case 3:
                        Console.WriteLine("Enter number of triples:");
                        break;
                    case 4:
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

        public string GetPlayerStats()
        {
            return string.Join("/",this.stats);
        }
    }
}
