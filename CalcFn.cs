using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class CalcFn
    {
        public static List<int> _RNDNumbers()
        {
            List<int> rnd_ints = new List<int>();
            Random rnd = new Random();
            do
            {
                int NUM = _RNDSingle(1);
                if (!rnd_ints.Contains(NUM))
                {
                    rnd_ints.Add(NUM);
                }
            } while (rnd_ints.Count < 6);
            //do
            //{
            //    int NUM = rnd.Next(1, 9);
            //    if (!rnd_ints.Contains(NUM)){
            //        rnd_ints.Add(NUM);
            //    }
            //} while (rnd_ints.Count < 7);
            return rnd_ints;
        }
        public static int _RNDSingle(int passes)
        {
            int rndNUM = 0;
            Random rnd = new Random();

            for (int i = 0; i < passes; i++)
            {
                rndNUM = rnd.Next(1, 50);
            }
            return rndNUM;
        }
    }
}
