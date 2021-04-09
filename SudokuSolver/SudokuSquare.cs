using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    // This class is a struct that stores all information about one particular sudoku square
    // Including coordinates, potential values and real value
    public struct SudokuSquare {
        public SudokuSquare(int x, int y) { // x and y are oriented bottom left to top right, 0-based ie 0,0 to 8,8
            X = x;
            Y = y;
            PotentialValues = new List<int> {1,2,3,4,5,6,7,8,9}; // All values are assumed to be possible when grid initialised
            RealValue = -1; // -1 represents no given value, will be an exception in code using this data
        }

        public int X, Y;
        public List<int> PotentialValues;
        public int RealValue;
    }
}
