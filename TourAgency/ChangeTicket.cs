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
    public partial class ChangeTicket : Form
    {
        int id; int personsCount; int routeId; int ticketsCount; int nightsCount; string startDate; string endDate; int priceChild; int priceAdult;
        public ChangeTicket(int id, int personsCount,int routeId,int ticketsCount, int nightsCount,string startDate,string endDate,int priceChild,int priceAdult)
        {
            InitializeComponent();
            this.id = id;
            numericUpDownNights.Value = nightsCount;
            numericUpDownPeople.Value = personsCount;
            numericUpDownPriceAdult.Value = priceAdult;
            numericUpDownPriceChild.Value = priceChild;
            numericUpDownRoute.Value = routeId;
            numericUpDownTickets.Value = ticketsCount;
            dateTimePicker1.Value = DateTime.ParseExact(startDate, "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            dateTimePicker2.Value = DateTime.ParseExact(endDate, "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void ChangeTicket_Load(object sender, EventArgs e)
        {

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
                MySqlCommand comm1 = new MySqlCommand($"update tickets set persons_count={numericUpDownPeople.Value},route_id={numericUpDownRoute.Value},tickets_count={numericUpDownTickets.Value}" +
                    $",nights_count={numericUpDownNights.Value},flight_out_time=\'{dateTimePicker1.Value.ToString("yyyy-MM-dd H:mm:ss")}\'," +
                    $"return_flight_time=\'{dateTimePicker2.Value.ToString("yyyy-MM-dd H:mm:ss")}\',price_child={numericUpDownPriceChild.Value},price_adult={numericUpDownPriceAdult.Value} where id={id}", Form1.connection);
                comm1.ExecuteNonQuery();
                Close();
            }

        }
    }
}
