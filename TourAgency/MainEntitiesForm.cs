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
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
namespace TourAgency
{
    public partial class MainEntitiesForm : Form
    {
        string tableName = "";
        string nameText = "";
        string changeText = "";
        string linkedTable = "";
        string linkedAttribute = "";
        public bool result=false;
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

        

        public MainEntitiesForm(string tableName,string nameText,string changeText,string linkedTable,string linkedAttribute)
        {
            this.tableName = tableName;
            this.nameText = nameText;
            this.changeText = changeText;
            this.linkedTable = linkedTable;
            this.linkedAttribute = linkedAttribute;
            InitializeComponent();
            showAll();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainEntitiesAddForm formAdd = new MainEntitiesAddForm(tableName,nameText,changeText,this);
            formAdd.ShowDialog();
        }

        private void MainEntitiesForm_Load(object sender, EventArgs e)
        {

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
                CascadeWarning warn = new CascadeWarning(this);
                warn.ShowDialog();
                if (result == true) 
                {
                    command2.ExecuteNonQuery();
                    showAll();
                }
            }
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            MainEntitiesChangeForm changeForm = new MainEntitiesChangeForm(tableName, changeText, this);
            changeForm.ShowDialog();
        }
    }
}
