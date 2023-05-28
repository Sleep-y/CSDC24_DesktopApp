using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UserControlDays : UserControl
    {

        DateTime ucDate;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void getDate(DateTime date) 
        {
            ucDate = date;
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void ucPassDate()
        {
            Form hostForm = this.FindForm();
            Control[] ctrl = hostForm.Controls.Find("dtSelectedDate", false);
            ctrl[0].Text = String.Format("{0:yyyy}/{0:MM}/{0:dd}", ucDate);
            Console.WriteLine(ctrl[0].Text);
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            ucPassDate();
        }

        private void ucDayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucPassDate();
        }

        private void ucDayList_Click(object sender, EventArgs e)
        {
            ucPassDate();
        }
    }
}
