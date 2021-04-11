using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    public class BoardAnalyser {

        public BoardAnalyser() {
            foreach (SudokuSquare a in Program.SudokuSquareHandler.InternalRepresentation) {
                if (a.RealValue != -1) UpdatePotentialValues(a);
            }
        }

        private void UpdatePotentialValues(SudokuSquare HintSquare) {
            SudokuSquare SquareBeingChecked;
            for (int x = 0; x < 9; x++) {
                SquareBeingChecked = Program.SudokuSquareHandler.GetInternalSquare(x, HintSquare.Y);
                if (SquareBeingChecked.RealValue == -1) {

                }
                
            }
        }

    }
}
