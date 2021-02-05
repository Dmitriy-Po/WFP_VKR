using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENM
{
    public partial class EditFormControl : UserControl
    {
        public EditFormControl()
        {
            InitializeComponent();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }
    }
}
