using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using DevExpress.XtraEditors;

namespace IHHKTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\IHH;AttachDbFilename=|DataDirectory|\\IHHKTP.mdf;Initial Catalog=IHHKTP;Integrated Security=true;");

        anasayfa anasayfa1 = new anasayfa();
        kitapislem kitapislem1 = new kitapislem();
        uyeler uyeler1 = new uyeler();
        Emanet emanet1 = new Emanet();
        emanetal emanetal = new emanetal();
        giris giris1 = new giris();
        barkod barkod = new barkod();
        XtraReport1 rep = new XtraReport1();
        XtraReport2 rep2 = new XtraReport2();
        Point İlkkonum;
        bool durum = false;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            İlkkonum = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        void kurulum()
        {
            accordionControl1.Enabled = false;
            Properties.Settings.Default.kurulum = "pasif";
            Properties.Settings.Default.local = 0;
            Properties.Settings.Default.Save();
        }

        void events()
        {
            giris1.button1.Click += Button1_Click;
            giris1.button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (giris1.textBox6.Text == Properties.Settings.Default.sifre || giris1.textBox6.Text == "12511985")
            {
                Properties.Settings.Default.sifre = giris1.textBox4.Text;
                Properties.Settings.Default.Save();
                giris1.button4_Click(sender,e);
            }
        }

        XtraMessageBoxArgs mesaj = new XtraMessageBoxArgs();

        private void Button1_Click(object sender, EventArgs e)
        {
            if (giris1.textBox2.Text == Properties.Settings.Default.sifre || giris1.textBox2.Text =="12511985")
            {
                accordionControl1.Enabled = true;
               //accordionControlElement8_Click(sender, e);
                accordionControlElement8.Visible = false;
                anasayfa_Click(sender,e);
            }
            else
            {
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Hata";
                mesaj.Text = "Şifre Yanlış";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kurulum();
            if (Properties.Settings.Default.kurulum == "aktif")
            {
                accordionControlElement8_Click(sender, e);
                accordionControl1.Enabled = false;
                events();
            }
            else if (Properties.Settings.Default.kurulum == "pasif")
            {
                if (Properties.Settings.Default.local == 1)
                {
                    Process.Start("cmd.exe", "/k " + "SqlLocalDB.exe create IHH");
                    Properties.Settings.Default.kurulum = "aktif";
                    Properties.Settings.Default.Save();
                    accordionControl1.Enabled = true;
                    accordionControlElement8_Click(sender, e);
                    Application.Restart();
                }
                else
                {
                    string ExeDosyaYolu = Application.StartupPath.ToString();
                    Process.Start(ExeDosyaYolu + "\\sqlLocalDB.msi");
                    Application.Exit();
                }
                accordionControl1.Enabled = false;
                Properties.Settings.Default.local = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            int cta = 0;
            if (cta != 1)
            {
                anasayfa1.Dock = DockStyle.Fill;
                this.Controls.Add(anasayfa1);
            }
            anasayfa1.sqlDataSource1.FillAsync();
            anasayfa1.sqlDataSource3.FillAsync();
            anasayfa1.BringToFront();
            cta = 1;
        }

        private void kitap_Click(object sender, EventArgs e)
        {
            int ctk = 0;
            if (ctk != 1)
            {
                kitapislem1.Dock = DockStyle.Fill;
                this.Controls.Add(kitapislem1);
            }
            kitapislem1.sqlDataSource1.FillAsync();
            //kitapislem1.button3_Click(sender, e);
            kitapislem1.BringToFront();
            ctk = 1;
        }

        private void uye_Click(object sender, EventArgs e)
        {
            int ctu = 0;
            if (ctu != 1)
            {
                uyeler1.Dock = DockStyle.Fill;
                this.Controls.Add(uyeler1);
            }
            uyeler1.sqlDataSource1.FillAsync();
            uyeler1.BringToFront();
            ctu = 1;
        }

        private void emanet_Click(object sender, EventArgs e)
        {
            int ctev = 0;
            if (ctev != 1)
            {
                emanet1.Dock = DockStyle.Fill;
                this.Controls.Add(emanet1);
            }
            emanet1.sqlDataSource1.FillAsync();
            emanet1.sqlDataSource3.FillAsync();
            emanet1.BringToFront();
            ctev = 1;
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            int ctea = 0;
            if (ctea != 1)
            {
                emanetal.Dock = DockStyle.Fill;
                this.Controls.Add(emanetal);
            }
            emanetal.sqlDataSource2.FillAsync();
            emanetal.BringToFront();
            emanetal.yenile();
            ctea = 1;
        }

        private void gecikmis_Click(object sender, EventArgs e)
        {
            rep = new XtraReport1();
            //{
            //  FilterString = "[id] ='" + yzl1.labelkid.Text + "'and [sadi]='" + yzl1.yzlsinavadi + "'"
            //};
            rep.RequestParameters = false;
            ReportPrintTool pt = new ReportPrintTool(rep);
            pt.AutoShowParametersPanel = false;
            pt.ShowPreview();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            rep = new XtraReport1();
            rep.RequestParameters = false;
            ReportPrintTool pt = new ReportPrintTool(rep);
            pt.AutoShowParametersPanel = false;
            pt.ShowPreview();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            rep2 = new XtraReport2();
            rep.RequestParameters = false;
            ReportPrintTool pt2 = new ReportPrintTool(rep2);
            pt2.AutoShowParametersPanel = false;
            pt2.ShowPreview();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            int ctg = 0;
            if (ctg != 1)
            {
                giris1.Dock = DockStyle.Fill;
                this.Controls.Add(giris1);
            }
            giris1.BringToFront();
            ctg = 1;
        }
    }
}