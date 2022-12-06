using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    public class DrawFn
    {
        public static void _DrawMask()
        {
            for (int i = 1; i < 50; i++)
            {

                if (i < 10) { Console.WriteLine("0" + Convert.ToString(i)); }
                else { Console.WriteLine(i); }
            }
            for (int y = 0; y < 49; y++)
            {
                Console.SetCursorPosition(3, y);
                Console.Write("|");
            }
        }
    }
}
