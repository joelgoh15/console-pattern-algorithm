using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternSquare : Pattern
    {
        public PatternSquare() { }

        public PatternSquare(int sizePatternSquare)
        {
            SizeSquare = sizePatternSquare;
        }

        private int sizeSquare;

        public int SizeSquare
        {
            get { return sizeSquare; }
            set { sizeSquare = value; }
        }

        public override int GetPatternSize()
        {
            return SizeSquare;
        }

        public override void PatternAlgo()
        {
            int rowColumnCount;
            rowColumnCount = SizeSquare;
            for (int i = 0; i < rowColumnCount; i++)
            {
                for (int j = 0; j < rowColumnCount; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for square pattern of size: {0}", SizeSquare);
        }

    }
}
