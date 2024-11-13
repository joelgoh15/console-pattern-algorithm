using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternRectangle : Pattern
    {
        public PatternRectangle() { }

        public PatternRectangle(int sizeRowCountPatternRectangle, int sizeColumnCountPatternRectangle)
        {
            SizeRowCountRectangle = sizeRowCountPatternRectangle;
            SizeColumnCountRectangle = sizeColumnCountPatternRectangle;
        }

        private int sizeRowCountRectangle;
        private int sizeColumnCountRectangle;

        public int SizeRowCountRectangle
        {
            get { return sizeRowCountRectangle; }
            set { sizeRowCountRectangle = value; }
        }
        public int SizeColumnCountRectangle
        {
            get { return sizeColumnCountRectangle; }
            set { sizeColumnCountRectangle = value; }
        }

        public override int GetPatternSize()
        {
            if ((SizeRowCountRectangle == 0) && (SizeColumnCountRectangle == 0)) 
            {
                return 0;
            }
            return SizeRowCountRectangle * SizeColumnCountRectangle;
        }

        public override void PatternAlgo()
        {
            int rowCount;
            rowCount = SizeRowCountRectangle;
            int columnCount;
            columnCount = SizeColumnCountRectangle;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for rectangle pattern of row:{0} and column:{1}", SizeRowCountRectangle, SizeColumnCountRectangle);
        }

    }
}
