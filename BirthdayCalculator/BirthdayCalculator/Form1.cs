using System;
using System.Windows.Forms;

namespace BirthdayCalculator
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

        private void button1_Click(object sender, EventArgs e)
        {


            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            if (endDate < startDate)
            {
                MessageBox.Show("Втората дата трябва да е след първата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // спира изпълнението на метода, за да няма грешка
            }
            TimeSpan difference = endDate - startDate;
            int days = Math.Abs(difference.Days);

            int years = endDate.Year - startDate.Year;
            if (endDate < startDate.AddYears(years))
            {
                years--;
            }


            DateTime today = DateTime.Today;
            DateTime birthdayThisYear = new DateTime(today.Year, startDate.Month, startDate.Day);
            if (birthdayThisYear < today)
                birthdayThisYear = birthdayThisYear.AddYears(1);

            int daysToBirthday = (birthdayThisYear - today).Days;

            labelResult.Text = $"Разлика в дни: {days} дни\nНавършени години: {years}\nДо следващия рожден ден остават: {daysToBirthday} дни";
        }

    

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            labelResult.Text = "Резултат:";
        }
    }
}
