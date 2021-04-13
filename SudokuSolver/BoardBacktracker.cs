using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    public class BoardBacktracker {
        public bool Backtrack(List<SudokuSquare> SudokuBoard) {

            SudokuSquare TrialSquare = new SudokuSquare(9,9);

            // Find the next square which is not yet filled in
            foreach (SudokuSquare SS in SudokuBoard) {
                if (SS.RealValue == -1) {
                    TrialSquare = SS;
                    break;
                }
            }

            // If no square was found in above loop (the grid is full), terminate
            if (TrialSquare.X == 9) return true;

            // Try every value in the given square
            for (int i = 1; i < 10; i++) {
                List<SudokuSquare> PlaceholderSudokuBoard = SudokuBoard;
                if (TrialSquare.PotentialValues.Contains(i)) TrialSquare.RealValue = i;
                // Recurse the function... if the number that we tried was wrong, go to next one
                if (Backtrack(PlaceholderSudokuBoard)) return true;
            }
            return false;
        }
    }
}
