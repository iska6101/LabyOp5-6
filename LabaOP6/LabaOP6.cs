namespace LabaOP6
{
    public partial class LabaOP6 : Form
    {
        public LabaOP6()
        {
            InitializeComponent();
        }
        private void TicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe form = new TicTacToe();
            form.Show();
        }

        private void information_Click(object sender, EventArgs e)
        {
            Information form = new Information();
            form.Show();
        }

        private void Sorting_Click(object sender, EventArgs e)
        {
            Sorting form = new Sorting();
            form.Show();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            GameWithMath form = new GameWithMath();
            form.Show();
        }

        private void LabaOP6_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close the form?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) e.Cancel = true;
        }

       

        private void LabaOP6_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Если пользователь выбрал "Нет", отменяем закрытие формы
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
