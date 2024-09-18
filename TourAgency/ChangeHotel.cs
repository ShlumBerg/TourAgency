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
    public partial class ChangeHotel : Form
    {
        List<int> AgeIds = new List<int>();
        List<int> CountryIds = new List<int>();
        List<int> FoodsIds = new List<int>();
        List<int> PoolIds = new List<int>();
        List<int> RegionIds = new List<int>();
        List<string> AgeRes = new List<string>();
        List<string> CountryRes = new List<string>();
        List<string> FoodsRes = new List<string>();
        List<string> PoolRes = new List<string>();
        List<string> RegionRes = new List<string>();
        int id;

        public ChangeHotel(int id)
        {
            this.id = id;
            InitializeComponent();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"select * from country_types", Form1.connection);
            System.Data.DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                CountryRes.Add((string)row[1]);
                CountryIds.Add((int)row[0]);
            }
            dataAdapter = new MySqlDataAdapter($"select * from foods_types", Form1.connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                FoodsRes.Add((string)row[1]);
                FoodsIds.Add((int)row[0]);
            }
            dataAdapter = new MySqlDataAdapter($"select * from ageCategory_types", Form1.connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                AgeRes.Add($"{(string)row[1]} {(string)row[2]}");
                AgeIds.Add((int)row[0]);
            }
            dataAdapter = new MySqlDataAdapter($"select * from pools_categories", Form1.connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                PoolRes.Add((string)row[1]);
                PoolIds.Add((int)row[0]);
            }
            comboBoxAge.DataSource = AgeRes;
            comboBoxCountry.DataSource = CountryRes;
            comboBoxFoods.DataSource = FoodsRes;
            comboBoxPool.DataSource = PoolRes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAge.SelectedIndex == -1 || comboBoxCountry.SelectedIndex == -1 ||
    comboBoxFoods.SelectedIndex == -1 || comboBoxPool.SelectedIndex == -1 || comboBoxRegion.SelectedIndex == -1)
            {
                MessageBox.Show("Одно из полей добавляемого отеля не заполнено! Для Изменения отеля нужно заполнить все поля!");
            }
            else
            {
                string beachRes = "false";
                string centerRes = "false";
                string foodsRes = $"\'{FoodsIds[comboBoxFoods.SelectedIndex]}\'";
                string regionRes = $"\'{RegionIds[comboBoxRegion.SelectedIndex]}\'";
                string poolRes = $"\'{PoolIds[comboBoxPool.SelectedIndex]}\'";
                string ageRes = $"\'{AgeIds[comboBoxAge.SelectedIndex]}\'";
                if (checkBoxSea.Checked)
                {
                    beachRes = "true";
                }
                if (checkBoxCenter.Checked)
                {
                    centerRes = "true";
                }
                MySqlCommand com = new MySqlCommand($"Update hotels set region_id={RegionIds[comboBoxRegion.SelectedIndex]}, foodstype_id={FoodsIds[comboBoxFoods.SelectedIndex]}," +
                    $"agecategory_id={AgeIds[comboBoxAge.SelectedIndex]}, pools_category={PoolIds[comboBoxPool.SelectedIndex]},stars_count={numericUpDown1.Value}," +
                    $" near_beach={beachRes},in_center={centerRes},name=\'{textBoxName.Text}\' where id={id}", Form1.connection);
                com.ExecuteNonQuery();
                Close();
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedIndex == -1)
            {
                comboBoxRegion.Enabled = false;
            }
            else
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"select * from region_types where country_id={CountryIds[comboBoxCountry.SelectedIndex]}", Form1.connection);
                System.Data.DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                RegionRes = new List<string>();
                RegionIds = new List<int>();

                foreach (DataRow row in dataTable.Rows)
                {
                    RegionRes.Add((string)row[1]);
                    RegionIds.Add((int)row[0]);
                }

                if (RegionRes.Count() == 0)
                {
                    comboBoxRegion.Enabled = false;
                }
                else
                {
                    comboBoxRegion.DataSource = RegionRes;
                    comboBoxRegion.Enabled = true;
                }
            }
        }

        private void ChangeHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
