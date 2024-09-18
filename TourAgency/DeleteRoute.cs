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
    public partial class DeleteRoute : Form
    {
        FindRouteViewer form;
        public DeleteRoute(FindRouteViewer form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void DeleteRoute_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form.result = false;
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            form.result = true;
            Close();
        }
    }
}
