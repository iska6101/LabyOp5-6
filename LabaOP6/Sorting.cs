using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOP6
{
    public partial class Sorting : Form
    {
        private int _max = int.MaxValue;
        private int _min = int.MinValue;
        bool minColorize = false;
        bool maxColorize = false;
        bool firstInit = true;
        private int _size = 10;
        Array array;
        private int[] _array;
        public Sorting()
        {
            InitializeComponent();
        }

        private void SwitchToSorting()
        {
            Panel_Size.Visible = false;
            Panel_Button.Visible = true;
            Panel_Sorting.Visible = true;
            MenuText.Text = "Lets go funny :)";


        }
        private void InitDataGrid()
        {
            DataGridView.CellValueChanged += DataGridView_CellValueChanged;
            if (firstInit) _array = array.ArrayGet;
            DataGridView.Rows.Clear();
            DataGridView.ColumnCount = _size;
            string[] arrStr = new string[_array.Length];
            _min = _array.Min();
            _max = _array.Max();
            List<int> minIndex = new List<int>();
            List<int> maxIndex = new List<int>();
            for (int i = 0; i < _array.Length; i++)
            {
                arrStr[i] = _array[i].ToString();
                if (_array[i] == _min) minIndex.Add(i);
                if (_array[i] == _max) maxIndex.Add(i);
            }
            DataGridView.Rows.Add(arrStr);
            if (minColorize == true)
            {
                foreach (int i in minIndex) DataGridView.Rows[0].Cells[i].Style.BackColor = Color.DarkOrange;
            }
            if (maxColorize == true)
            {
                foreach (int i in maxIndex) DataGridView.Rows[0].Cells[i].Style.BackColor = Color.DarkGreen;
            }

        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_ArraySize.Text, out _size) && _size > 1 && _size < 655)
            {
                SwitchToSorting();
                array = new Array(_size);
                _array = array.ArrayGet;
                InitDataGrid();
            }
            else
            {
                MessageBox.Show("Uncorrect input data or data has null!\nThe size should be in the range from 2 to 654");
                return;
            }
        }

        private void Button_DefaultSize_Click(object sender, EventArgs e)
        {
            SwitchToSorting();
            array = new Array();
            _array = array.ArrayGet;
            InitDataGrid();
        }

        private void Button_Sort_Click(object sender, EventArgs e)
        {
            _array = Array.GnomeSort(_array);
            InitDataGrid();
        }

        private void Button_Avg_Click(object sender, EventArgs e)
        {
            double avg = Math.Round((double)(_array.Sum() / _size));
            MenuText.Text = $"Avg value is {avg}";
        }

        private void Button_Min_Click(object sender, EventArgs e)
        {
            MenuText.Text = $"Min value is {_min}";
        }

        private void Button_Max_Click(object sender, EventArgs e)
        {
            MenuText.Text = $"Max value is {_max}";
        }

        private void Button_ColorizeMin_Click(object sender, EventArgs e)
        {
            minColorize = !minColorize;
            InitDataGrid();
        }
        private void Button_ColorizeMax_Click(object sender, EventArgs e)
        {
            maxColorize = !maxColorize;
            InitDataGrid();
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!int.TryParse(DataGridView.Rows[0].Cells[e.ColumnIndex].Value.ToString(), out _array[e.ColumnIndex]))
            {
                MessageBox.Show($"Uncorrect inpit value in column {e.ColumnIndex + 1}");
            }
            InitDataGrid();
        }

        private void Panel_Sorting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuText_Click(object sender, EventArgs e)
        {

        }
    }

    class Array
    {
        private int[] _array;
        private int _initialLength;


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Array"/> с длиной массива по умолчанию, равной 10.
        /// </summary>
        public Array()
        {
            _initialLength = 10;
            _array = NewArr(10);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Array"/> с указанной длиной массива.
        /// </summary>
        /// <param name="length">Длина создаваемого массива.</param>
        public Array(int length)
        {
            _initialLength = length;
            _array = NewArr(length);
        }
        public int[] ArrayGet
        {
            get { return _array; }
            set { _array = value; }
        }
        public static int[] NewArr(int arrSize)
        {
            int[] arr = new int[arrSize];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000);
            }
            return arr;
        }
        public static int[] GnomeSort(int[] arr)
        {
            int index = 0;
            while (index < arr.Length)
            {
                if (index == 0 || arr[index] >= arr[index - 1]) index++;
                else
                {
                    int temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
            return arr;
        }
    }
}
