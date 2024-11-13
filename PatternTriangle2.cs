using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternTriangle2 : Pattern
    {
        public PatternTriangle2() { }

        public PatternTriangle2(int sizePatternTriangle2)
        {
            SizeTriangle2 = sizePatternTriangle2;
        }

        private int sizeTriangle2;

        public int SizeTriangle2
        {
            get { return sizeTriangle2; }
            set { sizeTriangle2 = value; }
        }

        public override int GetPatternSize()
        {
            return SizeTriangle2;
        }

        public override void PatternAlgo()
        {
            int rowCount;
            rowCount = SizeTriangle2;
            for (int i = rowCount; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for triangle-2 pattern of size: {0}", SizeTriangle2);
        }

    }
}
