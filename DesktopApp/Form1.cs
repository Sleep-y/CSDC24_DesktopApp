using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {

        DateTime selectedDay;

        String monthname;

        int month;
        int year;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void btnnxt_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //increment next month//
            month++;

            if (month >= 13)
            {
                year += 1;
                month = 1;
            }

            monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            //get the first da of the month//

            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days of the month//
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to int//
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            //created black usercontol//
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //created user control for days//
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            
            DateTime datePass;

            //increment previous month//
            month--;

            if (month <= 0)
            {
                year -= 1;
                month = 12;
            }

            monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            //get the first da of the month//

            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days of the month//
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to int//
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //created black usercontol//
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //created user control for days//
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                datePass = new DateTime(year, month, i);
                ucdays.getDate(datePass);
            }
        }

        private void daycontainer_Click(object sender, EventArgs e)
        {

        }

        public void getSelected(DateTime date)
        {
            selectedDay = date;
        }

        private void displaDays()

        {
            DateTime datePass;

            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            dtSelectedDate.Text = String.Format("{0:yyyy}/{0:MM}/{0:dd}", now);

            //get the first da of the month//

            DateTime startofthemonth = new DateTime( year, month, 1);

            //get the count of days of the month//
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to int//
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //created black usercontol//
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //created user control for days//
            for (int i = 1;i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                datePass = new DateTime(year, month, i);
                ucdays.getDate(datePass);
            }
            Console.WriteLine($"Month: {0}", month);
        }
    }
}
