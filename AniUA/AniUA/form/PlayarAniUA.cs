using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniUA.form
{
    public partial class PlayarAniUA : Form
    {
        public PlayarAniUA()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttTurn_Enter(object sender, EventArgs e)
        {

        }
    }
}
