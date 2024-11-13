using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.WriteLine("Welcome.");
            Console.WriteLine("Console app that does pattern algorithm.");

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternCheckerBoard patternCheckerBoard = new PatternCheckerBoard(8);
            patternCheckerBoard.DisplayMessage();
            patternCheckerBoard.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternTriangle1 patternTriangle1 = new PatternTriangle1(10);
            patternTriangle1.DisplayMessage();
            patternTriangle1.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternTriangle2 patternTriangle2 = new PatternTriangle2(10);
            patternTriangle2.DisplayMessage();
            patternTriangle2.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternTriangle3 patternTriangle3 = new PatternTriangle3(10);
            patternTriangle3.DisplayMessage();
            patternTriangle3.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternTriangle4 patternTriangle4 = new PatternTriangle4(10);
            patternTriangle4.DisplayMessage();
            patternTriangle4.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternSquare patternSquare = new PatternSquare(7);
            patternSquare.DisplayMessage();
            patternSquare.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternRectangle patternRectangle = new PatternRectangle(9, 7);
            patternRectangle.DisplayMessage();
            patternRectangle.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternDiamondShape patternDiamondShape = new PatternDiamondShape(9);
            patternDiamondShape.DisplayMessage();
            patternDiamondShape.PatternAlgo();

            Console.Write("\n\n");
            Console.Write("Press any key to continue:"); Console.ReadLine();
            PatternChristmasTree patternChristmasTree = new PatternChristmasTree(9);
            patternChristmasTree.DisplayMessage();
            patternChristmasTree.PatternAlgo();

            Console.Write("\n\n\n");
            Console.Write("press any key to exit:");
            Console.ReadLine();

        }//end-main

    }//end-class
}//end-namespace
