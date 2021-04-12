using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    public class BoardAnalyser {

        public void RunAnalysis() {
            // Checks each square; if it has a value filled in, call UpdatePotentialValues()
            foreach (SudokuSquare a in Program.SudokuSquareHandler.InternalRepresentation) {
                if (a.RealValue != -1) UpdatePotentialValues(a);
            }
            FillObviousSquares();
        }

        // Updates all relevant squares that their value cannot be the same as HintSquare's
        private void UpdatePotentialValues(SudokuSquare HintSquare) {

            // Removes the value of HintSquare from potential values on all squares with same y value
            for (int x = 0; x < 9; x++) {
                Program.SudokuSquareHandler.GetInternalSquare(x, HintSquare.Y).PotentialValues.Remove(HintSquare.RealValue);
            }

            // Removes the value of HintSquare from potential values on all squares with same x value
            for (int y = 0; y < 9; y++) {
                Program.SudokuSquareHandler.GetInternalSquare(HintSquare.X, y).PotentialValues.Remove(HintSquare.RealValue);
            }

            int[] HintSquareCoords = Program.SudokuSquareHandler.GetSegmentAnchorCoordinates(HintSquare);

            // Removes the value of HintSquare from potential values on all squares in the same 3x3 segment
            for (int x = HintSquareCoords[0]; x < HintSquareCoords[0] + 3; x++) {
                for (int y = HintSquareCoords[1]; y < HintSquareCoords[1] + 3; y++) {
                    Program.SudokuSquareHandler.GetInternalSquare(x, y).PotentialValues.Remove(HintSquare.RealValue);
                }
            }

        }

        // If there's only one potential value for a particular square, it'll fill it in
        private void FillObviousSquares() {
            bool Progress = false;
            foreach (SudokuSquare a in Program.SudokuSquareHandler.InternalRepresentation) {
                var arg = Program.SudokuSquareHandler.GetInternalSquare(a.X, a.Y);
                if (a.PotentialValues.Count == 1) {
                    arg.RealValue = a.PotentialValues[0];
                    Progress = true;
                }
            }
            if (Progress) RunAnalysis(); 
        }

    }
}
