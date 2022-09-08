using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int numberToGuess;
        private int userNumber;
        private int attemps;
        public Form1()
        {
            InitializeComponent();
            startNewGame();
        }

        private void startNewGame()
        {
            numberToGuess = random.Next(100);
            attemps = 0;
            updateGame();
        }

        private void updateGame()
        {
            labelAttempts.Text = $"Попыток: {attemps}";
            textBoxGuessNumber.Text = "";
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {

            if(int.TryParse(textBoxGuessNumber.Text, out userNumber))
            {
                attemps++;
                updateGame();
                if (numberToGuess < userNumber)
                {
                    MessageBox.Show($"Загаданное число меньше, чем {userNumber}", "GuessTheNumber", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                }
                else if (numberToGuess > userNumber)
                {
                    MessageBox.Show($"Загаданное число больше, чем {userNumber}", "GuessTheNumber", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Вы выиграли!\n\nСтатистика:\nПопыток: {attemps}", "GuessTheNumber", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    if (MessageBox.Show("Хотите сыграть еще раз?", "GuessTheNumber", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        startNewGame();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите начать новую игру?", "GuessTheNumber", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                startNewGame();
            }
        }

        private void textBoxGuessNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                buttonSend.PerformClick();
            }
        }
    }
}
