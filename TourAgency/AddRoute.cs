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
    public partial class AddRoute : Form
    {
        List<int> citiesIds = new List<int>();
        List<string> citiesRes = new List<string>();
        public AddRoute()
        {
            InitializeComponent();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"select * from departure_cities", Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                citiesRes.Add((string)row[1]);
                citiesIds.Add((int)row[0]);
            }
            comboBoxCity.DataSource = citiesRes;
        }

        private void AddRoute_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comm=new MySqlCommand($"select Count(*) from (select * from hotels where id={numericUpDown1.Value}) dt", Form1.connection);
            int res = Convert.ToInt32(comm.ExecuteScalar());
            if (comboBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран город отбытия!");
            }
            else if (res == 0)
            {
                MessageBox.Show("Отеля с выбранным индексом не существует в базе данных!");
            }
            else 
            {
                MySqlCommand comm1 = new MySqlCommand($"insert into routes (hotel_id,departure_city_id,description) values ({numericUpDown1.Value},{citiesIds[comboBoxCity.SelectedIndex]},\'{textBox1.Text}\')", Form1.connection);
                comm1.ExecuteNonQuery();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
