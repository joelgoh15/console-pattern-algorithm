using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternTriangle4 : Pattern
    {
        public PatternTriangle4() { }

        public PatternTriangle4(int sizePatternTriangle4)
        {
            SizeTriangle4 = sizePatternTriangle4;
        }

        private int sizeTriangle4;

        public int SizeTriangle4
        {
            get { return sizeTriangle4; }
            set { sizeTriangle4 = value; }
        }

        public override int GetPatternSize()
        {
            return SizeTriangle4;
        }

        public override void PatternAlgo()
        {
            int rowCount;
            rowCount = SizeTriangle4;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < (rowCount - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for triangle-4 pattern of size: {0}", SizeTriangle4);
        }


    }
}
