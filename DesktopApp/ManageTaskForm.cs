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
using System.Xml.Linq;

namespace DesktopApp
{
    public partial class ManageTaskForm : Form
    {
        String dbConn = "Data Source=DESKTOP-KS5N5OK;Initial Catalog = TownCrierDB; Integrated Security = True";
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;

        DateTime selectedDate;

        private void sqlConnect()
        {
            conn = new SqlConnection(dbConn);
        }

        public void getDate(DateTime date)
        {
            selectedDate = date;
        }

        private void getTasks()
        {
            sqlConnect();
            conn.Open();
            string cmd = String.Format("SELECT * FROM TASKS " +
                $"WHERE taskDate = '{selectedDate.ToShortDateString()}'");
            dbCmd = conn.CreateCommand();
            dbCmd.CommandText = cmd;
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                dgvSelectedDate.Rows.Add(dbReader.GetInt64(0), dbReader.GetString(1), dbReader.GetDateTime(2).ToShortDateString(), dbReader.GetSqlBinary(3), dbReader.GetDateTime(4).ToShortDateString(), dbReader.GetInt16(5));
                //Console.WriteLine(dbReader.GetValue(0).ToString());
            }

            conn.Close();
        }

        public ManageTaskForm()
        {
            InitializeComponent();
        }

        private void ManageTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'townCrierDBDataSet.FREQUENCIES' table. You can move, or remove it, as needed.
            this.fREQUENCIESTableAdapter.Fill(this.townCrierDBDataSet.FREQUENCIES);
            lblSelectedDate.Text = String.Format("{0:MMMM} {0:dd} {0:yyyy}", selectedDate.ToString());
            getTasks();
        }
    }
}
