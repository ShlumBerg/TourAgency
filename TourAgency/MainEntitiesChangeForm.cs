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
    public partial class MainEntitiesChangeForm : Form
    {
        string tableName;
        MainEntitiesForm form;
        public MainEntitiesChangeForm(string tableName, string nameChangeText, MainEntitiesForm form)
        {
            this.form = form;
            this.tableName = tableName;
            InitializeComponent();
            label1.Text = nameChangeText;
            textBox1.Text = (string)form.dataGridView1.SelectedCells[1].Value;
        }

        private void MainEntitiesChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"update {tableName} set name = \'{textBox1.Text}\' where id={form.dataGridView1.SelectedCells[0].Value}", Form1.connection);
            cmd.ExecuteNonQuery();
            form.showAll();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var charsToRemove = new string[] { "\'", "%", "_", "\\" };
            foreach (var c in charsToRemove)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(c, string.Empty);
            }
        }
    }
}
