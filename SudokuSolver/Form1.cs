using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver {
    public partial class Form1 : Form {
        public SudokuSquareHandler SudokuSquareHandler = new SudokuSquareHandler();
        public BoardAnalyser BoardAnalyser = new BoardAnalyser();
        public GraphicsHandler GraphicsHandler;
        public Form1() {
            InitializeComponent();
            TextBox[] arg = {
                A1, B1, C1, D1, E1, F1, G1, H1,
                A2, B2, C2, D2, E2, F2, G2, H2,
                A3, B3, C3, D3, E3, F3, G3, H3,
            };
        }

        private void SolveButtonClicked(object sender, EventArgs e) {
            
        }
    }
}
