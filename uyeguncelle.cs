﻿using System;
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
    public partial class uyeguncelle : Form
    {
        public uyeguncelle()
        {
            InitializeComponent();
        }

        private void uyeguncelle_Load(object sender, EventArgs e)
        {
            this.ActiveControl=textBox1;
            lookUpEdit3.SelectedIndex = 0;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty)
            {
                maskedTextBox1.Select(0, 0); 
            }
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
                textBox7.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                maskedTextBox1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();

            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();

            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEdit3.ShowPopup();
                lookUpEdit3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                lookUpEdit3.ShowPopup();
                lookUpEdit3.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                maskedTextBox1.Focus();

            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox5.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox7.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox6.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = button1;
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox4.Focus();
            }
        }

        private void lookUpEdit3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }
    }
}
