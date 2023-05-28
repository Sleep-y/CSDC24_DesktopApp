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
    public partial class TaskForm : Form
    {

        String dbConn = "Data Source=DESKTOP-KS5N5OK;Initial Catalog = TownCrierDB; Integrated Security = True";
        SqlConnection conn;
        SqlDataReader dbReader;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;

        private void sqlConnect()
        {
            conn = new SqlConnection(dbConn);
        }

        public TaskForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnect();
            conn.Open();
            string cmd = String.Format($"INSERT INTO MARKS (markName, freqID) VALUES ({txtTaskName.Text}, {Int64.Parse(cmbTaskFreq.Text)});" +
                $"INSERT INTO TASKS (taskDate, taskIsDone) VALUES ({dtTaskDate.Text})");
            dbCmd = conn.CreateCommand();
            dbCmd.CommandText = cmd;
            dbCmd.ExecuteNonQuery();

            while (dbReader.Read())
            {
                //Console.WriteLine(dbReader.GetValue(0).ToString());
            }

            conn.Close();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'townCrierDBDataSet.FREQUENCIES' table. You can move, or remove it, as needed.
            this.fREQUENCIESTableAdapter.Fill(this.townCrierDBDataSet.FREQUENCIES);

        }
    }
}
