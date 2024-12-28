using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace LabaOP6
{
    partial class LabaOP6
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sorting = new Button();
            Math = new Button();
            TicTacToe = new Button();
            information = new Button();
            SuspendLayout();
            // 
            // Sorting
            // 
            Sorting.Anchor = AnchorStyles.Top;
            Sorting.BackColor = Color.Transparent;
            Sorting.BackgroundImageLayout = ImageLayout.Stretch;
            Sorting.CausesValidation = false;
            Sorting.Cursor = Cursors.Hand;
            Sorting.FlatAppearance.BorderSize = 0;
            Sorting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Sorting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Sorting.FlatStyle = FlatStyle.Flat;
            Sorting.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Sorting.ForeColor = Color.Black;
            Sorting.Location = new Point(314, 119);
            Sorting.Margin = new Padding(6, 4, 6, 4);
            Sorting.MaximumSize = new Size(353, 111);
            Sorting.MinimumSize = new Size(353, 111);
            Sorting.Name = "Sorting";
            Sorting.Size = new Size(353, 111);
            Sorting.TabIndex = 2;
            Sorting.Text = "Сортировка????";
            Sorting.UseMnemonic = false;
            Sorting.UseVisualStyleBackColor = false;
            Sorting.Click += Sorting_Click;
            // 
            // Math
            // 
            Math.Anchor = AnchorStyles.Top;
            Math.BackColor = Color.Transparent;
            Math.BackgroundImageLayout = ImageLayout.Stretch;
            Math.Cursor = Cursors.Hand;
            Math.FlatAppearance.BorderSize = 0;
            Math.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Math.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Math.FlatStyle = FlatStyle.Flat;
            Math.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Math.ForeColor = Color.Black;
            Math.Location = new Point(314, 254);
            Math.Margin = new Padding(6, 4, 6, 4);
            Math.MaximumSize = new Size(353, 111);
            Math.MinimumSize = new Size(353, 111);
            Math.Name = "Math";
            Math.Size = new Size(353, 111);
            Math.TabIndex = 3;
            Math.Text = "Угадай если не л";
            Math.UseVisualStyleBackColor = false;
            Math.Click += Math_Click;
            // 
            // TicTacToe
            // 
            TicTacToe.Anchor = AnchorStyles.Top;
            TicTacToe.BackColor = Color.Transparent;
            TicTacToe.BackgroundImageLayout = ImageLayout.Stretch;
            TicTacToe.Cursor = Cursors.Hand;
            TicTacToe.FlatAppearance.BorderSize = 0;
            TicTacToe.FlatAppearance.MouseDownBackColor = Color.Transparent;
            TicTacToe.FlatAppearance.MouseOverBackColor = Color.Transparent;
            TicTacToe.FlatStyle = FlatStyle.Flat;
            TicTacToe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TicTacToe.ForeColor = Color.Black;
            TicTacToe.Location = new Point(314, 395);
            TicTacToe.Margin = new Padding(6, 4, 6, 4);
            TicTacToe.MaximumSize = new Size(353, 111);
            TicTacToe.MinimumSize = new Size(353, 111);
            TicTacToe.Name = "TicTacToe";
            TicTacToe.Size = new Size(353, 111);
            TicTacToe.TabIndex = 4;
            TicTacToe.Text = "Крестики нолиики ЕМАЕ";
            TicTacToe.UseVisualStyleBackColor = false;
            TicTacToe.Click += TicTacToe_Click;
            // 
            // information
            // 
            information.BackColor = Color.Transparent;
            information.BackgroundImageLayout = ImageLayout.Stretch;
            information.Cursor = Cursors.Hand;
            information.FlatAppearance.BorderSize = 0;
            information.FlatAppearance.MouseDownBackColor = Color.Transparent;
            information.FlatAppearance.MouseOverBackColor = Color.Transparent;
            information.FlatStyle = FlatStyle.Flat;
            information.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            information.ForeColor = Color.Black;
            information.Location = new Point(22, 28);
            information.Margin = new Padding(6, 4, 6, 4);
            information.Name = "information";
            information.Size = new Size(56, 70);
            information.TabIndex = 5;
            information.Text = "?";
            information.UseVisualStyleBackColor = false;
            information.Click += information_Click;
            // 
            // LabaOP6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(973, 595);
            Controls.Add(information);
            Controls.Add(TicTacToe);
            Controls.Add(Math);
            Controls.Add(Sorting);
            Margin = new Padding(6, 4, 6, 4);
            MaximumSize = new Size(999, 666);
            MinimumSize = new Size(999, 666);
            Name = "LabaOP6";
            Padding = new Padding(82, 81, 82, 81);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabaOP6";
            FormClosing += LabaOP6_FormClosing_1;
            ResumeLayout(false);
        }

        #endregion

        private Button Sorting;
        private Button Math;
        private Button TicTacToe;
        private Button information;
    }
}
