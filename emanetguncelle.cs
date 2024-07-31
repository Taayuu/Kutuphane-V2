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
    public partial class emanetguncelle : Form
    {
        public emanetguncelle()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void emanetguncelle_Load(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull != true)
            {
                maskedTextBox1.Text = "0" + maskedTextBox1.Text;
            }
            if (maskedTextBox2.MaskFull != true)
            {
                maskedTextBox2.Text = "0" + maskedTextBox2.Text;
            }
        }
    }
}
