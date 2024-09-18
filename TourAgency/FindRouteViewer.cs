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
    public partial class FindRouteViewer : Form
    {

        public bool result = false;
        List<bool> Enabled; int route_id; int city_id; string description; int hotelId; int regionId; int countryId; int ageId; int foodsId; int poolsId; string hotelName; bool nearBeach; bool inCenter; int starsId;
        public FindRouteViewer(List<bool> Enabled, int route_id, int city_id, string description, int hotelId, int regionId, int foodsId, int countryId, int ageId, int poolsId, int starsId, string hotelName, bool nearBeach, bool inCenter)
        {
            InitializeComponent();
            this.Enabled = Enabled;
            this.hotelId = hotelId;
            this.regionId = regionId;
            this.countryId = countryId;
            this.ageId = ageId;
            this.poolsId = poolsId;
            this.hotelName = hotelName;
            this.nearBeach = nearBeach;
            this.inCenter = inCenter;
            this.foodsId = foodsId;
            this.starsId = starsId;
            this.route_id = route_id;
            this.city_id = city_id;
            this.description = description;
            Refresh();
        }

        public void Refresh()
        {
            int paramsCount = 0;
            string query = "select * from (select b.*, departure_cities.name as city_name from(select a.*, routes.id as routes_id, routes.departure_city_id,  routes.description from (select dt.*, country_types.name as country_name from \r\n(select hotels.id as hotel_id, hotels.region_id,hotels.foodstype_id,hotels.ageCategory_id,hotels.name as hotels_name,\r\n hotels.pools_category, hotels.stars_count,hotels.near_beach,hotels.in_center, foods_types.name as food_name, pools_categories.name as pool_name, \r\n ageCategory_types.name as ageCategory, ageCategory_types.allowedChildAges,\r\nregion_types.region_name, region_types.country_id  from hotels inner join foods_types on hotels.foodstype_id=foods_types.id\r\ninner join pools_categories on hotels.pools_category=pools_categories.id\r\ninner join ageCategory_types on hotels.agecategory_id=ageCategory_types.id\r\ninner join region_types on hotels.region_id=region_types.id) dt Inner join country_types on dt.country_id=country_types.id) a inner join routes on routes.hotel_id=a.hotel_id) b\r\ninner join departure_cities on departure_cities.id=b.departure_city_id) c ";
            if (Enabled[0])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"routes_id={route_id} ";
            }
            if (Enabled[1])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"departure_city_id={city_id} ";
            }
            if (Enabled[2])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"description like \'%{description}%\' ";
            }
            if (Enabled[3])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"hotel_id={hotelId} ";
            }
            if (Enabled[4])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"region_id={regionId} ";
            }
            if (Enabled[5])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"foodstype_id={foodsId} ";
            }
            if (Enabled[6])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"country_id={countryId} ";
            }
            if (Enabled[7])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"ageCategory_id={ageId} ";
            }
            if (Enabled[8])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"pools_category={poolsId} ";
            }
            if (Enabled[9])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"stars_count={starsId} ";
            }
            if (Enabled[10])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"hotels_name like \'%{hotelName}%\' ";
            }
            if (Enabled[11])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"near_beach=";
                if (nearBeach)
                {
                    query = query + "true ";
                }
                else
                {
                    query = query + "false ";
                }
            }
            if (Enabled[12])
            {
                if (paramsCount == 0)
                {
                    query = query + $"where ";
                }
                else
                {
                    query = query + $"and ";
                }
                paramsCount++;
                query = query + $"in_center=";
                if (inCenter)
                {
                    query = query + "true ";
                }
                else
                {
                    query = query + "false ";
                }
            }
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Form1.connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            DeleteButton.Enabled = false;
            Changebutton.Enabled = false;
        }

        private void FindRouteViewer_Load(object sender, EventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            ChangeRoute cr = new ChangeRoute(Convert.ToInt32(dataGridView1.SelectedCells[16].Value));
            cr.ShowDialog();
            Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command1 = new MySqlCommand($"select Count(*) from (select * from tickets where route_id={dataGridView1.SelectedCells[16].Value}) dt", Form1.connection);
            int res = Convert.ToInt32(command1.ExecuteScalar());
            MySqlCommand command2 = new MySqlCommand($"delete from routes where id={dataGridView1.SelectedCells[16].Value}", Form1.connection);
            if (res == 0)
            {
                command2.ExecuteNonQuery();
                Refresh();
            }
            else
            {
                result = false;
                DeleteRoute warn = new DeleteRoute(this);
                warn.ShowDialog();
                if (result == true)
                {
                    command2.ExecuteNonQuery();
                    Refresh();
                }
            }
            Refresh();
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = true;
            Changebutton.Enabled = true;
        }
    }
}
