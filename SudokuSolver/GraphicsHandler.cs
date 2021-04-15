using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver {
    public class GraphicsHandler {
        TextBox[] GraphicalReference = new TextBox[81];
        public GraphicsHandler(TextBox[] SudokuBoard) {
            // Saves all 81 references to the different squares of the board to GraphicalReference for use later on
            GraphicalReference = SudokuBoard;
        }

        public void ReadBoard() {
            // Looks at each square on the graphical board, if it has a value, put that value in the SudokuSquareHandler list
            for (int i = 0; i < GraphicalReference.Length; i++) {
                if (GraphicalReference[i].Text != "")
                    Program.SudokuSquareHandler.InternalRepresentation[i].RealValue = Convert.ToInt32(GraphicalReference[i].Text);
            }
        }

        public void WriteBoard() {
            for (int i = 0; i < Program.SudokuSquareHandler.InternalRepresentation.Count; ++i) {
                GraphicalReference[i].Text = Program.SudokuSquareHandler.InternalRepresentation[i].RealValue.ToString();
            }
        }

        private Func<int, int> GetX = (int Index) => Index % 9;
        private Func<int, int> GetY = (int Index) => (int)Math.Floor((double)(Index / 9));
    }
}
