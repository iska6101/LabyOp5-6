using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LabaOP6
{
    public partial class GameWithMath : Form
    {
        private double _a;
        private double _b;
        private double _ans;
        private double _guessAns;
        private int _attempsMax = 5;
        private int _attemps;
        private int timeLeft = 30; //30sekund



        public GameWithMath()
        {
            InitializeComponent();
        }

        private static double CalculateResult(double a, double b)
        {
            // Проверяем, что b больше 0, чтобы избежать логарифма от нуля или отрицательного числа
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Значение b должно быть больше нуля.");
            }

            // Проверяем условие перед вычислением
            double cosValue = Math.Cos(2 * a);
            if (cosValue < 0)
            {
                throw new InvalidOperationException("Условие для вычисления не выполнено: косинус не может быть отрицательным.");
            }

            // Вычисляем результат
            double logValue = Math.Log(b, 5);
            double sqrtValue = Math.Sqrt(cosValue);

            return Math.Sin(logValue) / sqrtValue;
        }

        private void StartTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1 секунда
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Время вышло!");
                endGame = true;
            }
            // Обновите прогресс-бар или текстовое поле с оставшимся временем
        }

        bool endGame = false;
        bool gameMenu = false;

        private void Continue_Click(object sender, EventArgs e)
        {
            if (gameMenu)
            {
                if (endGame)
                {
                    this.Close();
                    return;
                }

                // Проверяем корректность входных данных
                if (double.TryParse(TextBoxA.Text, out double _a) &&
                    double.TryParse(TextBoxB.Text, out double _b) &&
                    double.TryParse(GuessResult.Text, out double _guessAns))
                {
                    try
                    {
                        _ans = CalculateResult(_a, _b);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Некорректные входные данные или данные равны нулю!");
                    return;
                }

                // Проверяем правильность ответа
                if (Math.Round(_ans, 2) == Math.Round(_guessAns, 2))
                {
                    ResultText.Text = "Правильный ответ!";
                    ResultText.ForeColor = Color.Green;
                    endGame = true;
                }
                else
                {
                    ResultText.Text = "Неправильный ответ";
                    ResultText.ForeColor = Color.Red;
                    _attemps--;
                    AttempsDisplay.Text = $"{_attemps}/{_attempsMax}";
                    if (_attemps <= 0)
                    {
                        ResultText.Text = "Вы проиграли!";
                        ResultText.ForeColor = Color.Red;
                        AttempsDisplay.Text = $"0/{_attempsMax}";
                        endGame = true;
                    }
                }
            }
            else
            {
                // Начинаем новую игру
                if (!int.TryParse(textBox_Attemps.Text, out _attempsMax) || _attempsMax <= 0)
                {
                    MessageBox.Show("Некорректные входные данные для количества попыток!");
                    return;
                }
                _attemps = _attempsMax;
                panel_game.Visible = !panel_game.Visible;
                panel_attemps.Visible = !panel_attemps.Visible;
                gameMenu = true;
            }
        }


        private void label1_Click(object sender, EventArgs e) { }

        private void AppText_Click(object sender, EventArgs e) { }

        private void pictureBox7_Click(object sender, EventArgs e) { }
    }
}

