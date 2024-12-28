namespace LabaOP6
{
    partial class Information
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
            pictureBox1 = new PictureBox();
            BaseText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(104, 105);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(812, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BaseText
            // 
            BaseText.BackColor = Color.FromArgb(214, 191, 150);
            BaseText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BaseText.Location = new Point(236, 181);
            BaseText.Margin = new Padding(6, 0, 6, 0);
            BaseText.Name = "BaseText";
            BaseText.Size = new Size(566, 162);
            BaseText.TabIndex = 0;
            BaseText.Text = "Страдал пока писал \r\nЗагртдинов Искандэр \r\n\r\nГруппа: 6101-090301D";
            BaseText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 467);
            Controls.Add(BaseText);
            Controls.Add(pictureBox1);
            Margin = new Padding(6);
            MaximumSize = new Size(1038, 538);
            MinimumSize = new Size(1038, 538);
            Name = "Information";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label BaseText;
    }
}