using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class ViborBileta : Form
    {
        public ViborBileta()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Moscow moscow = new Moscow();
            moscow.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Piter piter = new Piter();
            piter.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Kazan kazan = new Kazan();
            kazan.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Novosibirsk novosibirsk = new Novosibirsk();
            novosibirsk.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Krasnoyarsk krasnoyarsk = new Krasnoyarsk();
            krasnoyarsk.Show();
        }
    }
}
