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
    public partial class CascadeWarning : Form
    {
        MainEntitiesForm form;
        public CascadeWarning(MainEntitiesForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             form.result= true;
             Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.result = false;
            Close();
        }

        private void CascadeWarning_Load(object sender, EventArgs e)
        {

        }
    }
}
