using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternChristmasTree : Pattern
    {
        public PatternChristmasTree() { }

        public PatternChristmasTree(int sizePatternChristmasTree)
        {
            SizeChristmasTree = sizePatternChristmasTree;
        }

        private int sizeChristmasTree;

        public int SizeChristmasTree
        {
            get { return sizeChristmasTree; }
            set { sizeChristmasTree = value; }
        }

        public override int GetPatternSize()
        {
            return SizeChristmasTree;
        }

        public override void PatternAlgo()
        {
            int sectionCounts;
            sectionCounts = 5;
            int maxAstericksCount;
            maxAstericksCount = (sectionCounts * 3) - 1;
            int midAstericksCount = (maxAstericksCount / 2) + 1;
            int emptySpaceCount;
            emptySpaceCount = midAstericksCount - 1;
            int asterickCounter;
            asterickCounter = 1;
            for (int i = 0; i < sectionCounts; i++)
            {
                for (int m = 0; m < 3; m++)
                {
                    for (int j = 0; j < emptySpaceCount; j++)
                    {
                        Console.Write(" ");
                    }
                    emptySpaceCount = emptySpaceCount - 1;
                    for (int k = 0; k < asterickCounter; k++)
                    {
                        Console.Write("*");
                    }
                    asterickCounter = asterickCounter + 2;
                    Console.WriteLine();
                }
                asterickCounter = asterickCounter - 4;
                emptySpaceCount = emptySpaceCount + 2;
            }
            for (int p = 0; p < 2; p++)
            {
                for (int n = 0; n < (midAstericksCount - 2); n++)
                {
                    Console.Write(" ");
                }
                for (int o = 0; o < 3; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for christmas tree pattern of size: {0}", SizeChristmasTree);
        }

    }
}
