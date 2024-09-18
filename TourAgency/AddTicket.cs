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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TourAgency
{
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand($"select Count(*) from (select * from routes where id={numericUpDownRoute.Value}) dt", Form1.connection);
            int res = Convert.ToInt32(comm.ExecuteScalar());
            if (res == 0)
            {
                MessageBox.Show("Маршрута с данным индексом нет в базе!");
            }
            else 
            {
                MySqlCommand comm1 = new MySqlCommand($"insert into tickets (persons_count,route_id,tickets_count,nights_count,flight_out_time," +
                    $"return_flight_time,price_child,price_adult) values " +
                    $"({numericUpDownPeople.Value},{numericUpDownRoute.Value},{numericUpDownTickets.Value},{numericUpDownNights.Value},\'{dateTimePicker1.Value.ToString("yyyy-MM-dd H:mm:ss")}\',\'{dateTimePicker2.Value.ToString("yyyy-MM-dd H:mm:ss")}\'," +
                    $"{numericUpDownPriceChild.Value},{numericUpDownPriceAdult.Value})", Form1.connection);
                comm1.ExecuteNonQuery();
                Close();
            }
            
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
