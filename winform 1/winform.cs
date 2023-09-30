using System.Collections.Generic;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string resume = "тут має бути цв"; 
            int charCount = resume.Length;
            int messageBoxCount = 3;
            int averageCharsPerPage = charCount / messageBoxCount;

            for (int i = 0; i < messageBoxCount; i++)
            {
                MessageBox.Show(resume.Substring(i * averageCharsPerPage, averageCharsPerPage), "цв");
            }

            MessageBox.Show($"середня кількість: {averageCharsPerPage}", "середня кількість символів");
        }
    }
}

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 2001);
            attempts = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("число від 1 - 2000", "Игра вгадай число");
        }

        private void GuessNumber()
        {
            int guess = (1 + 2000) / 2; 

            while (true)
            {
                attempts++;

                DialogResult result = MessageBox.Show($"Це число {guess}?", "Вгадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Вгадав! Це число {guess}. було потрібно {attempts} спроб.", "Виграв!");
                    var playAgain = MessageBox.Show("Хочете ще зіграти", "Игра вгадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (playAgain == DialogResult.Yes)
                    {
                        InitializeGame();
                        return;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (result == DialogResult.No)
                {
                    guess = (guess + 2000) / 2;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            GuessNumber();
        }
    }
}


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys.HasFlag(Keys.Control)) 
                {
                    Application.Exit();
                }
                else
                {
                    int leftBoundary = 10;
                    int rightBoundary = this.Width - 10;
                    int topBoundary = 10;
                    int bottomBoundary = this.Height - 10;

                    if (e.X >= leftBoundary && e.X <= rightBoundary && e.Y >= topBoundary && e.Y <= bottomBoundary)
                    {
                        MessageBox.Show("Точка знаходитсься зовні", "Кординати");
                    }
                    else if (e.X < leftBoundary || e.X > rightBoundary || e.Y < topBoundary || e.Y > bottomBoundary)
                    {
                        MessageBox.Show("Точка знаходитсься зовні", "Кординати");
                    }
                    else
                    {
                        MessageBox.Show("Точка знаходитсься зовні", "МКординати");
                    }
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Кординати миші: X = {e.X}, Y = {e.Y}";
        }
    }
}

