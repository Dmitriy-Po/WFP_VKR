using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCodeFirst;

namespace SENM.Forms.ПланНормативныйEditForm
{
    public partial class ПланНормативныйEditForm : Form
    {
        public ПланНормативныйEditForm()
        {
            InitializeComponent();
            //SetData();
        }

        private void SetData()
        {
            using (CodeFirstContext cx = new CodeFirstContext())
            {
                DbSet res = cx.ФактическоеПотреблениеSet;
                res.Load();
                dataGridView1.DataSource = res.Local;

                DbSet dbSet = cx.УстройствоSet;
                dbSet.Load();
                comboBoxАгрегат.DataSource = dbSet.Local;
            }
        }        

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxАгрегат_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonДобавитьСостояниеВПлан_Click(object sender, EventArgs e)
        {
            АгрегатEditForm ag1 = new АгрегатEditForm();
            ag1.ShowDialog();
        }
    }
}
