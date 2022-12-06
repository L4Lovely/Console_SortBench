using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Lotto{
    internal class Program{
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            Console.BufferWidth = 2000;

            List<int> numbers = new List<int>();
            List<int> rowIndex = new List<int>();
            List<int> sortIndex = new List<int>();
            int startPos_x = 4;

            for (int i = 0; i < 50; i++)
            {
                rowIndex.Add(0);
            }

            for (int i = 0; i < 50; i++)
            {
                sortIndex.Add(i);
            }

            DrawFn._DrawMask();

            for (int i = 0; i < 200; i++)
            {
                numbers = CalcFn._RNDNumbers();

                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.SetCursorPosition(startPos_x + rowIndex[numbers[j]], numbers[j] - 1);
                    Console.Write("▆");
                    rowIndex[numbers[j]] += 1;
                }
            }

            Console.ReadLine();
            bool bubbleToggle = true;
            int falsecounter = 0;
            while (bubbleToggle == true)
            {
                falsecounter = 0;
                for (int i = 0; i < rowIndex.Count - 1; i++)
                {
                    int bubble = 0;
                    int indexBubble = 0;
                    if (rowIndex[i] > rowIndex[i + 1])
                    {
                        bubble = rowIndex[i];
                        rowIndex[i] = rowIndex[i + 1];
                        rowIndex[i + 1] = bubble;

                        indexBubble = sortIndex[i];
                        sortIndex[i] = sortIndex[i + 1];
                        sortIndex[i + 1] = indexBubble;
                    }
                }
                for (int i = 0; i < rowIndex.Count - 1; i++)
                {
                    if (rowIndex[i] > rowIndex[i + 1]) { falsecounter += 1; }
                }
                if (falsecounter >= 1) { bubbleToggle = true; }
                else if (falsecounter == 0) { bubbleToggle = false; }
            }

            Console.Clear();

            for (int y = 1; y < sortIndex.Count; y++)
            {
                Console.SetCursorPosition(0, y - 1);
                if (sortIndex[y] < 10)
                {
                    Console.Write("0" + Convert.ToString(sortIndex[y]) + "|");
                }
                else
                {
                    Console.Write(Convert.ToString(sortIndex[y]) + "|");
                }
            }

            for (int i = 1; i < rowIndex.Count; i++)
            {
                for (int j = 0; j < rowIndex[i]; j++)
                {
                    Console.SetCursorPosition(startPos_x + j, i - 1);
                    Console.Write("▆");
                }
            }
        }
    }
}
