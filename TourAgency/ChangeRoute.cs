using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class ChangeRoute : Form
    {
        List<int> ids = new List<int>();
        List<string> cities = new List<string>();
        int id;
        public ChangeRoute(int id)
        {
            InitializeComponent();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"select * from departure_cities", Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cities.Add((string)row[1]);
                ids.Add((int)row[0]);
            }
            comboBoxCity.DataSource = cities;
            this.id = id;
        }

        private void ChangeRoute_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command1 = new MySqlCommand($"select Count(*) from (select * from hotels where id={numericUpDown1.Value}) dt", Form1.connection);
            int res = Convert.ToInt32(command1.ExecuteScalar());
            if (comboBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Поле города отправления не заполнено! Для Изменения маршрута нужно заполнить все поля!");
            }
            else if (res == 0)
            {
                MessageBox.Show("Отеля с выбранным индексом не существует в базе данных!");
            }
            else 
            {
                MySqlCommand comm = new MySqlCommand($"update routes set hotel_id={numericUpDown1.Value},departure_city_id={ids[comboBoxCity.SelectedIndex]}, description=\'{textBox1.Text}\' where id={id}", Form1.connection);
                comm.ExecuteNonQuery();
                Close();
            }
        }
    }
}
