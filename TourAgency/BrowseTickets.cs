using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class BrowseTickets : Form
    {
        public BrowseTickets()
        {
            InitializeComponent();
            Update();
        }

        public void Update() 
        {
            DeleteButton.Enabled = false;
            Changebutton.Enabled = false;
            MySqlCommand command = new MySqlCommand("select * from tickets");
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from tickets", Form1.connection);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            DeleteButton.Enabled = true;
            Changebutton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTicket form = new AddTicket();
            form.ShowDialog();
            Update();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand($"delete from tickets where id={dataGridView1.SelectedCells[0].Value}",Form1.connection);
            comm.ExecuteNonQuery();
            Update();
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            ChangeTicket form = new ChangeTicket(Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(dataGridView1.SelectedCells[1].Value), Convert.ToInt32(dataGridView1.SelectedCells[2].Value), Convert.ToInt32(dataGridView1.SelectedCells[3].Value)
                , Convert.ToInt32(dataGridView1.SelectedCells[4].Value), Convert.ToString(dataGridView1.SelectedCells[5].Value), Convert.ToString(dataGridView1.SelectedCells[6].Value), 
                Convert.ToInt32(dataGridView1.SelectedCells[7].Value), Convert.ToInt32(dataGridView1.SelectedCells[8].Value));
            form.ShowDialog();
            Update();
        }
    }
}
