﻿using System;
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
    public partial class AgeCategoryFormAdd : Form
    {
        AgeCategoryForm ageCategoryForm;
        public AgeCategoryFormAdd(AgeCategoryForm ageCategoryForm)
        {
            this.ageCategoryForm = ageCategoryForm;
            InitializeComponent();
        }

        private void AgeCategoryFormAdd_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool goodFormat = textBox2.Text.Length == 18;
            foreach(char ch in textBox2.Text) 
            {
                if (ch != '0' && ch != '1') 
                {
                    goodFormat = false;
                }
            }
            if (!goodFormat)
            {
                MessageBox.Show("Заданная строка допустимых возрастов детей не соответствует формату!");
            }
            else
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand($"insert into ageCategory_types (name,allowedChildAges) values (\'{textBox1.Text}\',\'{textBox2.Text}\')", Form1.connection);
                cmd.ExecuteNonQuery();
                ageCategoryForm.showAll();
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var charsToRemove = new string[] { "\'", "%", "_", "\\" };
            foreach (var c in charsToRemove)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(c, string.Empty);
            }
        }
    }
}
