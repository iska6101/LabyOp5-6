using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LabaOP6
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private gameSymbol[,] _gameGrid;
        private int _gridSize;
        private int _pointForWin;
        private gameSymbol move = gameSymbol.X;

        public int GridSize
        {
            get { return _gridSize; }
            set { _gridSize = value; }

        }
        public int PointForWin
        {
            set { _pointForWin = value; }
            get { return _pointForWin; }
        }

        private enum gameSymbol
        {
            X = -1,
            Null = 0,
            O = 1
        }
        private void CreateGrid()
        {
            _gameGrid = new gameSymbol[_gridSize, _gridSize];
        }
        private void PrintGrid()
        {
            Console.Clear();
            Console.Write("   ‖");
            for (int i = 1; i <= _gridSize; i++)
            {
                if (i < 10) Console.Write($" {i} |");
                else Console.Write($" {i}|");
            }
            Console.Write("\n====");
            for (int i = 0; i < _gridSize; i++) Console.Write("====");
            Console.WriteLine();
            char symbol = 'A';
            for (int i = 0; i < _gridSize; i++)
            {
                Console.Write($" {symbol++} ‖");
                for (int j = 0; j < _gridSize; j++)
                {
                    Console.Write($" {GetSymbol(_gameGrid[i, j])} |");
                }
                Console.Write("\n----");
                for (int j = 0; j < _gridSize; j++)
                {
                    Console.Write("----");
                }
                Console.WriteLine();
            }

        }
        private static char GetSymbol(gameSymbol v)
        {
            switch (v)
            {
                case gameSymbol.X:
                    return 'X';
                case gameSymbol.O:
                    return 'O';
                default:
                    return ' ';
            }
        }
        private bool CheckLine(int x, int y, int dx, int dy, gameSymbol symbol)
        {
            int count = 0;
            for (int i = -_pointForWin + 1; i < _pointForWin; i++)
            {
                int newX = x + i * dx;
                int newY = y + i * dy;
                if (newX >= 0 && newX < _gridSize && newY >= 0 && newY < _gridSize && _gameGrid[newX, newY] == symbol)
                {
                    count++;
                    if (count == _pointForWin) return true;
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }
        private bool ChekWin(int x, int y)
        {
            gameSymbol symbol = _gameGrid[x, y];
            if (symbol == gameSymbol.Null) return false;

            // Check horizontal
            if (CheckLine(x, y, 0, 1, symbol) || CheckLine(x, y, 0, -1, symbol)) return true;

            // Check vertical
            if (CheckLine(x, y, 1, 0, symbol) || CheckLine(x, y, -1, 0, symbol)) return true;

            // Check diagonal (top-left to bottom-right)
            if (CheckLine(x, y, 1, 1, symbol) || CheckLine(x, y, -1, -1, symbol)) return true;

            // Check diagonal (top-right to bottom-left)
            if (CheckLine(x, y, 1, -1, symbol) || CheckLine(x, y, -1, 1, symbol)) return true;

            return false;
        }
        private bool ChekFullGrid()
        {
            bool gridIsFull = false;
            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < _gameGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < _gameGrid.GetLength(1); j++)
                    {
                        if (_gameGrid[i, j] == gameSymbol.Null)
                        {
                            gridIsFull = true;
                            exit = true;
                        }
                    }
                }
                exit = true;
            }
            return gridIsFull;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_GridSize.Text, out _gridSize) || _gridSize < 2 || _gridSize > 10)
            {
                MessageBox.Show("Uncorrect input data or grid size smallest then 2 and biggest than 10!");
            }
            else if (!int.TryParse(TextBox_PointForWin.Text, out _pointForWin) || _pointForWin < 2 || _pointForWin > _gridSize)
            {
                MessageBox.Show("Uncorrect input data or point for win smallest then 2 and biggest than grid size!");
            }
            else
            {
                Panel_Setup.Visible = false;
                Panel_XO.Visible = true;
                CreateGrid();
                InitDataGridView();

            }
        }
        void InitDataGridView()
        {
            DataGridView.ColumnCount = DataGridView.RowCount = _gridSize;
            //string[,] arrStr = new string[_gridSize,_gridSize];
            int gridSizePixels = _gridSize * 35;
            DataGridView.Size = new Size(gridSizePixels, gridSizePixels + 3);
            int x_point = DataGridView.Location.X + 350 / 2 - gridSizePixels / 2;
            int y_point = DataGridView.Location.Y + 350 / 2 - gridSizePixels / 2;
            DataGridView.Location = new Point(x_point, y_point);
            foreach (DataGridViewRow row in DataGridView.Rows) row.Height = 35;
            DataGridView.Visible = true;

            Render();
        }

        void Render()
        {
            for (int i = 0; i < _gridSize; i++)
            {
                for (int j = 0; j < _gridSize; j++)
                {
                    DataGridView.Rows[i].Cells[j].Value = GetSymbol(_gameGrid[i, j]);
                }
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            int b = e.ColumnIndex;
            if (_gameGrid[a, b] == gameSymbol.Null)
            {
                if (move == gameSymbol.X)
                {
                    _gameGrid[a, b] = gameSymbol.X;
                    move = gameSymbol.O;
                    if (!ChekFullGrid()) { MessageBox.Show("Dead heat! Grid is full"); ActiveForm!.Close(); }
                    else if (ChekWin(a, b)) { MessageBox.Show($"\'{GetSymbol((gameSymbol)(-1 * (int)move))}\' wins!!!"); ActiveForm!.Close(); }
                    else Render();
                    TextBox_XO.Text = "O`s turn";
                }
                else if (move == gameSymbol.O)
                {
                    _gameGrid[a, b] = gameSymbol.O;
                    move = gameSymbol.X;
                    if (!ChekFullGrid()) { MessageBox.Show("Dead heat! Grid is full"); ActiveForm!.Close(); }
                    else if (ChekWin(a, b)) { MessageBox.Show($"\'{GetSymbol((gameSymbol)(-1 * (int)move))}\' wins!!!"); ActiveForm!.Close(); }
                    else Render();
                    TextBox_XO.Text = "X`s turn";
                }
            }
            else
            {
                MessageBox.Show("This cell is already filled!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel_XO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
