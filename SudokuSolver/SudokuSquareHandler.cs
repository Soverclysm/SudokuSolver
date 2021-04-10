using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    public class SudokuSquareHandler {

        // This list holds all instances of internal representations of sudoku squares
        public List<SudokuSquare> InternalRepresentation = new List<SudokuSquare>();

        public SudokuSquareHandler() {
            for (int x = 0; x < 9; x++) {
                for (int y = 0; y < 9; y++) {
                    InternalRepresentation.Add(new SudokuSquare(x, y));
                }
            }
        }

        public SudokuSquare GetInternalSquare(int x, int y) {
            // This returns the SudokuSquare struct of the appropriate coordinates
            return InternalRepresentation.First(a => a.X == x && a.Y == y);
        }
    }
}
