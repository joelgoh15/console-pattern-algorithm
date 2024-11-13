using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatternAlgorithm3
{
    internal abstract class Pattern : IPattern
    {
        public abstract int GetPatternSize();

        public abstract void PatternAlgo();

        public abstract void DisplayMessage();
    }
}
