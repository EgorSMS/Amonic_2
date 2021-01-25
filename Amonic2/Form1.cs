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

namespace Amonic2
{
    public partial class Form1 : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session2_17;User ID=sa;Password=123456";
        private SqlCommand cmd;
        private SqlConnection connection;
        private DataSet ds, dsoffices;
        private SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            //GetCB();
            UpdateGridSchedules();
        }
        //private void GetCB()
        //{
        //    connection = new SqlConnection(str);
        //    try
        //    {
        //        connection.Open();
        //        da = new SqlDataAdapter("SELECT * FROM Users", connection);
        //        ds = new DataSet();
        //        da.Fill(ds);
        //        comboBox1.DataSource = ds.Tables[0];
        //        comboBox1.DisplayMember = "ID";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        public void UpdateGridSchedules()
        {
            connection = new SqlConnection(str);
            try
            {
                connection.Open();

                ds = new DataSet();
                SqlDataAdapter DAShedule = new SqlDataAdapter("SELECT Schedules.Date AS 'Date', Schedules.Time AS 'Time', (SELECT IATACode FROM Airports WHERE ID = Routes.DepartureAirportID) AS 'From', (SELECT IATACode FROM Airports WHERE ID = Routes.ArrivalAirportID) AS 'To', Schedules.FlightNumber AS 'Flight number', Aircrafts.Name AS 'Aircraft', CAST(Schedules.EconomyPrice AS int) AS 'Economy price', FLOOR(Schedules.EconomyPrice+(Schedules.EconomyPrice*0.35)) AS 'Business price', FLOOR(Schedules.EconomyPrice+(Schedules.EconomyPrice*0.30)) AS 'First class price', Schedules.Confirmed, Schedules.ID FROM Schedules INNER JOIN Aircrafts ON Schedules.AircraftID = Aircrafts.ID INNER JOIN Routes ON Schedules.RouteID = Routes.ID", connection);
                DAShedule.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (row.Cells[9].Value.ToString() == "False") row.DefaultCellStyle.BackColor = Color.Red;
                //    else row.DefaultCellStyle.BackColor = Color.White;
                //}

                DataSet DSFrom = new DataSet();
                SqlDataAdapter DAFrom = new SqlDataAdapter("SELECT IATACode FROM Airports", connection);
                DAFrom.Fill(DSFrom);
                DSFrom.Tables[0].Rows.Add("");

                DataSet DSTo = new DataSet();
                SqlDataAdapter DATo = new SqlDataAdapter("SELECT IATACode FROM Airports", connection);
                DATo.Fill(DSTo);
                DSTo.Tables[0].Rows.Add("");

                fromBox.DataSource = DSFrom.Tables[0];
                fromBox.DisplayMember = "IATACode";
                fromBox.ValueMember = "IATACode";

                toBox.DataSource = DSTo.Tables[0];
                toBox.DisplayMember = "IATACode";
                toBox.ValueMember = "IATACode";

                fromBox.SelectedIndex = fromBox.Items.Count - 1;
                toBox.SelectedIndex = toBox.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // EDIT FLIGHT
        {
            EditFlight editFlight = new EditFlight(dataGridView1.CurrentRow.Cells[10].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString());
            editFlight.Hide();
            editFlight.Show();
        }

        private void button1_Click(object sender, EventArgs e) // apply
        {
            int FilterCounter = 0;
            if (fromBox.SelectedValue.ToString().Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("From = '{0}'", fromBox.SelectedValue.ToString());
            else FilterCounter++;
            if (fromBox.SelectedValue.ToString().Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("To = '{0}'", toBox.SelectedValue.ToString());
            else FilterCounter++;
            if (flnumberBox.Text.Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Flight number = '{0}'", flnumberBox.Text);
            else FilterCounter++;
            if (dateBox.Text != "") (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date = '{0}'", dateBox.Text);
            else FilterCounter++;
            if (FilterCounter == 4 && dateBox.Text == "") (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

            switch (sortBy.SelectedIndex)
            {
                case 0:
                    dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Descending);
                    break;
                case 1:
                    dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Ascending);
                    break;
                case 2:
                    dataGridView1.Sort(dataGridView1.Columns["Economy price"], ListSortDirection.Ascending);
                    break;
                case 3:
                    dataGridView1.Sort(dataGridView1.Columns["Confirmed"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplySchedules ImportScheduleForm = new ApplySchedules();
            ImportScheduleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // CANCEL
        {
            string TempFlightActive = "";
            if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "True") TempFlightActive = "False";
            else TempFlightActive = "True";

            connection = new SqlConnection(str);
            try
            {
                connection.Open();
                cmd = new SqlCommand(String.Format("UPDATE Schedules SET Confirmed='{0}' WHERE ID='{1}'", TempFlightActive, dataGridView1.SelectedRows[0].Cells[10].Value), connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            UpdateGridSchedules();
        }
    }
}
