using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class PatternCheckerBoard : Pattern
    {
        public PatternCheckerBoard() { }

        public PatternCheckerBoard(int sizePatternCheckerBoard)
        {
            SizeCheckerBoard = sizePatternCheckerBoard;
        }

        private int sizeCheckerBoard;

        public int SizeCheckerBoard
        { 
            get { return sizeCheckerBoard; } 
            set {  sizeCheckerBoard = value; }
        }

        public override int GetPatternSize()
        {
            return SizeCheckerBoard; 
        }

        public override void PatternAlgo()
        {
            int rowCount; int columnCount;
            rowCount = SizeCheckerBoard;
            columnCount = SizeCheckerBoard;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount * 2; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
            }
        }
        public override void DisplayMessage()
        {
            Console.WriteLine("algorithm for checkerboard pattern of size: {0}", SizeCheckerBoard);
        }

    }
}
