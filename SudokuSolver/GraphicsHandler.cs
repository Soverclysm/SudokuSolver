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
            GraphicalReference = SudokuBoard;
        }

        public void ReadBoard() {
            for (int i = 0; i < GraphicalReference.Length; i++) {
                if (GraphicalReference[i].Text != "")
                    Program.SudokuSquareHandler.InternalRepresentation[i].RealValue = Convert.ToInt32(GraphicalReference[i].Text);
            }
        }

        private Func<int, int> GetX = (int Index) => Index % 9;
        private Func<int, int> GetY = (int Index) => (int)Math.Floor((double)(Index / 9));
    }
}
