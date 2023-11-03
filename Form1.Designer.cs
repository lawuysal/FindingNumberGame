namespace SayiBulmaOyunu
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startGameBtn = new Button();
            secretTBox = new TextBox();
            tryCountTBox = new TextBox();
            timeTBox = new TextBox();
            checkBtn = new Button();
            guessTBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            statusPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            guessBox = new ListBox();
            colorBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            saveScoreBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // startGameBtn
            // 
            startGameBtn.BackColor = Color.FromArgb(29, 91, 121);
            startGameBtn.ForeColor = Color.White;
            startGameBtn.Location = new Point(198, 12);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(125, 29);
            startGameBtn.TabIndex = 0;
            startGameBtn.Text = "Start the Game";
            startGameBtn.UseVisualStyleBackColor = false;
            startGameBtn.Click += button1_Click;
            // 
            // secretTBox
            // 
            secretTBox.BackColor = Color.FromArgb(245, 239, 230);
            secretTBox.Location = new Point(36, 14);
            secretTBox.Name = "secretTBox";
            secretTBox.PlaceholderText = "Enter the Secret";
            secretTBox.Size = new Size(125, 27);
            secretTBox.TabIndex = 1;
            secretTBox.UseSystemPasswordChar = true;
            // 
            // tryCountTBox
            // 
            tryCountTBox.BackColor = Color.FromArgb(245, 239, 230);
            tryCountTBox.Location = new Point(36, 93);
            tryCountTBox.Name = "tryCountTBox";
            tryCountTBox.Size = new Size(125, 27);
            tryCountTBox.TabIndex = 2;
            tryCountTBox.Text = "5";
            tryCountTBox.TextAlign = HorizontalAlignment.Center;
            // 
            // timeTBox
            // 
            timeTBox.BackColor = Color.FromArgb(245, 239, 230);
            timeTBox.Location = new Point(198, 93);
            timeTBox.Name = "timeTBox";
            timeTBox.Size = new Size(125, 27);
            timeTBox.TabIndex = 3;
            timeTBox.Text = "10";
            timeTBox.TextAlign = HorizontalAlignment.Center;
            timeTBox.TextChanged += timeTBox_TextChanged;
            // 
            // checkBtn
            // 
            checkBtn.BackColor = Color.FromArgb(29, 91, 121);
            checkBtn.Enabled = false;
            checkBtn.ForeColor = Color.White;
            checkBtn.Location = new Point(198, 167);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(125, 29);
            checkBtn.TabIndex = 4;
            checkBtn.Text = "Check the Guess";
            checkBtn.UseVisualStyleBackColor = false;
            checkBtn.Click += checkBtn_Click;
            // 
            // guessTBox
            // 
            guessTBox.BackColor = Color.FromArgb(245, 239, 230);
            guessTBox.Enabled = false;
            guessTBox.Location = new Point(36, 167);
            guessTBox.Name = "guessTBox";
            guessTBox.PlaceholderText = "Enter your Guess";
            guessTBox.Size = new Size(125, 27);
            guessTBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Try count:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Duration:";
            // 
            // statusPanel
            // 
            statusPanel.BackColor = Color.FromArgb(29, 91, 121);
            statusPanel.Location = new Point(36, 230);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(664, 125);
            statusPanel.TabIndex = 8;
            statusPanel.Paint += statusPanel_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // guessBox
            // 
            guessBox.FormattingEnabled = true;
            guessBox.ItemHeight = 20;
            guessBox.Location = new Point(406, 32);
            guessBox.Name = "guessBox";
            guessBox.Size = new Size(150, 164);
            guessBox.TabIndex = 9;
            guessBox.Tag = "";
            guessBox.SelectedIndexChanged += guessBox_SelectedIndexChanged;
            // 
            // colorBox
            // 
            colorBox.FormattingEnabled = true;
            colorBox.ItemHeight = 20;
            colorBox.Location = new Point(550, 32);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(150, 164);
            colorBox.TabIndex = 10;
            colorBox.SelectedIndexChanged += colorBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 9);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 11;
            label3.Text = "Guesses:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 9);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 12;
            label4.Text = "Guess Status:";
            // 
            // saveScoreBtn
            // 
            saveScoreBtn.Location = new Point(599, 388);
            saveScoreBtn.Name = "saveScoreBtn";
            saveScoreBtn.Size = new Size(133, 29);
            saveScoreBtn.TabIndex = 13;
            saveScoreBtn.Text = "Save the Score";
            saveScoreBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(434, 388);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(122, 29);
            resetBtn.TabIndex = 14;
            resetBtn.Text = "Reset Game";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(resetBtn);
            Controls.Add(saveScoreBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(colorBox);
            Controls.Add(guessBox);
            Controls.Add(statusPanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guessTBox);
            Controls.Add(checkBtn);
            Controls.Add(timeTBox);
            Controls.Add(tryCountTBox);
            Controls.Add(secretTBox);
            Controls.Add(startGameBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameBtn;
        private TextBox secretTBox;
        private TextBox tryCountTBox;
        private TextBox timeTBox;
        private Button checkBtn;
        private TextBox guessTBox;
        private Label label1;
        private Label label2;
        private Panel statusPanel;
        private System.Windows.Forms.Timer timer1;
        private ListBox guessBox;
        private ListBox colorBox;
        private Label label3;
        private Label label4;
        private Button saveScoreBtn;
        private Button resetBtn;
    }
}