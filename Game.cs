using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmaOyunu
{
    public class Game
    {
        public static int correctCount;
        public static int incorrectCount;
        public static string secret;
        public static string guess;
        public static int tries;
        public static int time;
        public static int timeConst;
        public static bool isDone;
        public static bool isSecretValid;
        public static int score = 0;

        public static void resetGame()
        {
            correctCount = 0;
            incorrectCount = 0;
            secret = "";
            guess = "";
            tries = 0;
            time = 0;
            timeConst = 0;
            isDone = false;
            isSecretValid = true;
            score = 0;


        }

        public static void checkSecretValidation()
        {
            if (secret.GroupBy(c => c).Any(group => group.Count() >= 2))
            {
                isSecretValid = false;
                return;
            }

            isSecretValid = true;
        }

        public static void checkGame(System.Windows.Forms.Timer timer, TextBox tryCountTBox, TextBox guessTBox, Button checkBtn)
        {
            if (Game.time <= 0)
            {
                timer.Stop();
                Game.tries--;
                Game.time = timeConst;
                tryCountTBox.Text = Game.tries.ToString();
                if (Game.tries <= 0)
                {
                    timer.Stop();
                    MessageBox.Show("You Lost");
                    Game.isDone = true;
                    checkBtn.Enabled = false;  
                    guessTBox.Enabled = false;

                    
                    return;
                }
        

                timer.Start();
            }
            if (Game.tries <= 0)
            {
                timer.Stop();
                MessageBox.Show("You Lost");
                Game.isDone = true;
                checkBtn.Enabled = false;
                guessTBox.Enabled = false;

                return;
            }
            if (guess == secret)
            {
                timer.Stop();
                MessageBox.Show("You Won");
                Game.isDone = true;
                checkBtn.Enabled = false;
                guessTBox.Enabled = false;

                return;
            }
        }

        public static void showStatus(Panel statusPanel)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                TextBox myTextBox = new TextBox();
                myTextBox.TextAlign = HorizontalAlignment.Center;
                myTextBox.Enabled = false;
                myTextBox.Size = new Size(60, 20);
                myTextBox.Location = new Point(15 + (i * 75), 15);
                myTextBox.Text = guess[i].ToString();
                myTextBox.Name = "numberBox" + i;
                myTextBox.BackColor = Color.White;
                statusPanel.Controls.Add(myTextBox);
            }

            for (int i = 0; i < guess.Length; i++)
            {
                Label myStatusLabel = new Label();
                myStatusLabel.Enabled = true;
                myStatusLabel.Size = new Size(60, 20);
                myStatusLabel.Location = new Point(15 + (i*75), 55);
                myStatusLabel.Name = "numberStatus" + i;          
                //
                if (guess[i] == secret[i])
                {
                    myStatusLabel.BackColor = Color.Blue;
                    
                }
                else if (secret.Contains(guess[i]))
                {
                    myStatusLabel.BackColor = Color.Red;
                    
                }
                else
                {
                    myStatusLabel.BackColor = Color.White;
                }
                //
                statusPanel.Controls.Add(myStatusLabel);

            }

            for (int i = 0; i < guess.Length; i++)
            {
                Label toEdit = statusPanel.Controls.Find("numberStatus" + i, true).FirstOrDefault() as Label;
                if (guess[i] == secret[i])
                {
                    toEdit.BackColor = Color.Blue;
                }
                else if (secret.Contains(guess[i]))
                {
                    toEdit.BackColor = Color.Red;
                }
                else
                {
                    toEdit.BackColor = Color.White;
                }
            }

        }

        public static void showStatusFirst(Panel statusPanel)
        {
            for (int i = 0; i < secret.Length; i++)
            {
                TextBox myTextBox = new TextBox();
                myTextBox.TextAlign = HorizontalAlignment.Center;
                myTextBox.Enabled = false;
                myTextBox.Size = new Size(60, 20);
                myTextBox.Location = new Point(15 + (i * 75), 15);
                
                myTextBox.Name = "numberBox" + i;
                myTextBox.BackColor = Color.White;
                statusPanel.Controls.Add(myTextBox);
            }



        }

        public static void countColors(ListBox guessBox, ListBox listBox)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    correctCount++;
                }
                else if (secret.Contains(guess[i]))
                {
                    incorrectCount++;
                }
            }
            guessBox.Items.Add(guess);
            listBox.Items.Add("+" + correctCount + "  -" + incorrectCount);
        }

        public static void resetColorCounts()
        {
            correctCount = 0;
            incorrectCount = 0;

        }

    }


}
