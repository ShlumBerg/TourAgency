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
    public partial class AgeCategoryFormChange : Form
    {
        AgeCategoryForm form;
        public AgeCategoryFormChange(AgeCategoryForm form)
        {
            this.form = form;
            InitializeComponent();
            textBox1.Text = (string)form.dataGridView1.SelectedCells[1].Value;
        }

        private void AgeCategoryFormChange_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool goodFormat = textBox2.Text.Length == 18;
            foreach (char ch in textBox2.Text)
            {
                if (ch != '0' && ch != '1')
                {
                    goodFormat = false;
                }
            }
            if (!goodFormat)
            {
                MessageBox.Show("Заданная строка допустимых возрастов детей не соответствует формату!");
            }
            else
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"update ageCategory_types set name = \'{textBox1.Text}\',allowedChildAges=\'{textBox2.Text}\' where id={form.dataGridView1.SelectedCells[0].Value}", Form1.connection);
                cmd.ExecuteNonQuery();
                form.showAll();
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
