using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgency
{
    public partial class regionUpdateForm : Form
    {
        regionForm rf;
        public regionUpdateForm(regionForm rf)
        {
            this.rf = rf;
            InitializeComponent();
            comboBox1.DataSource = rf.countryNamesStrings;
        }

        private void regionUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана страна для региона!");
            }
            else
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"update region_types set region_name=\'{textBox1.Text}\',country_id={rf.ids[comboBox1.SelectedIndex]} where id={rf.dataGridView1.SelectedCells[0].Value}", Form1.connection);
                cmd.ExecuteNonQuery();
                rf.showAll();
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var charsToRemove = new string[] { "\'", "%", "_", "\\"};
            foreach (var c in charsToRemove)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(c, string.Empty);
            }
        }
    }
}
