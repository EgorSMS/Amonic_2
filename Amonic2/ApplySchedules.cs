using Microsoft.VisualBasic.FileIO;
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
    public partial class ApplySchedules : Form
    {
        public ApplySchedules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "schedule Files|*.csv";
            dialog.Title = "Выберите график билета: ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != null)
                {
                    textBox1.Text = dialog.FileName;

                    using (TextFieldParser parser = new TextFieldParser(dialog.FileName))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();
                            foreach (string field in fields)
                            {
                                MessageBox.Show(field);
                            }
                        }
                    }
                }
            }
        }
    }
}
