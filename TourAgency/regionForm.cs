using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class regionForm : Form
    {
        string tableName = "region_types";
        string linkedTable = "hotels";
        string linkedAttribute = "region_id";
        public bool result = false;
        public List<string> countryNamesStrings=new List<string>();
        public List<int> ids = new List<int>();
        public regionForm()
        {
            InitializeComponent();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"select * from country_types", Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) 
            {
                countryNamesStrings.Add((string)row[1]);
                ids.Add((int)row[0]);
            }
            showAll();
        }

        public void showAll()
        {
            string query = $"Select * From {tableName}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            DeleteButton.Enabled = false;
            Changebutton.Enabled = false;

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            regionAddForm formAdd = new regionAddForm(this);
            formAdd.ShowDialog();
        }

        private void regionForm_Load(object sender, EventArgs e)
        {

        }


        private void Changebutton_Click(object sender, EventArgs e)
        {
            regionUpdateForm changeForm = new regionUpdateForm(this);
            changeForm.ShowDialog();
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = true;
            Changebutton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command1 = new MySqlCommand($"select Count(*) from (select * from {linkedTable} where {linkedAttribute}={dataGridView1.SelectedCells[0].Value}) dt", Form1.connection);
            int res = Convert.ToInt32(command1.ExecuteScalar());
            MySqlCommand command2 = new MySqlCommand($"delete from {tableName} where id={dataGridView1.SelectedCells[0].Value}", Form1.connection);
            if (res == 0)
            {
                command2.ExecuteNonQuery();
                showAll();
            }
            else
            {
                result = false;
                regionDeleteForm warn = new regionDeleteForm(this);
                warn.ShowDialog();
                if (result == true)
                {
                    command2.ExecuteNonQuery();
                    showAll();
                }
            }
        }
    }
}
