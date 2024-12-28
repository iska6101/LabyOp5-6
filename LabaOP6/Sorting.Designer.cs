using System.Windows.Forms;

namespace LabaOP6
{
    partial class Sorting
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
            MenuText = new Label();
            Panel_Size = new Panel();
            ConfirmSize = new Button();
            NumberA = new Label();
            TextBox_ArraySize = new TextBox();
            pictureBox1 = new PictureBox();
            Button_DefaultSize = new Button();
            Panel_Button = new Panel();
            Button_Max = new Button();
            Button_Avg = new Button();
            Button_Min = new Button();
            Button_Sort = new Button();
            Panel_Sorting = new Panel();
            DataGridView = new DataGridView();
            Panel_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_Button.SuspendLayout();
            Panel_Sorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // MenuText
            // 
            MenuText.BackColor = Color.Transparent;
            MenuText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuText.Location = new Point(260, 169);
            MenuText.Margin = new Padding(6, 0, 6, 0);
            MenuText.Name = "MenuText";
            MenuText.Size = new Size(503, 60);
            MenuText.TabIndex = 0;
            MenuText.Text = "А теперь выбери длинну:";
            MenuText.TextAlign = ContentAlignment.MiddleCenter;
            MenuText.Click += MenuText_Click;
            // 
            // Panel_Size
            // 
            Panel_Size.BackColor = Color.Transparent;
            Panel_Size.Controls.Add(ConfirmSize);
            Panel_Size.Controls.Add(NumberA);
            Panel_Size.Controls.Add(TextBox_ArraySize);
            Panel_Size.Controls.Add(pictureBox1);
            Panel_Size.Controls.Add(Button_DefaultSize);
            Panel_Size.Location = new Point(95, 235);
            Panel_Size.Margin = new Padding(6);
            Panel_Size.Name = "Panel_Size";
            Panel_Size.Size = new Size(806, 403);
            Panel_Size.TabIndex = 1;
            // 
            // ConfirmSize
            // 
            ConfirmSize.BackColor = Color.FromArgb(214, 191, 150);
            ConfirmSize.FlatAppearance.BorderColor = Color.FromArgb(152, 135, 108);
            ConfirmSize.FlatAppearance.BorderSize = 2;
            ConfirmSize.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 191, 150);
            ConfirmSize.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 191, 150);
            ConfirmSize.FlatStyle = FlatStyle.Flat;
            ConfirmSize.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ConfirmSize.Location = new Point(472, 198);
            ConfirmSize.Margin = new Padding(6);
            ConfirmSize.Name = "ConfirmSize";
            ConfirmSize.Size = new Size(228, 53);
            ConfirmSize.TabIndex = 51;
            ConfirmSize.Text = "Продолжить";
            ConfirmSize.UseVisualStyleBackColor = false;
            ConfirmSize.Click += Confirm_Click;
            // 
            // NumberA
            // 
            NumberA.AutoSize = true;
            NumberA.BackColor = Color.FromArgb(214, 191, 151);
            NumberA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberA.Location = new Point(425, 147);
            NumberA.Margin = new Padding(6, 0, 6, 0);
            NumberA.Name = "NumberA";
            NumberA.Size = new Size(224, 37);
            NumberA.TabIndex = 49;
            NumberA.Text = "Твой размер:";
            // 
            // TextBox_ArraySize
            // 
            TextBox_ArraySize.BackColor = Color.FromArgb(236, 225, 206);
            TextBox_ArraySize.BorderStyle = BorderStyle.None;
            TextBox_ArraySize.Cursor = Cursors.IBeam;
            TextBox_ArraySize.Font = new Font("Microsoft Sans Serif", 13F);
            TextBox_ArraySize.Location = new Point(613, 145);
            TextBox_ArraySize.Margin = new Padding(6);
            TextBox_ArraySize.Name = "TextBox_ArraySize";
            TextBox_ArraySize.Size = new Size(124, 40);
            TextBox_ArraySize.TabIndex = 48;
            TextBox_ArraySize.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(409, 111);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 183);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // Button_DefaultSize
            // 
            Button_DefaultSize.Anchor = AnchorStyles.Top;
            Button_DefaultSize.BackColor = Color.Transparent;
            Button_DefaultSize.BackgroundImageLayout = ImageLayout.Stretch;
            Button_DefaultSize.CausesValidation = false;
            Button_DefaultSize.Cursor = Cursors.Hand;
            Button_DefaultSize.FlatAppearance.BorderSize = 0;
            Button_DefaultSize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_DefaultSize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_DefaultSize.FlatStyle = FlatStyle.Flat;
            Button_DefaultSize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_DefaultSize.ForeColor = Color.Black;
            Button_DefaultSize.Location = new Point(22, 141);
            Button_DefaultSize.Margin = new Padding(6, 4, 6, 4);
            Button_DefaultSize.MaximumSize = new Size(353, 111);
            Button_DefaultSize.MinimumSize = new Size(353, 111);
            Button_DefaultSize.Name = "Button_DefaultSize";
            Button_DefaultSize.Size = new Size(353, 111);
            Button_DefaultSize.TabIndex = 3;
            Button_DefaultSize.Text = "Дефолт";
            Button_DefaultSize.UseMnemonic = false;
            Button_DefaultSize.UseVisualStyleBackColor = false;
            Button_DefaultSize.Click += Button_DefaultSize_Click;
            // 
            // Panel_Button
            // 
            Panel_Button.BackColor = Color.Transparent;
            Panel_Button.Controls.Add(Button_Max);
            Panel_Button.Controls.Add(Button_Avg);
            Panel_Button.Controls.Add(Button_Min);
            Panel_Button.Controls.Add(Button_Sort);
            Panel_Button.Location = new Point(32, 26);
            Panel_Button.Margin = new Padding(6);
            Panel_Button.Name = "Panel_Button";
            Panel_Button.Size = new Size(932, 149);
            Panel_Button.TabIndex = 2;
            Panel_Button.Visible = false;
            // 
            // Button_Max
            // 
            Button_Max.Anchor = AnchorStyles.Top;
            Button_Max.BackColor = Color.Transparent;
            Button_Max.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Max.CausesValidation = false;
            Button_Max.Cursor = Cursors.Hand;
            Button_Max.FlatAppearance.BorderSize = 0;
            Button_Max.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Max.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Max.FlatStyle = FlatStyle.Flat;
            Button_Max.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Max.ForeColor = Color.Black;
            Button_Max.Location = new Point(693, 19);
            Button_Max.Margin = new Padding(6, 4, 6, 4);
            Button_Max.MaximumSize = new Size(186, 107);
            Button_Max.MinimumSize = new Size(186, 107);
            Button_Max.Name = "Button_Max";
            Button_Max.Size = new Size(186, 107);
            Button_Max.TabIndex = 7;
            Button_Max.Text = "Максимум";
            Button_Max.UseMnemonic = false;
            Button_Max.UseVisualStyleBackColor = false;
            Button_Max.Click += Button_Max_Click;
            // 
            // Button_Avg
            // 
            Button_Avg.Anchor = AnchorStyles.Top;
            Button_Avg.BackColor = Color.Transparent;
            Button_Avg.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Avg.CausesValidation = false;
            Button_Avg.Cursor = Cursors.Hand;
            Button_Avg.FlatAppearance.BorderSize = 0;
            Button_Avg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Avg.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Avg.FlatStyle = FlatStyle.Flat;
            Button_Avg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Avg.ForeColor = Color.Black;
            Button_Avg.Location = new Point(260, 17);
            Button_Avg.Margin = new Padding(6, 4, 6, 4);
            Button_Avg.MaximumSize = new Size(186, 107);
            Button_Avg.MinimumSize = new Size(186, 107);
            Button_Avg.Name = "Button_Avg";
            Button_Avg.Size = new Size(186, 107);
            Button_Avg.TabIndex = 6;
            Button_Avg.Text = "сложи пополам";
            Button_Avg.UseMnemonic = false;
            Button_Avg.UseVisualStyleBackColor = false;
            Button_Avg.Click += Button_Avg_Click;
            // 
            // Button_Min
            // 
            Button_Min.Anchor = AnchorStyles.Top;
            Button_Min.BackColor = Color.Transparent;
            Button_Min.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Min.CausesValidation = false;
            Button_Min.Cursor = Cursors.Hand;
            Button_Min.FlatAppearance.BorderSize = 0;
            Button_Min.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Min.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Min.FlatStyle = FlatStyle.Flat;
            Button_Min.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Min.ForeColor = Color.Black;
            Button_Min.Location = new Point(479, 19);
            Button_Min.Margin = new Padding(6, 4, 6, 4);
            Button_Min.MaximumSize = new Size(186, 107);
            Button_Min.MinimumSize = new Size(186, 107);
            Button_Min.Name = "Button_Min";
            Button_Min.Size = new Size(186, 107);
            Button_Min.TabIndex = 5;
            Button_Min.Text = "Минимум";
            Button_Min.UseMnemonic = false;
            Button_Min.UseVisualStyleBackColor = false;
            Button_Min.Click += Button_Min_Click;
            // 
            // Button_Sort
            // 
            Button_Sort.Anchor = AnchorStyles.Top;
            Button_Sort.BackColor = Color.Transparent;
            Button_Sort.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Sort.CausesValidation = false;
            Button_Sort.Cursor = Cursors.Hand;
            Button_Sort.FlatAppearance.BorderSize = 0;
            Button_Sort.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Sort.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Sort.FlatStyle = FlatStyle.Flat;
            Button_Sort.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Sort.ForeColor = Color.Black;
            Button_Sort.Location = new Point(52, 19);
            Button_Sort.Margin = new Padding(6, 4, 6, 4);
            Button_Sort.MaximumSize = new Size(186, 107);
            Button_Sort.MinimumSize = new Size(186, 107);
            Button_Sort.Name = "Button_Sort";
            Button_Sort.Size = new Size(186, 107);
            Button_Sort.TabIndex = 4;
            Button_Sort.Text = "Отсортируй меня😘 ";
            Button_Sort.UseMnemonic = false;
            Button_Sort.UseVisualStyleBackColor = false;
            Button_Sort.Click += Button_Sort_Click;
            // 
            // Panel_Sorting
            // 
            Panel_Sorting.BackColor = Color.Transparent;
            Panel_Sorting.Controls.Add(DataGridView);
            Panel_Sorting.Location = new Point(60, 229);
            Panel_Sorting.Margin = new Padding(6);
            Panel_Sorting.Name = "Panel_Sorting";
            Panel_Sorting.Size = new Size(932, 403);
            Panel_Sorting.TabIndex = 3;
            Panel_Sorting.Visible = false;
            Panel_Sorting.Paint += Panel_Sorting_Paint;
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AllowUserToOrderColumns = true;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView.BackgroundColor = Color.FromArgb(214, 191, 150);
            DataGridView.ColumnHeadersHeight = 46;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridView.ColumnHeadersVisible = false;
            DataGridView.GridColor = Color.FromArgb(214, 191, 150);
            DataGridView.Location = new Point(69, 94);
            DataGridView.Margin = new Padding(6);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridView.Size = new Size(810, 94);
            DataGridView.TabIndex = 0;
            DataGridView.CellValueChanged += DataGridView_CellValueChanged;
            // 
            // Sorting
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 663);
            Controls.Add(Panel_Sorting);
            Controls.Add(Panel_Button);
            Controls.Add(MenuText);
            Controls.Add(Panel_Size);
            Margin = new Padding(6);
            Name = "Sorting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "сортировка";
            Panel_Size.ResumeLayout(false);
            Panel_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_Button.ResumeLayout(false);
            Panel_Sorting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label MenuText;
        private Panel Panel_Size;
        private Button Button_DefaultSize;
        private Label NumberA;
        private TextBox TextBox_ArraySize;
        private PictureBox pictureBox1;
        private Button ConfirmSize;
        private Panel Panel_Button;
        private Button Button_Max;
        private Button Button_Avg;
        private Button Button_Min;
        private Button Button_Sort;
        private Panel Panel_Sorting;
        private DataGridView DataGridView;
    }
}