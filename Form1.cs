namespace SayiBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                statusPanel.Controls.Clear();
                Game.secret = secretTBox.Text.ToString();
                Game.checkSecretValidation();
                if (Game.secret == null || Game.secret.Length == 0)
                {
                    throw new Exception("SecretEmptyException!\nSecret can not be empty.");
                }
                if (Game.isSecretValid == false )
                {
                   // throw new NotImplementedException();
                   throw new Exception("NotValidSecretException\nSecret can not include the same numbers.");
                }
                Game.tries = int.Parse(tryCountTBox.Text);
                if (Game.tries == 0)
                {
                    throw new Exception("TryCountEmptyException!\nTry count can not be empty or zero.");
                }
                Game.time = int.Parse(timeTBox.Text);
                if (Game.time == 0)
                {
                    throw new Exception("GameTimeEmptyException!\nGame time can not be empty or zero.");
                }
                Game.timeConst = int.Parse(timeTBox.Text);

                timer1.Enabled = true;
                timer1.Start();
                timeTBox.Enabled = false;
                tryCountTBox.Enabled = false;
                startGameBtn.Enabled = false;
                secretTBox.Enabled = false;
                guessTBox.Enabled = true;
                checkBtn.Enabled = true;
                Game.showStatusFirst(statusPanel);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                statusPanel.Controls.Clear();
                Game.guess = guessTBox.Text.ToString();
                if (Game.guess == null || Game.guess.Length == 0)
                {
                    throw new Exception("GuessEmptyException!\nGuess can not be empty.");
                }
                if (Game.guess.Length != Game.secret.Length)
                {
                    throw new Exception("GuessLengthNotMatchException!\nGuess length must match the secret length.");
                }
                Game.showStatus(statusPanel);
                Game.tries--;
                tryCountTBox.Text = Game.tries.ToString();
                Game.countColors(guessBox, colorBox);
                Game.checkGame(timer1, tryCountTBox, guessTBox, checkBtn);
                Game.resetColorCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeTBox.Text = Game.time.ToString();

            Game.checkGame(timer1, tryCountTBox, guessTBox, checkBtn);

            Game.time--;

        }

        private void timeTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guessBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statusPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            Game.resetGame();
            secretTBox.Clear();
            secretTBox.Enabled = true;

            startGameBtn.Enabled = true;

            tryCountTBox.Text = "5";
            tryCountTBox.Enabled = true;
            timeTBox.Text = "10";
            timeTBox.Enabled = true;

            guessTBox.Clear();
            guessTBox.Enabled = false;

            checkBtn.Enabled = false;

            statusPanel.Controls.Clear();

            guessBox.Items.Clear();
            colorBox.Items.Clear();

        }
    }
}