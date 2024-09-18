using MySql.Data.MySqlClient;
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
    public partial class AgeCategoryForm:Form
    {
        string tableName = "ageCategory_types";
        string linkedTable = "hotels";
        string linkedAttribute = "ageCategory_id";
        public bool result = false;




        public AgeCategoryForm()
        {
            InitializeComponent();
            showAll();
        }

        public void showAll()
        {
            string query = $"Select * From {tableName}";
            MySqlCommand command = new MySqlCommand(query);
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
            AgeCategoryFormAdd formAdd = new AgeCategoryFormAdd(this);
            formAdd.ShowDialog();
        }

        private void AgeCategoryForm_Load(object sender, EventArgs e)
        {

        }


        private void Changebutton_Click(object sender, EventArgs e)
        {
            AgeCategoryFormChange changeForm = new AgeCategoryFormChange(this);
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
                AgeCategoryFormWarning warn = new AgeCategoryFormWarning(this);
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
