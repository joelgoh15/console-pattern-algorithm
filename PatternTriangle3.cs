using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternTriangle3 : Pattern
    {
        public PatternTriangle3() { }

        public PatternTriangle3(int sizePatternTriangle3)
        {
            SizeTriangle3 = sizePatternTriangle3;
        }

        private int sizeTriangle3;

        public int SizeTriangle3
        {
            get { return sizeTriangle3; }
            set { sizeTriangle3 = value; }
        }

        public override int GetPatternSize()
        {
            return SizeTriangle3;
        }

        public override void PatternAlgo()
        {
            int rowCount;
            rowCount = SizeTriangle3;
            for (int i = rowCount; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int k = 0; k <= (rowCount - i); k++)
                {
                    Console.Write(" ");
                }
            }
        }

        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for triangle-3 pattern of size: {0}", SizeTriangle3);
        }

    }
}
