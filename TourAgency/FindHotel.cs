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
    public partial class FindHotel : Form
    {
        bool enableHotelId = false;
        bool enableName = false;
        bool enableCountry = false;
        bool enableRegion = false;
        bool enableFoods = false;
        bool enableAge = false;
        bool enablePool = false;
        bool enableStars = false;
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
        public FindHotel()
        {
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

        private void checkBoxHotel_CheckedChanged(object sender, EventArgs e)
        {
            enableHotelId = ((CheckBox)sender).Checked;
            HotelIDnumericUpDown2.Enabled= ((CheckBox)sender).Checked;
        }

        private void checkBoxCountry_CheckedChanged(object sender, EventArgs e)
        {
            enableCountry = ((CheckBox)sender).Checked;
            comboBoxCountry.Enabled = ((CheckBox)sender).Checked;
            if (!checkBoxCountry.Checked)
            {
                checkBoxRegion.Enabled = false;
                comboBoxRegion.Enabled = false;
            }
            else 
            {
                checkBoxRegion.Enabled = true;
            }
            if (checkBoxRegion.Checked && !checkBoxCountry.Checked) 
            {
                checkBoxRegion.Checked = false;
            }            
        }

        private void checkBoxFoods_CheckedChanged(object sender, EventArgs e)
        {
            enableFoods = ((CheckBox)sender).Checked;
            comboBoxFoods.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
        {
            enableAge = ((CheckBox)sender).Checked;
            comboBoxAge.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            enableName = ((CheckBox)sender).Checked;
            textBoxName.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBoxStars_CheckedChanged(object sender, EventArgs e)
        {
            enableStars = ((CheckBox)sender).Checked;
            numericUpDown1.Enabled = ((CheckBox)sender).Checked;
        }

        private void checkBoxRegion_CheckedChanged(object sender, EventArgs e)
        {
            enableRegion= ((CheckBox)sender).Checked;
            comboBoxRegion.Enabled= ((CheckBox)sender).Checked;
            if (checkBoxRegion.Checked == true && checkBoxCountry.Checked == true)
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
                    checkBoxRegion.Enabled = false;
                    checkBoxRegion.Checked = false;
                }
                else
                {
                    comboBoxRegion.DataSource = RegionRes;
                    comboBoxRegion.Enabled = true;
                }
            }
        }

        private void checkBoxPool_CheckedChanged(object sender, EventArgs e)
        {
            enablePool= ((CheckBox)sender).Checked;
            comboBoxPool.Enabled= ((CheckBox)sender).Checked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<bool> Enabled = new List<bool> {enableHotelId,enableRegion,enableFoods,enableCountry,enableAge,enablePool,enableStars,enableName,!radioButton3.Checked,!radioButton5.Checked };
            int regionId = -1;
            if (enableRegion) 
            {
                if (comboBoxRegion.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран регион!");
                    return;
                }
                else 
                {
                    regionId = RegionIds[comboBoxRegion.SelectedIndex];
                }
            }
            int countryId = -1;
            if (enableCountry)
            {
                if (comboBoxCountry.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбрана страна!");
                    return;
                }
                else
                {
                    countryId = CountryIds[comboBoxCountry.SelectedIndex];
                }
            }
            int ageId = -1;
            if (enableAge) 
            {
                if (comboBoxAge.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбрана возрастная категория!");
                    return;
                }
                else
                {
                    ageId = AgeIds[comboBoxAge.SelectedIndex];
                }
            }
            int poolId = -1;
            if (enablePool)
            {
                if (comboBoxPool.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран тип бассейна!");
                    return;
                }
                else
                {
                    poolId = PoolIds[comboBoxPool.SelectedIndex];
                }
            }
            int foodsId = -1;
            if (enableFoods)
            {
                if (comboBoxFoods.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран тип питания!");
                    return;
                }
                else
                {
                    poolId = FoodsIds[comboBoxFoods.SelectedIndex];
                }
            }

            FindHotelViewer form = new FindHotelViewer(Enabled, Convert.ToInt32(HotelIDnumericUpDown2.Value), regionId, foodsId, countryId, ageId, poolId, Convert.ToInt32(numericUpDown1.Value),textBoxName.Text, radioButton1.Checked, radioButton4.Checked);
            form.ShowDialog();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxRegion.Checked) 
            {
                checkBoxRegion.Checked = false;
            }
        }

        private void FindHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
