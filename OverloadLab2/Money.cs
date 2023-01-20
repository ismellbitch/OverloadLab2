using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadLab2
{
    internal class Money
    {
        public long Rubles { get; set; }
        public long Kopecks { get; set; }

        public Money(long rubles, long kopecks)
        {
            Rubles = rubles;
            Kopecks = kopecks;
        }

        public static Money operator + (Money money1, Money money2)
        {
            if (money1.Kopecks + money2.Kopecks > 99)
            {
                long KopecksToRubles = (money1.Kopecks + money2.Kopecks) / 100;
                return new Money(money1.Rubles + money2.Rubles + KopecksToRubles, money1.Kopecks + money2.Kopecks - KopecksToRubles * 100); 
            }
            else return new Money(money1.Rubles + money2.Rubles, money1.Kopecks + money2.Kopecks);
        }
        public override string? ToString()
        {
            if (Kopecks < 10) return this.Rubles + ",0" + this.Kopecks;
            return this.Rubles + "," + this.Kopecks;
        }
    }
}
