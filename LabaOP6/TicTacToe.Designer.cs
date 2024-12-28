namespace LabaOP6
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridView = new DataGridView();
            Panel_Setup = new Panel();
            Panel_XO = new Panel();
            TextBox_XO = new Label();
            NumberA = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBox_PointForWin = new TextBox();
            pictureBox2 = new PictureBox();
            TextBox_GridSize = new TextBox();
            pictureBox1 = new PictureBox();
            Continue = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            Panel_Setup.SuspendLayout();
            Panel_XO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AllowUserToResizeColumns = false;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.BackgroundColor = Color.FromArgb(214, 191, 150);
            DataGridView.ColumnHeadersHeight = 46;
            DataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.Font = new Font("Microsoft Sans Serif", 18F);
            DataGridView.GridColor = Color.FromArgb(214, 191, 150);
            DataGridView.Location = new Point(59, 207);
            DataGridView.Margin = new Padding(6);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 82;
            DataGridView.Size = new Size(650, 747);
            DataGridView.TabIndex = 10000000;
            DataGridView.Visible = false;
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            DataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
            // 
            // Panel_Setup
            // 
            Panel_Setup.BackColor = Color.Transparent;
            Panel_Setup.Controls.Add(Panel_XO);
            Panel_Setup.Controls.Add(NumberA);
            Panel_Setup.Controls.Add(label2);
            Panel_Setup.Controls.Add(label1);
            Panel_Setup.Controls.Add(TextBox_PointForWin);
            Panel_Setup.Controls.Add(pictureBox2);
            Panel_Setup.Controls.Add(TextBox_GridSize);
            Panel_Setup.Controls.Add(pictureBox1);
            Panel_Setup.Controls.Add(Continue);
            Panel_Setup.Location = new Point(138, 32);
            Panel_Setup.Margin = new Padding(6);
            Panel_Setup.Name = "Panel_Setup";
            Panel_Setup.Size = new Size(464, 907);
            Panel_Setup.TabIndex = 2;
            // 
            // Panel_XO
            // 
            Panel_XO.BackColor = Color.Transparent;
            Panel_XO.BackgroundImageLayout = ImageLayout.Stretch;
            Panel_XO.Controls.Add(TextBox_XO);
            Panel_XO.Location = new Point(19, 21);
            Panel_XO.Margin = new Padding(6);
            Panel_XO.Name = "Panel_XO";
            Panel_XO.Size = new Size(427, 128);
            Panel_XO.TabIndex = 10000001;
            Panel_XO.Visible = false;
            Panel_XO.Paint += Panel_XO_Paint;
            // 
            // TextBox_XO
            // 
            TextBox_XO.BackColor = Color.Transparent;
            TextBox_XO.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            TextBox_XO.Location = new Point(27, 36);
            TextBox_XO.Margin = new Padding(6, 0, 6, 0);
            TextBox_XO.Name = "TextBox_XO";
            TextBox_XO.Size = new Size(371, 60);
            TextBox_XO.TabIndex = 1;
            TextBox_XO.Text = "Очередь Х";
            TextBox_XO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NumberA
            // 
            NumberA.AutoSize = true;
            NumberA.BackColor = Color.FromArgb(214, 191, 151);
            NumberA.Font = new Font("Microsoft Sans Serif", 12F);
            NumberA.Location = new Point(65, 350);
            NumberA.Margin = new Padding(6, 0, 6, 0);
            NumberA.Name = "NumberA";
            NumberA.Size = new Size(230, 37);
            NumberA.TabIndex = 55;
            NumberA.Text = "Размеры поля:";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(19, 113);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(412, 90);
            label2.TabIndex = 54;
            label2.Text = "крестики нолики";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 191, 151);
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(6, 499);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 52;
            label1.Text = "элементов для вин:";
            // 
            // TextBox_PointForWin
            // 
            TextBox_PointForWin.BackColor = Color.FromArgb(236, 225, 206);
            TextBox_PointForWin.BorderStyle = BorderStyle.None;
            TextBox_PointForWin.Cursor = Cursors.IBeam;
            TextBox_PointForWin.Font = new Font("Microsoft Sans Serif", 13F);
            TextBox_PointForWin.Location = new Point(295, 499);
            TextBox_PointForWin.Margin = new Padding(6);
            TextBox_PointForWin.Name = "TextBox_PointForWin";
            TextBox_PointForWin.Size = new Size(106, 40);
            TextBox_PointForWin.TabIndex = 51;
            TextBox_PointForWin.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(11, 463);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(448, 122);
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // TextBox_GridSize
            // 
            TextBox_GridSize.BackColor = Color.FromArgb(236, 225, 206);
            TextBox_GridSize.BorderStyle = BorderStyle.None;
            TextBox_GridSize.Cursor = Cursors.IBeam;
            TextBox_GridSize.Font = new Font("Microsoft Sans Serif", 13F);
            TextBox_GridSize.Location = new Point(293, 350);
            TextBox_GridSize.Margin = new Padding(6);
            TextBox_GridSize.Name = "TextBox_GridSize";
            TextBox_GridSize.Size = new Size(106, 40);
            TextBox_GridSize.TabIndex = 48;
            TextBox_GridSize.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(19, 310);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 122);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // Continue
            // 
            Continue.BackColor = Color.Transparent;
            Continue.BackgroundImageLayout = ImageLayout.Stretch;
            Continue.CausesValidation = false;
            Continue.FlatAppearance.BorderSize = 0;
            Continue.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Continue.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Continue.Location = new Point(87, 770);
            Continue.Margin = new Padding(6);
            Continue.Name = "Continue";
            Continue.Size = new Size(292, 102);
            Continue.TabIndex = 3;
            Continue.Text = "Далее";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 969);
            Controls.Add(DataGridView);
            Controls.Add(Panel_Setup);
            Margin = new Padding(6);
            MaximumSize = new Size(750, 1040);
            MinimumSize = new Size(750, 1040);
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            Panel_Setup.ResumeLayout(false);
            Panel_Setup.PerformLayout();
            Panel_XO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private Panel Panel_Setup;
        private Button Continue;
        private TextBox TextBox_GridSize;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TextBox_PointForWin;
        private PictureBox pictureBox2;
        private Label label2;
        private Label NumberA;
        private Label TextBox_XO;
        private Panel Panel_XO;
    }
}