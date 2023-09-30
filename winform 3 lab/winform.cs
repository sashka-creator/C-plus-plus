using System.Collections.Generic;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System;
using System.Windows.Forms;

namespace DateTimePickerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calendarDateTimePicker.Visible)
            {
                calendarDateTimePicker.Visible = false;
            }
            else
            {
                calendarDateTimePicker.Visible = true;
            }
        }

        private void calendarDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            selectedDateLabel.Text = calendarDateTimePicker.Value.ToShortDateString();
        }
    }
}


namespace RunningStaticApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int maxX = this.ClientSize.Width - pictureBox1.Width;
            int maxY = this.ClientSize.Height - pictureBox1.Height;
            int newX = rand.Next(maxX);
            int newY = rand.Next(maxY);

            pictureBox1.Location = new Point(newX, newY);
        }
    }
}

namespace DayOfWeekApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckDay_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text, out DateTime date))
            {
                string dayOfWeek = date.ToString("dddd");
                textBox2.Text = dayOfWeek;
            }
            else
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка");
            }
        }
    }
}

namespace TimeRemainingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateTimeRemaining(DateTime targetDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan timeRemaining = targetDate - currentDate;

            if (radioYears.Checked)
            {
                double yearsRemaining = timeRemaining.TotalDays / 365.25; // Учитываем високосные года
                textBox2.Text = yearsRemaining.ToString("F2") + " лет";
            }
            else if (radioMonths.Checked)
            {
                double monthsRemaining = timeRemaining.TotalDays / 30.44; // Усредненное количество дней в месяце
                textBox2.Text = monthsRemaining.ToString("F2") + " месяцев";
            }
            else if (radioDays.Checked)
            {
                textBox2.Text = timeRemaining.TotalDays.ToString("F2") + " дней";
            }
            else if (radioMinutes.Checked)
            {
                textBox2.Text = timeRemaining.TotalMinutes.ToString("F2") + " минут";
            }
            else if (radioSeconds.Checked)
            {
                textBox2.Text = timeRemaining.TotalSeconds.ToString("F2") + " секунд";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text, out DateTime targetDate))
            {
                CalculateTimeRemaining(targetDate);
            }
            else
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка");
            }
        }
    }
}


