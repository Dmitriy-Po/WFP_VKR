using SENM.Forms.ПланНормативныйEditForm;
using TestCodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SENM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ПланНормативныйEditForm планНормативныйEditForm = new ПланНормативныйEditForm();
            планНормативныйEditForm.ShowDialog();
        }

        private void SeData()
        {
            using (CodeFirstContext cx = new CodeFirstContext())
            {
                DbSet res = cx.СправочникSet;                               
                res.Load();
                dataGridView1.DataSource = res.Local;
            }
        }

        private void buttonShowАгрегат_Click(object sender, EventArgs e)
        {
            АгрегатEditForm agr = new АгрегатEditForm();
            agr.ShowDialog();
        }

        private void buttonCalculatePlan_Click(object sender, EventArgs e)
        {
            РасчётЭнергозатратForm calc = new РасчётЭнергозатратForm();
            calc.ShowDialog();
        }
    }
}
