using System;

namespace AdventofCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\sam_b\Desktop\AdventofCode\Day1\day_1_input.txt");
            string[] values = text.Split('\n');
            int iPos = 0;
            int iIncrease = 0;
            int iDay1Part1 = 0;
            int iDay1Part2 = 0;
            int iSum = 0;
            // Day 1 - Part 1
            do
            {
                if (iPos > 0)
                {
                    if (int.Parse(values[iPos]) > int.Parse(values[iPos - 1]))
                    {
                        iDay1Part1++;
                    }
                }

                iPos++;

            } while (values[iPos] != "");

            int iOldSum = 0;

            iPos = 0;

            // Day 1 - Part 2
            do
            {
                if (values[iPos] == "" || values[iPos + 1] == "" || values[iPos + 2] == "")
                {
                    //return;
                }

                iSum = int.Parse(values[iPos]) + int.Parse(values[iPos + 1]) + int.Parse(values[iPos + 2]);

                if (iPos > 0)
                {
                    if (iSum > iOldSum)
                    {
                        iDay1Part2++;
                    }
                }

                iOldSum = iSum;

                iPos++;

            } while (values[iPos] != "" && values[iPos + 1] != "" &&  values[iPos + 2] != "");

            System.Console.WriteLine($"Day 1 - Part 1: {iDay1Part1}");
            System.Console.WriteLine($"Day 1 - Part 2: {iDay1Part2}");

            System.Console.ReadKey();
        }
    }
}
