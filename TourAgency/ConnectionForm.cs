using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgency
{
    public partial class ConnectionForm : Form
    {
        Form1 parentForm;
        public ConnectionForm(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Form1.connectionString = $"server=localhost;database={textBoxDB.Text};uid={textBoxName.Text};pwd={textBoxPassword.Text}";
            try
            {
                Form1.connection = new MySql.Data.MySqlClient.MySqlConnection(Form1.connectionString);
                Form1.connection.Open();
                MessageBox.Show("База данных MySQL был подключена!");
                parentForm.activateMenuStrip();
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Не получилось подключиться к базе данных MySQL!");
                parentForm.deactivateMenuStrip();
            }
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
