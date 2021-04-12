using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver {
    static class Program {
        public static SudokuSquareHandler SudokuSquareHandler = new SudokuSquareHandler();
        public static BoardAnalyser BoardAnalyser = new BoardAnalyser();
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
