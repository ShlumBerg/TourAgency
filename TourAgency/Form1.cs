using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TourAgency
{
    public partial class Form1 : Form
    {
        static public string connectionString = null;
        static public MySql.Data.MySqlClient.MySqlConnection connection;
        
        public Form1()
        {            
            InitializeComponent();           
        }

        public void activateMenuStrip() 
        {
            foreach (ToolStripItem obj in menuStrip1.Items) 
            {
                obj.Enabled = true;
            }
        }

        public void deactivateMenuStrip()
        {
            foreach (ToolStripItem obj in menuStrip1.Items)
            {                
                obj.Enabled = false;
            }
            toolStripMenuItem2.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm connForm = new ConnectionForm(this);
            connForm.ShowDialog();
        }

        private void AgeCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgeCategoryForm form = new AgeCategoryForm();
            form.ShowDialog();
        }

        private void просмотрToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MainEntitiesForm form = new MainEntitiesForm("pools_categories", "Введите название типа отеля по категории бассейнов:","Введите новое название типа отеля по категории бассейнов:","hotels","pools_category");
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activateMenuStrip();
            connectionString = ($"server=localhost;database=db;uid=root;pwd=password");
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void просмотрToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            regionForm rf = new regionForm();
            rf.ShowDialog();
        }

        private void просмотрToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MainEntitiesForm form = new MainEntitiesForm("country_types","Введите название страны:", "Введите новое назвение страны", "region_types","country_id");
            form.ShowDialog();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainEntitiesForm form = new MainEntitiesForm("foods_types", "Введите категорию отеля по типу питания:", "Введите новую категорию отеля по типу питания", "hotels", "foodstype_id");
            form.ShowDialog();
        }

        private void просмотрToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainEntitiesForm form = new MainEntitiesForm("departure_cities", "Введите название города отправления:", "Введите новое название города отправления", "routes", "departure_city_id");
            form.ShowDialog();
        }

        private void добавитьОтельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHotel form = new AddHotel();
            form.ShowDialog();
        }

        private void найтиОтельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindHotel fh = new FindHotel();
            fh.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoute rt = new AddRoute();
            rt.ShowDialog();
        }

        private void найтиМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindRoute fr = new FindRoute();
            fr.ShowDialog();
        }

        private void добавитьБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseTickets form = new BrowseTickets();
            form.ShowDialog();
        }

        private void удалитьНеактуальныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("delete from tickets where flight_out_time<NOW()", connection);
            com.ExecuteNonQuery();
            MessageBox.Show("Неактульные билеты удалены!");
        }
    }
}
