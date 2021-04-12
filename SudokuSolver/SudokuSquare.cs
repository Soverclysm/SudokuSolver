using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    // This class is a struct that stores all information about one particular sudoku square
    // Including coordinates, potential values and real value

    public class SudokuSquare {
        public SudokuSquare(int x, int y) { // uses mathematical graph coordinates, not programmatic ones
            X = x;
            Y = y;
            PotentialValues = new List<int> {1,2,3,4,5,6,7,8,9};
            RealValue = -1; // -1 represents no given value, will be an exception in code using this data
        }

        public int X, Y;
        public List<int> PotentialValues;
        public int RealValue;
    }
}
