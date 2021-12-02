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

            int iDay1Part1 = 0;
            int iDay1Part2 = 0;
            int iDay2Part1 = 0;
            int iDay2Part2 = 0;

            int iSum = 0;

            // Day 1 - Part 1
            /*
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
            */
            // Day 2 Part 1
            text = System.IO.File.ReadAllText(@"C:\Users\sam_b\Desktop\AdventofCode\Day2\day_2_input.txt");
            values = text.Split('\n');
            
            iPos = 0;

            int iHoriz = 0;
            int iDepth = 0;
            string[] cInstruction;

            do
            {
                cInstruction = values[iPos].Split(" ");

                if (cInstruction[0] =="up")
                {
                    iDepth = iDepth - int.Parse(cInstruction[1]);
                }
                else if (cInstruction[0] == "down")
                {
                    iDepth = iDepth + int.Parse(cInstruction[1]);
                }
                else if (cInstruction[0] == "forward")
                {
                    iHoriz = iHoriz + int.Parse(cInstruction[1]);
                }

                iPos++;

            } while (values[iPos] != "");

            iDay2Part1 = iHoriz * iDepth;

            // Day 2 Part 2
            iPos = 0;
            iHoriz = 0;
            iDepth = 0;
            int iAim = 0;
            do
            {
                cInstruction = values[iPos].Split(" ");

                if (cInstruction[0] == "up")
                {
                   // iDepth = iDepth - int.Parse(cInstruction[1]);
                    iAim   = iAim - int.Parse(cInstruction[1]);
                }
                else if (cInstruction[0] == "down")
                {
                    //iDepth = iDepth + int.Parse(cInstruction[1]);
                    iAim = iAim + int.Parse(cInstruction[1]);
                }
                else if (cInstruction[0] == "forward")
                {
                    iHoriz = iHoriz + int.Parse(cInstruction[1]);
                    iDepth = iDepth + (iAim * int.Parse(cInstruction[1]));
                }

                iPos++;

            } while (values[iPos] != "");

            iDay2Part2 = iHoriz * iDepth;

            System.Console.WriteLine($"Day 1 - Part 1: {iDay1Part1}");
            System.Console.WriteLine($"Day 1 - Part 2: {iDay1Part2}");
            System.Console.WriteLine($"Day 1 - Part 2: {iDay2Part1}");
            System.Console.WriteLine($"Day 2 - Part 2: {iDay2Part2}");



            System.Console.ReadKey();
        }
    }
}
