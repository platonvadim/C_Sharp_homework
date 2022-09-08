using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_lesson
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        private int userNumber;
        private int computerNumber;
        private int attemps;
        public Form1()
        {
            InitializeComponent();
            attemps = 0;
            UpdateGameState(userNumber, random.Next(20));
        }

        public void UpdateGameState(int userNumber)
        {
            labelUserNumber.Text = $"Текущее число: {userNumber}";
        }

        public void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComuterNumber.Text = $"Получите чилсо: {computerNumber}";

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите начать новую игру?", "Удвоитель", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                attemps = 0;
                UpdateGameState(userNumber *= 0, random.Next(20));
                MessageBox.Show($"Компьютер загадал число {computerNumber}", "Удвоитель", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UpdateGameState(++userNumber);
            attemps++;
            CheckWin();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 2);
            attemps++;
            CheckWin();
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру!\nХодов: {attemps}", "Удвоитель", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if(MessageBox.Show("Хотите сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateGameState(userNumber *= 0, random.Next(20));
                }
                else
                {
                    Close();
                }
            }
            else if (userNumber > computerNumber)
            {
                MessageBox.Show($"Вы проиграли!\nХодов: {attemps}", "Удвоитель", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                if (MessageBox.Show("Хотите сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateGameState(userNumber *= 0, random.Next(20));
                }
                else
                {
                    Close();
                }
            }
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonReset.PerformClick();
        }
    }
}
