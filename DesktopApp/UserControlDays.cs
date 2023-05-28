using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        String dbConn = "Data Source=DESKTOP-KS5N5OK;Initial Catalog = TownCrierDB; Integrated Security = True";
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;

        private void sqlConnect()
        {
            conn = new SqlConnection(dbConn);
        }

        public UserControlDays()
        {
            InitializeComponent();
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

        public void updateSelf()
        {
            sqlConnect();
            conn.Open();
            string cmd = String.Format("SELECT taskName FROM TASKS " +
                $"WHERE taskDate = '{ucDate.Date.ToShortDateString()}'");
            dbCmd = conn.CreateCommand();
            dbCmd.CommandText = cmd;
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                ucDayList.Items.Add(dbReader.GetValue(0).ToString());
                //Console.WriteLine(dbReader.GetValue(0).ToString());
            }

            conn.Close();
        }

        private void UserControlDays_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
