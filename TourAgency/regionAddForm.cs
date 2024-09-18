using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TourAgency
{
    public partial class regionAddForm : Form
    {
        regionForm rf;
        public regionAddForm(regionForm rf)
        {
            this.rf = rf;
            InitializeComponent();
            comboBox1.DataSource = rf.countryNamesStrings;
        }

        private void regionAddForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Не выбрана страна для региона!");
            }
            else
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"insert into region_types (region_name,country_id) values (\'{textBox1.Text}\',{rf.ids[comboBox1.SelectedIndex]})", Form1.connection);
                cmd.ExecuteNonQuery();
                rf.showAll();
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var charsToRemove = new string[] { "\'", "%", "_", "\\" };
            foreach (var c in charsToRemove)
            {
                ((System.Windows.Forms.TextBox)sender).Text = ((System.Windows.Forms.TextBox)sender).Text.Replace(c, string.Empty);
            }
        }
    }
}
