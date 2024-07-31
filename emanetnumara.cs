using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHHKTP
{
    public partial class emanetnumara : Form
    {
        public emanetnumara()
        {
            InitializeComponent();
        }

        private void emanetnumara_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
        }
    }
}
