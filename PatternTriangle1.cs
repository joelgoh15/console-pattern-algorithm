using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternTriangle1 : Pattern
    {
        public PatternTriangle1() { }

        public PatternTriangle1(int sizePatternTriangle1)
        {
            SizeTriangle1 = sizePatternTriangle1;
        }

        private int sizeTriangle1;

        public int SizeTriangle1
        {
            get { return sizeTriangle1; }
            set { sizeTriangle1 = value; }
        }

        public override int GetPatternSize()
        {
            return SizeTriangle1;
        }

        public override void PatternAlgo()
        {
            int rowCount;
            rowCount = SizeTriangle1;

            for (int i = 0; i < rowCount; i++)
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
            Console.Write("algorithm for triangle-1 pattern of size: {0}", SizeTriangle1);
        }

    }
}
