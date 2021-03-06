using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SudokuSolver {
    public partial class Form1 : Form {
        // Classes that can be accessed by any other class for simplicity sake
        public GraphicsHandler GraphicsHandle;
        private Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
            // An array of the graphical elements to be passed to the GraphicsHandler
            TextBox[] arg = {
                A1, B1, C1, D1, E1, F1, G1, H1, I1,
                A2, B2, C2, D2, E2, F2, G2, H2, I2,
                A3, B3, C3, D3, E3, F3, G3, H3, I3,
                A4, B4, C4, D4, E4, F4, G4, H4, I4,
                A5, B5, C5, D5, E5, F5, G5, H5, I5,
                A6, B6, C6, D6, E6, F6, G6, H6, I6,
                A7, B7, C7, D7, E7, F7, G7, H7, I7,
                A8, B8, C8, D8, E8, F8, G8, H8, I8,
                A9, B9, C9, D9, E9, F9, G9, H9, I9
            };
            GraphicsHandle = new GraphicsHandler(arg);
        }

        private void SolveButtonClicked(object sender, EventArgs e) {
            GraphicsHandle.ReadBoard();
            sw = Stopwatch.StartNew();
            Program.BoardAnalyser.RunAnalysis();
            sw.Stop();
            GraphicsHandle.WriteBoard();
            TimerDisplay.Text = $"{(sw.ElapsedTicks * 1000000) / Stopwatch.Frequency}ns";
        }
    }
}
