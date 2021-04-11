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

        //  You can use bruteforce solving for an entire sudoku, but I find this an unelegant solution
        //  Therefore, I will instead be using a hybrid method of analytical and bruteforce
        //  The program will attempt to complete the sudoku primarily by analytical means:
        //  analytical implying the usage of grounded principles
        //  and bruteforce implying the usage of high computational force to complete the problem.
        //  If the program fails to complete the sudoku analytically, it will only then resort to bruteforce.

    }
}
