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
            for (int y = 0; y < 9; y++) {
                for (int x = 0; x < 9; x++) {
                    InternalRepresentation.Add(new SudokuSquare(x, y));
                }
            }
        }

        public SudokuSquare GetInternalSquare(int x, int y) {
            // This returns the SudokuSquare struct of the appropriate coordinates
            return InternalRepresentation.FirstOrDefault(a => a.X == x && a.Y == y);
        }

        public int[] GetSegmentAnchorCoordinates(int x, int y) { 

            // These functions transform regular x,y to the x,y of the 3x3 grids; ranges from 0,0 to 2,2
            int largeX = 3 * (int)Math.Floor((double)(x / 3));  
            int largeY = 3 * (int)Math.Floor((double)(y / 3));

            // Takes bottom left square (anchor square) of respective coordinates
            return new int[] { largeX, largeY };

        }

        public int[] GetSegmentAnchorCoordinates(SudokuSquare InputSquare) {

            // These functions transform regular x,y to the x,y of the 3x3 grids; ranges from 0,0 to 2,2
            int largeX = 3 * (int)Math.Floor((double)(InputSquare.X / 3));
            int largeY = 3 * (int)Math.Floor((double)(InputSquare.Y / 3));

            // Takes bottom left square (anchor square) of respective coordinates
            return new int[] { largeX , largeY };

        }

        public Func<int, int> GetY = (int Index) => (int)Math.Floor((double)(Index / 9));
        public Func<int, int> GetX = (int Index) => Index % 9;
    }
}
