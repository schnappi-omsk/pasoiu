using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASOIU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ввестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pollForm = new PollForm();
            pollForm.Show();
            pollForm = null;
        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
