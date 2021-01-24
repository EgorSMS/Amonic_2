using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amonic2
{
    public partial class EditFlight : Form
    {
        public EditFlight()
        {
            InitializeComponent();
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = "HH:mm";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Hide();
            //EditFlight editFlight = new EditFlight();
            //editFlight.Hide();
            //editFlight.Close();
        }
    }
}
