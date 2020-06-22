using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_All_Az_Alku
{
    class Osszegek
    {
        List<int> osszegek;

        static Random r = new Random();

        public Osszegek()
        {
            osszegek = new List<int>() { 1, 10, 50, 100, 500, 1000, 5000, 10000, 20000, 50000, 100000, 150000, 200000, 300000,
                                          500000, 750000, 1000000, 1500000, 3000000, 5000000, 10000000, 20000000, 50000000 };
        }

        public int Pop()
        {
            int index = r.Next(0, osszegek.Count);
            int ret = osszegek[index];

            osszegek.Remove(ret);

            return ret;
        }
    }
}
