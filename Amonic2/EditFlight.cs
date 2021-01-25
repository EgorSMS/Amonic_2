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
    public partial class EditFlight : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session2_17;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlCommand cmd;
        int userID = 0;
        public EditFlight(string id, string from, string to, string aircraft, string date, string time, string price)
        {
            InitializeComponent();
            this.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBox.CustomFormat = "HH:mm";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (priceBox.Text.Length > 0)
            {
                connection = new SqlConnection(str);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand(String.Format("UPDATE Schedules SET Date='{0}', Time='{1}', EconomyPrice='{2}' WHERE ID={3}", dateBox.Text, timeBox.Text, priceBox.Text, userID), connection);
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
                (Application.OpenForms["SchedulePanel"] as Form1).UpdateGridSchedules();
                this.Close();
            }
            else MessageBox.Show("Необходимо заполнить ВСЕ поля");
        }
    }
}
