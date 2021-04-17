using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    public class BoardBacktracker {
        public bool Backtrack() {

            SudokuSquare TrialSquare = new SudokuSquare(9,9);
            SudokuSquareHandler PlaceholderSudokuBoard = Program.SudokuSquareHandler;

            // Find the next square which is not yet filled in
            foreach (SudokuSquare SS in PlaceholderSudokuBoard.InternalRepresentation) {
                if (SS.RealValue == -1) {
                    TrialSquare = SS;
                    break;
                }
            }

            // If no square was found in above loop (the grid is full), terminate
            if (TrialSquare.X == 9) return true;

            // Try every value in the given square
            for (int i = 1; i < 10; i++) {
                if (TrialSquare.PotentialValues.Contains(i) && IsAvailable(PlaceholderSudokuBoard, TrialSquare, i)) {
                    TrialSquare.RealValue = i;
                    // Recurse the function... if the number that we tried was wrong, go to next one
                    if (Backtrack()) return true;
                }
            }
            return false;
        }

        public bool IsAvailable(SudokuSquareHandler SudokuBoard, SudokuSquare EntrySquare, int AttemptedValue) {
            int[] AnchorCoords = Program.SudokuSquareHandler.GetSegmentAnchorCoordinates(EntrySquare);

            // Check squares aligned on the y axis for the value
            for (int x = 0; x < 9; x++) {
                if (SudokuBoard.GetInternalSquare(x, EntrySquare.Y).RealValue == AttemptedValue) return false; 
            }

            // Check squares aligned on the x axis for the value
            for (int y = 0; y < 9; y++) {
                if (SudokuBoard.GetInternalSquare(EntrySquare.X, y).RealValue == AttemptedValue) return false;
            }

            // Check squares in the same 3x3 segment for the value
            for (int x = AnchorCoords[0]; x < AnchorCoords[0] + 3; ++x) {
                for (int y = AnchorCoords[1]; y < AnchorCoords[1] + 3; ++y) {
                    if (SudokuBoard.GetInternalSquare(x, y).RealValue == AttemptedValue) return false;
                }
            }
            return true;
        }
    }
}
