using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Web.UI.WebControls;

namespace IHHKTP
{
    public partial class emanetal : UserControl
    {
        public emanetal()
        {
            InitializeComponent();
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                gridControl2.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
                yenile();
                //yenile2();
                gridControl2.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
                gridControl2.DataSource = sqlDataSource3;
                sqlDataSource3.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
                gridControl2.DataSource = sqlDataSource4;
                sqlDataSource4.FillAsync();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\IHH;AttachDbFilename=|DataDirectory|\\IHHKTP.mdf;Initial Catalog=IHHKTP;Integrated Security=true;");
        XtraMessageBoxArgs mesaj = new XtraMessageBoxArgs();

        public void yenile()
        {
            if (gridView1.RowCount != 0)
            {
                if (int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) != 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd2 = new SqlCommand("UPDATE emanet SET durum=2 where Convert(date, teslim_tarihi , 103) <= GETDATE() and id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    } 
                }
                //if (Convert.ToDateTime(gridView1.GetFocusedRowCellValue("teslim_tarihi").ToString()) < DateTime.Today)
                //{
                //    if (con.State == ConnectionState.Closed)
                //    {
                //        con.Open();
                //    }
                //    SqlCommand cmd2 = new SqlCommand("UPDATE emanet SET durum=2 where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                //    cmd2.Connection = con;
                //    cmd2.ExecuteNonQuery();
                //    //if (Convert.ToDateTime(gridView1.GetFocusedRowCellValue("teslim_tarihi").ToString()) > DateTime.Today && int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) == 2)
                //    //{
                //    //    SqlCommand cmd3 = new SqlCommand("UPDATE emanet SET durum=1 where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                //    //    cmd3.Connection = con;
                //    //    cmd3.ExecuteNonQuery(); 
                //    //}
                //    if (con.State == ConnectionState.Open)
                //    {
                //        con.Close();
                //    }
                //}
            }
            count();
            sqlDataSource1.FillAsync();
            sqlDataSource2.FillAsync();
            sqlDataSource3.FillAsync();
            sqlDataSource4.FillAsync();
            timer1.Stop();
        }
        
        public void yenile2()
        {
            if (gridView1.RowCount != 0)
            {
                if (int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) !=0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd2 = new SqlCommand("UPDATE emanet SET durum=1 where Convert(date, teslim_tarihi , 103) >= GETDATE() and id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            count();
            sqlDataSource1.FillAsync();
            sqlDataSource2.FillAsync();
            sqlDataSource3.FillAsync();
            sqlDataSource4.FillAsync();
            timer1.Stop();
        }

        void count()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select COUNT(durum) as durumsayi1 from emanet where durum=2", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelControl3.Text = dr["durumsayi1"].ToString();
            }
            dr.Close();
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("select COUNT(durum) as durumsayi2 from emanet WHERE durum=1", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                labelControl5.Text = dr2["durumsayi2"].ToString();
            }
            dr2.Close();
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("select COUNT(durum) as durumsayi3 from emanet WHERE durum=1 or durum=2", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                labelControl1.Text = dr3["durumsayi3"].ToString();
            }
            dr3.Close();
            cmd3.ExecuteNonQuery();
            SqlCommand cmd4 = new SqlCommand("select COUNT(durum) as durumsayi4 from emanet WHERE durum=0", con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                labelControl8.Text = dr4["durumsayi4"].ToString();
            }
            dr4.Close();
            cmd4.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void isim()
        {
            gridView1.Columns["kitap_adi"].Caption = "Kitap Adı";
            gridView1.Columns["yazar_adi"].Caption = "Yazar Adı";
            gridView1.Columns["kitap_turu"].Caption = "Kitap Türü";
            gridView1.Columns["yayin_evi"].Caption = "Yayın Evi";
            gridView1.Columns["sayfa"].Caption = "Sayfa";
            gridView1.Columns["barkod"].Caption = "Barkod";
            gridView1.Columns["tc"].Caption = "TC No";
            gridView1.Columns["isim"].Caption = "İsim";
            gridView1.Columns["soyisim"].Caption = "Soyisim";
            gridView1.Columns["telefon"].Caption = "Telefon";
            gridView1.Columns["cinsiyet"].Caption = "Cinsiyet";
            gridView1.Columns["alinma_tarihi"].Caption = "Alınma Tarihi";
            gridView1.Columns["teslim_tarihi"].Caption = "Teslim Tarihi";
            gridView1.Columns["durum"].Caption = "Durum";
        }

        void events()
        {
            emgncl.button1.Click += embuton1_Click;
        }

        private void embuton1_Click(object sender, EventArgs e)
        {
            if (emgncl.maskedTextBox1.MaskCompleted && emgncl.maskedTextBox2.MaskCompleted)
            {
                emguncelle();
                emgncl.Close();
                yenile();
                yenile2();
            }
            else
            {
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Uyarı";
                mesaj.Text = "Lütfen Gerekli Boşlukları Doldurunuz";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
            }
        }

        void emguncelle()
        {
            SqlCommand cmd = new SqlCommand("update emanet set durum=@durum, alinma_tarihi=@alinma_tarihi, teslim_tarihi=@teslim_tarihi where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'", con);
            cmd.Parameters.AddWithValue("@alinma_tarihi", DateTime.Parse(emgncl.maskedTextBox1.Text));
            cmd.Parameters.AddWithValue("@teslim_tarihi", DateTime.Parse(emgncl.maskedTextBox2.Text));
            if (emgncl.toggleSwitch1.IsOn)
            {
                cmd.Parameters.AddWithValue("@durum", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@durum", 0);
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            sqlDataSource2.FillAsync();
            sqlDataSource3.FillAsync();
        }

        private void emanetal_Load(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            comboBoxEdit1.SelectedIndex = 1;
            isim();
            events();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yenile();
            yenile2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                if (int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) == 1 || int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) == 2)
                {
                    if (MessageBox.Show("Kitabı teslim almak istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand("update emanet set durum=0 where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'", con);
                        //cmd.Parameters.AddWithValue("@durum", 0);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd2 = new SqlCommand("UPDATE kitap SET stok=stok +1 where id='" + gridView1.GetFocusedRowCellValue("idk").ToString() + "'", con);
                        cmd2.ExecuteNonQuery();
                        SqlCommand cmd3 = new SqlCommand("UPDATE uye SET okunan=okunan +1  WHERE id='" + gridView1.GetFocusedRowCellValue("idu").ToString() + "'", con);
                        cmd3.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        mesaj.AutoCloseOptions.Delay = 1000;
                        mesaj.Caption = "Tamamlandı";
                        mesaj.Text = "Kitap Teslim Alındı.";
                        mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                        mesaj.DefaultButtonIndex = 1;
                        mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        XtraMessageBox.Show(mesaj).ToString();
                        sqlDataSource1.FillAsync();
                        sqlDataSource2.FillAsync();
                        sqlDataSource3.FillAsync();
                        sqlDataSource4.FillAsync();
                        count();
                        //yenile();
                        //yenile2();
                        //timer1.Start();
                    }
                }
                else
                {
                    MessageBox.Show("BU İŞLEM GERÇEKLEŞTİRİLEMİYOR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ALINACAK EMANET YOK.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["durum"]).ToString() == "2")
            {
                e.Appearance.BackColor = Color.IndianRed;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "durum")
            {
                if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["durum"]).ToString() == "2")
                {
                    e.DisplayText = "Gecikti";
                }
                else if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["durum"]).ToString() == "1")
                {
                    e.DisplayText = "Normal";
                }
                else if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["durum"]).ToString() == "0")
                {
                    e.DisplayText = "Pasif";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != string.Empty)
            {
                if (gridView1.RowCount != 0)
                {
                    if (int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) == 1 || int.Parse(gridView1.GetFocusedRowCellValue("durum").ToString()) == 2)
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        DateTime ek = DateTime.Parse(gridView1.GetFocusedRowCellValue("teslim_tarihi").ToString());
                        SqlCommand cmd2 = new SqlCommand("UPDATE emanet SET teslim_tarihi=@teslim_tarihi where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                        cmd2.Parameters.AddWithValue("teslim_tarihi", ek.AddDays(int.Parse(maskedTextBox1.Text)));
                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        mesaj.AutoCloseOptions.Delay = 1000;
                        mesaj.Caption = "Tamamlandı";
                        mesaj.Text = "Süre " + maskedTextBox1.Text + " Gün Uzatıldı.";
                        mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                        mesaj.DefaultButtonIndex = 1;
                        mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        maskedTextBox1.Clear();
                        XtraMessageBox.Show(mesaj).ToString();
                        yenile();
                        yenile2();
                    }
                    else
                    {
                        MessageBox.Show("BU İŞLEM GERÇEKLEŞTİRİLEMİYOR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("UZATILACAK EMANET YOK.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "10";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "15";
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                gridControl2.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
                gridControl2.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
                gridControl2.DataSource = sqlDataSource3;
                sqlDataSource3.FillAsync();
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
                gridControl2.DataSource = sqlDataSource4;
                sqlDataSource4.FillAsync();
            }
            count();
        }

        emanetguncelle emgncl = new emanetguncelle();

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                emgncl.maskedTextBox1.Text = gridView1.GetFocusedRowCellValue("alinma_tarihi").ToString();
                emgncl.maskedTextBox2.Text = gridView1.GetFocusedRowCellValue("teslim_tarihi").ToString();
                if (gridView1.GetFocusedRowCellValue("durum").ToString() == 0.ToString())
                {
                    emgncl.toggleSwitch1.IsOn = false;
                }
                else
                {
                    emgncl.toggleSwitch1.IsOn = true;
                }
                emgncl.StartPosition = FormStartPosition.CenterScreen;
                emgncl.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    }
}
