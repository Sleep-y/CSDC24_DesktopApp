﻿using System;
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
    public partial class EventForm : Form
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

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'townCrierDBDataSet.FREQUENCIES' table. You can move, or remove it, as needed.
            this.fREQUENCIESTableAdapter.Fill(this.townCrierDBDataSet.FREQUENCIES);
            // TODO: This line of code loads data into the 'townCrierDBDataSet.FREQUENCIES' table. You can move, or remove it, as needed.
            this.fREQUENCIESTableAdapter.Fill(this.townCrierDBDataSet.FREQUENCIES);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnect();
            conn.Open();
            string cmd = String.Format($"INSERT INTO MARKS (markName, freqID) VALUES ({txtEventName.Text}, {Int64.Parse(cmbEventFreq.Text)});" +
                $"INSERT INTO EVENTS (eventDateStart, eventDateEnd, eventTimeStart, eventTimeEnd, eventLocation");
            dbCmd = conn.CreateCommand();
            dbCmd.CommandText = cmd;
            dbCmd.ExecuteNonQuery();

            while (dbReader.Read())
            {
                //Console.WriteLine(dbReader.GetValue(0).ToString());
            }

            conn.Close();
        }
    }
}
