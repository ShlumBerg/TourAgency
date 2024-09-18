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
    public partial class MainEntitiesAddForm : Form
    {
        string tableName;
        MainEntitiesForm form;
        public MainEntitiesAddForm(string tableName,string addText,string changeText,MainEntitiesForm form)
        {
            this.form = form;
            this.tableName = tableName;
            InitializeComponent();
            label1.Text = addText;
        }

        private void MainEntitiesAddForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"insert into {tableName} (name) values (\'{textBox1.Text}\')",Form1.connection);
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
