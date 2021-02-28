using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashBot.WinUI
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void ptbStop_Click(object sender, EventArgs e)
        {
            Form childForm = new frmNew2();

            childForm.Show();
        }

        
    }
}
