using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadLab2
{
    internal class LongLong : Money
    {
        public LongLong(long rubles, long kopecks) : base(rubles, kopecks)
        {
            Rubles = rubles;
            Kopecks = kopecks;
        }

        // Я не знаю зачем он вообще существует.
        // Я не понял как реализовывать класс Money через другой класс
    }
}
