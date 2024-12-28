namespace LabaOP6
{
    partial class GameWithMath
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
            components = new System.ComponentModel.Container();
            AppText = new Label();
            Continue = new Button();
            panel_game = new Panel();
            ResultText = new Label();
            TentativeAnswer = new Label();
            GuessResult = new TextBox();
            AttempsDisplay = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            NumberB = new Label();
            pictureBox5 = new PictureBox();
            TextBoxB = new TextBox();
            pictureBox2 = new PictureBox();
            NumberA = new Label();
            TextBoxA = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel_attemps = new Panel();
            textBox_Attemps = new TextBox();
            Text_AttempsCount = new Label();
            pictureBox6 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_attemps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // AppText
            // 
            AppText.AutoSize = true;
            AppText.BackColor = Color.Transparent;
            AppText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AppText.Location = new Point(266, 73);
            AppText.Margin = new Padding(6, 0, 6, 0);
            AppText.Name = "AppText";
            AppText.Size = new Size(478, 111);
            AppText.TabIndex = 9;
            AppText.Text = "ответь на это:\r\n\rf=sin((log5(b))/(sqrt(cos(2a))))";
            AppText.TextAlign = ContentAlignment.MiddleCenter;
            AppText.Click += AppText_Click;
            // 
            // Continue
            // 
            Continue.BackColor = Color.Transparent;
            Continue.CausesValidation = false;
            Continue.FlatAppearance.BorderSize = 0;
            Continue.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Continue.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Continue.Location = new Point(405, 706);
            Continue.Margin = new Padding(6);
            Continue.Name = "Continue";
            Continue.Size = new Size(292, 102);
            Continue.TabIndex = 21;
            Continue.Text = "Продолжить";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // panel_game
            // 
            panel_game.BackColor = Color.Transparent;
            panel_game.Controls.Add(ResultText);
            panel_game.Controls.Add(TentativeAnswer);
            panel_game.Controls.Add(GuessResult);
            panel_game.Controls.Add(AttempsDisplay);
            panel_game.Controls.Add(pictureBox3);
            panel_game.Controls.Add(label1);
            panel_game.Controls.Add(NumberB);
            panel_game.Controls.Add(pictureBox5);
            panel_game.Controls.Add(TextBoxB);
            panel_game.Controls.Add(pictureBox2);
            panel_game.Controls.Add(NumberA);
            panel_game.Controls.Add(TextBoxA);
            panel_game.Controls.Add(pictureBox1);
            panel_game.Controls.Add(pictureBox4);
            panel_game.Location = new Point(89, 237);
            panel_game.Margin = new Padding(6);
            panel_game.Name = "panel_game";
            panel_game.Size = new Size(929, 467);
            panel_game.TabIndex = 41;
            panel_game.Visible = false;
            // 
            // ResultText
            // 
            ResultText.Anchor = AnchorStyles.Top;
            ResultText.BackColor = Color.FromArgb(214, 191, 151);
            ResultText.Font = new Font("Microsoft Sans Serif", 12F);
            ResultText.Location = new Point(544, 314);
            ResultText.Margin = new Padding(6, 0, 6, 0);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(334, 73);
            ResultText.TabIndex = 54;
            ResultText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TentativeAnswer
            // 
            TentativeAnswer.AutoSize = true;
            TentativeAnswer.BackColor = Color.FromArgb(214, 191, 151);
            TentativeAnswer.Font = new Font("Microsoft Sans Serif", 12F);
            TentativeAnswer.Location = new Point(56, 331);
            TentativeAnswer.Margin = new Padding(6, 0, 6, 0);
            TentativeAnswer.Name = "TentativeAnswer";
            TentativeAnswer.Size = new Size(202, 37);
            TentativeAnswer.TabIndex = 52;
            TentativeAnswer.Text = "Угадаешь???";
            // 
            // GuessResult
            // 
            GuessResult.BackColor = Color.FromArgb(236, 225, 206);
            GuessResult.BorderStyle = BorderStyle.None;
            GuessResult.Cursor = Cursors.IBeam;
            GuessResult.Font = new Font("Microsoft Sans Serif", 13F);
            GuessResult.Location = new Point(266, 348);
            GuessResult.Margin = new Padding(6);
            GuessResult.Name = "GuessResult";
            GuessResult.Size = new Size(165, 40);
            GuessResult.TabIndex = 51;
            GuessResult.TextAlign = HorizontalAlignment.Center;
            // 
            // AttempsDisplay
            // 
            AttempsDisplay.Anchor = AnchorStyles.Top;
            AttempsDisplay.BackColor = Color.FromArgb(214, 191, 151);
            AttempsDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            AttempsDisplay.Location = new Point(544, 179);
            AttempsDisplay.Margin = new Padding(6, 0, 6, 0);
            AttempsDisplay.Name = "AttempsDisplay";
            AttempsDisplay.Size = new Size(334, 51);
            AttempsDisplay.TabIndex = 46;
            AttempsDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(24, 290);
            pictureBox3.Margin = new Padding(6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(448, 156);
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 191, 151);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(615, 128);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 41;
            label1.Text = "Попытки:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // NumberB
            // 
            NumberB.AutoSize = true;
            NumberB.BackColor = Color.FromArgb(214, 191, 151);
            NumberB.Font = new Font("Microsoft Sans Serif", 12F);
            NumberB.Location = new Point(56, 196);
            NumberB.Margin = new Padding(6, 0, 6, 0);
            NumberB.Name = "NumberB";
            NumberB.Size = new Size(151, 37);
            NumberB.TabIndex = 49;
            NumberB.Text = "Число  B:";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(514, 68);
            pictureBox5.Margin = new Padding(6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(390, 209);
            pictureBox5.TabIndex = 44;
            pictureBox5.TabStop = false;
            // 
            // TextBoxB
            // 
            TextBoxB.BackColor = Color.FromArgb(236, 225, 206);
            TextBoxB.BorderStyle = BorderStyle.None;
            TextBoxB.Cursor = Cursors.IBeam;
            TextBoxB.Font = new Font("Microsoft Sans Serif", 13F);
            TextBoxB.Location = new Point(266, 196);
            TextBoxB.Margin = new Padding(6);
            TextBoxB.Name = "TextBoxB";
            TextBoxB.Size = new Size(165, 40);
            TextBoxB.TabIndex = 48;
            TextBoxB.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(24, 156);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(448, 122);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // NumberA
            // 
            NumberA.AutoSize = true;
            NumberA.BackColor = Color.FromArgb(214, 191, 151);
            NumberA.Font = new Font("Microsoft Sans Serif", 12F);
            NumberA.Location = new Point(56, 62);
            NumberA.Margin = new Padding(6, 0, 6, 0);
            NumberA.Name = "NumberA";
            NumberA.Size = new Size(143, 37);
            NumberA.TabIndex = 45;
            NumberA.Text = "Число A:";
            // 
            // TextBoxA
            // 
            TextBoxA.BackColor = Color.FromArgb(236, 225, 206);
            TextBoxA.BorderStyle = BorderStyle.None;
            TextBoxA.Cursor = Cursors.IBeam;
            TextBoxA.Font = new Font("Microsoft Sans Serif", 13F);
            TextBoxA.Location = new Point(266, 62);
            TextBoxA.Margin = new Padding(6);
            TextBoxA.Name = "TextBoxA";
            TextBoxA.Size = new Size(165, 40);
            TextBoxA.TabIndex = 43;
            TextBoxA.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 21);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 122);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(514, 290);
            pictureBox4.Margin = new Padding(6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(390, 122);
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // panel_attemps
            // 
            panel_attemps.BackColor = Color.Transparent;
            panel_attemps.Controls.Add(textBox_Attemps);
            panel_attemps.Controls.Add(Text_AttempsCount);
            panel_attemps.Controls.Add(pictureBox6);
            panel_attemps.Location = new Point(227, 271);
            panel_attemps.Margin = new Padding(6);
            panel_attemps.Name = "panel_attemps";
            panel_attemps.Size = new Size(637, 322);
            panel_attemps.TabIndex = 56;
            // 
            // textBox_Attemps
            // 
            textBox_Attemps.BackColor = Color.FromArgb(236, 225, 206);
            textBox_Attemps.BorderStyle = BorderStyle.None;
            textBox_Attemps.Cursor = Cursors.IBeam;
            textBox_Attemps.Font = new Font("Microsoft Sans Serif", 13F);
            textBox_Attemps.Location = new Point(390, 139);
            textBox_Attemps.Margin = new Padding(6);
            textBox_Attemps.Name = "textBox_Attemps";
            textBox_Attemps.Size = new Size(165, 40);
            textBox_Attemps.TabIndex = 48;
            textBox_Attemps.TextAlign = HorizontalAlignment.Center;
            // 
            // Text_AttempsCount
            // 
            Text_AttempsCount.AutoSize = true;
            Text_AttempsCount.BackColor = Color.FromArgb(214, 191, 151);
            Text_AttempsCount.Font = new Font("Microsoft Sans Serif", 12F);
            Text_AttempsCount.Location = new Point(89, 141);
            Text_AttempsCount.Margin = new Padding(6, 0, 6, 0);
            Text_AttempsCount.Name = "Text_AttempsCount";
            Text_AttempsCount.Size = new Size(244, 37);
            Text_AttempsCount.TabIndex = 49;
            Text_AttempsCount.Text = "кол-во попыток:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(58, 100);
            pictureBox6.Margin = new Padding(6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(531, 122);
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // GameWithMath
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 794);
            Controls.Add(Continue);
            Controls.Add(AppText);
            Controls.Add(panel_game);
            Controls.Add(panel_attemps);
            Margin = new Padding(6);
            MaximumSize = new Size(1096, 865);
            MinimumSize = new Size(1096, 865);
            Name = "GameWithMath";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameWithMath";
            panel_game.ResumeLayout(false);
            panel_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_attemps.ResumeLayout(false);
            panel_attemps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AppText;
        private Button Continue;
        private Panel panel_game;
        private Label ResultText;
        private Label TentativeAnswer;
        private TextBox GuessResult;
        private Label AttempsDisplay;
        private PictureBox pictureBox3;
        private Label label1;
        private Label NumberB;
        private PictureBox pictureBox5;
        private TextBox TextBoxB;
        private PictureBox pictureBox2;
        private Label NumberA;
        private TextBox TextBoxA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Panel panel_attemps;
        private TextBox textBox_Attemps;
        private Label Text_AttempsCount;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer gameTimer;
    }
}