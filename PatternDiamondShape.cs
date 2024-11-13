using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternDiamondShape : Pattern
    {
        public PatternDiamondShape() { }

        public PatternDiamondShape(int sizePatternDiamondShape)
        {
            SizeDiamondShape = sizePatternDiamondShape;
        }

        private int sizeDiamondShape;

        public int SizeDiamondShape
        {
            get { return sizeDiamondShape; }
            set { sizeDiamondShape = value; }
        }

        public override int GetPatternSize()
        {
            return SizeDiamondShape;
        }

        public override void PatternAlgo()
        {
            int diamondSize;
            diamondSize = SizeDiamondShape;
            int midDiamondSize;
            midDiamondSize = (diamondSize / 2) + 1;
            int spaceCounter;
            spaceCounter = midDiamondSize - 1;
            int asterickCounter = 1;
            for (int i = 0; i <= diamondSize; i++)
            {
                if (i < midDiamondSize)
                {
                    for (int j = 0; j < spaceCounter; j++)
                    {
                        Console.Write(" ");
                    }
                    spaceCounter = spaceCounter - 1;
                    for (int k = 0; k < asterickCounter; k++)
                    {
                        Console.Write("*");
                    }
                    asterickCounter = asterickCounter + 2;
                    Console.WriteLine();
                }
                if (i == midDiamondSize)
                {
                    spaceCounter = 1;
                    asterickCounter = diamondSize - 2;
                }
                if (i > midDiamondSize)
                {
                    for (int m = 0; m < spaceCounter; m++)
                    {
                        Console.Write(" ");
                    }
                    spaceCounter = spaceCounter + 1;
                    for (int n = 0; n < asterickCounter; n++)
                    {
                        Console.Write("*");
                    }
                    asterickCounter = asterickCounter - 2;
                    Console.WriteLine();
                }
            }
        }
        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for diamond shape pattern of size: {0}", SizeDiamondShape);
        }

    }
}
