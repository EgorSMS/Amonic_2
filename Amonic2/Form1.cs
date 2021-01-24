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
            GetCB();
        }
        private void GetCB()
        {
            connection = new SqlConnection(str);
            try
            {
                connection.Open();
                da = new SqlDataAdapter("SELECT * FROM Users", connection);
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "ID";
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
            EditFlight editFlight = new EditFlight();
            editFlight.Hide();
            editFlight.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            cmd = new SqlCommand($"SELECT ID as 'ID', CountryID as 'CountryID', IATACode as 'IATACode',  Name as 'Name' FROM Airports Where Name like '%" + comboBox1.Text + "'", connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dataTable.DefaultView;
            connection.Close();
        }
    }
}
