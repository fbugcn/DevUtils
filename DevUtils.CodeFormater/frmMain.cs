using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevUtils.CodeFormater
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStructAnnotations_Click(object sender, EventArgs e)
        {
            frmStructAnnotations frm = new frmStructAnnotations();
            frm.ShowDialog();
        }
    }
}
