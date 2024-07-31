using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHHKTP
{
    public partial class uyeler : UserControl
    {
        public uyeler()
        {
            InitializeComponent();
            if (comboBoxEdit1.Text == "Aktif Üyeler")
            {
                gridControl3.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl3.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
        }

        void isim()
        {
            gridView2.Columns["tc"].Caption = "TC No";
            gridView2.Columns["isim"].Caption = "İsim";
            gridView2.Columns["soyisim"].Caption = "Soyisim";
            gridView2.Columns["telefon"].Caption = "Telefon";
            gridView2.Columns["bolum"].Caption = "Bölüm";
            gridView2.Columns["eposta"].Caption = "E-Posta";
            gridView2.Columns["cinsiyet"].Caption = "Cinsiyet";
            gridView2.Columns["okunan"].Caption = "Okunan";
            gridView2.Columns["barkoduye"].Caption = "Barkod";
        }

        private void uyeler_Load(object sender, EventArgs e)
        {
            gridView2.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            textBox1.Focus();
            Eventss();
            isim();
            counts();
        }

        private void Eventss()
        {
            uyeguncelle1.button1.Click += uyeguncellebutton1;
            uyeguncelle1.button2.Click += uyeguncellebutton2;
        }

        private void uyeguncellebutton2(object sender, EventArgs e)
        {
            XtraReport2 rep2 = new XtraReport2
            {
                FilterString = "[id] ='" + gridView2.GetFocusedRowCellValue("id").ToString() + "' and [isim] ='" + gridView2.GetFocusedRowCellValue("isim").ToString() + "'"
            };

            rep2.RequestParameters = false;
            ReportPrintTool pt2 = new ReportPrintTool(rep2);
            pt2.AutoShowParametersPanel = false;
            pt2.ShowPreview();
        }

        private void uyeguncellebutton1(object sender, EventArgs e)
        {
            if (uyeguncelle1.textBox1.Text != "" && uyeguncelle1.textBox2.Text != "" && uyeguncelle1.textBox3.Text != "" && uyeguncelle1.maskedTextBox1.Text != string.Empty)
            {
                uyguncelle();
                uyeguncelle1.Close();
                if (comboBoxEdit1.Text == "Aktif Üyeler")
                {
                    sqlDataSource1.FillAsync();
                }
                else
                {
                    sqlDataSource2.FillAsync();
                }
            }
            else
            {
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Lütfen Gerekli Boşlukları Doldurunuz";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\IHH;AttachDbFilename=|DataDirectory|\\IHHKTP.mdf;Initial Catalog=IHHKTP;Integrated Security=true;");
        XtraMessageBoxArgs mesaj = new XtraMessageBoxArgs();
        uyeguncelle uyeguncelle1 = new uyeguncelle();

        public void txtsil()
        {
            foreach (var item in groupControl1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    maskedTextBox1.Clear();
                    lookUpEdit3.Text = "Cinsiyet Seçiniz...";
                }
            }
        }

        Int64 barsayi = 1;
        Int64 barkod;

        void barkodyap()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd3 = new SqlCommand("select barkoduye from uye order by barkoduye desc", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                barkod = Convert.ToInt64(dr3["barkoduye"].ToString()) + 1;
                dr3.Close();
            }
            else
            {
                PrintDocument doc = new PrintDocument();
                Ean13Barcode2005.Ean13 barcode = new Ean13Barcode2005.Ean13();
                barcode.CountryCode = "90";
                barcode.ManufacturerCode = "58421";
                barcode.ProductCode = barsayi.ToString("00000");
                barkod = Convert.ToInt64((barcode.CountryCode).ToString() + (barcode.ManufacturerCode).ToString() + (barcode.ProductCode).ToString());
            }
            dr3.Close();
        }

        void counts()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (comboBoxEdit1.Text == "Aktif Üyeler")
            {
                SqlCommand cmd = new SqlCommand("select count(*) as count from uye where durum = 1", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelControl13.Text = dr["count"].ToString();
                }
                dr.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select count(*) as count from uye where durum = 0", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelControl13.Text = dr["count"].ToString();
                }
                dr.Close();
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }

        void ekle()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd2 = new SqlCommand("select * from uye where tc='" + textBox1.Text + "'", con);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                mesaj.AutoCloseOptions.Delay = 2000;
                mesaj.Caption = "Uyarı";
                mesaj.Text = "Bu Üye Zaten Mevcut.";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
                txtsil();
            }
            else
            {
                dr.Close();
                barkodyap();
                SqlCommand cmd = new SqlCommand("Insert Into uye(isim,soyisim,telefon,tc,eposta,bolum,cinsiyet,durum,okunan,ceza,barkoduye) Values (@isim,@soyisim,@telefon,@tc,@eposta,@bolum,@cinsiyet,@durum,@okunan,@ceza,@barkoduye)", con);
                cmd.Parameters.AddWithValue("@isim", textBox2.Text);
                cmd.Parameters.AddWithValue("@soyisim", textBox3.Text);
                cmd.Parameters.AddWithValue("@bolum", textBox6.Text);
                cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(textBox1.Text));
                cmd.Parameters.AddWithValue("@eposta", textBox5.Text);
                cmd.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", lookUpEdit3.Text);
                cmd.Parameters.AddWithValue("@barkoduye", Convert.ToInt64(barkod));
                cmd.Parameters.AddWithValue("@durum", 1);
                cmd.Parameters.AddWithValue("@okunan", 0);
                cmd.Parameters.AddWithValue("@ceza", 0);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr.Close();
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (comboBoxEdit1.Text == "Aktif Üyeler")
                {
                    gridControl3.DataSource = sqlDataSource1;
                    sqlDataSource1.FillAsync();
                }
                else
                {
                    gridControl3.DataSource = sqlDataSource2;
                    sqlDataSource2.FillAsync();
                }
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Üye Eklendi";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
                txtsil();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit3.Text != "Cinsiyet Seçiniz...")
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.Text != "")
                {
                    ekle();
                    counts();
                }
                else
                {
                    mesaj.AutoCloseOptions.Delay = 1000;
                    mesaj.Caption = "Tamamlandı";
                    mesaj.Text = "Lütfen Gerekli Boşlukları Doldurunuz";
                    mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                    mesaj.DefaultButtonIndex = 1;
                    mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                    XtraMessageBox.Show(mesaj).ToString();
                }
            }
            else
            {
                lookUpEdit3.ShowPopup();
            }
        }

        private string TcDogrula(string tcNo)
        {
            string durum = "";
            try
            {
                if (tcNo != "")
                {
                    if (tcNo.Length == 11)
                    {
                        char[] rakamlar = tcNo.ToCharArray();
                        int kural1 = 0, hane11 = rakamlar[10], hane10 = rakamlar[9];
                        //kural1: ilk 10 rakamın toplamının birler basamağı, 11. rakamı vermektedir.
                        for (int i = 0; i < 10; i++)
                        {
                            kural1 += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural1 = kural1.ToString().ToCharArray();

                        int kural2tek = 0, kural2cift = 0;
                        //kural2:  1, 3, 5, 7 ve 9. rakamın toplamının 7 katı ile 2, 4, 6 ve 8. rakamın toplamının 9 katının toplamının birler basamağı 10. rakamı vermektedir.
                        for (int i = 0; i < 10; i += 2)
                        {
                            kural2tek += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        for (int i = 1; i < 9; i += 2)
                        {
                            kural2cift += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural2 = ((7 * kural2tek) + (9 * kural2cift)).ToString().ToCharArray();

                        int kural3 = 0;
                        //1, 3, 5, 7 ve 9. rakamın toplamının 8 katının birler basamağı 11. rakamı vermektedir.
                        for (int i = 0; i < 10; i += 2)
                        {
                            kural3 += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural3 = (8 * kural3).ToString().ToCharArray();

                        if ((birlerbasamagikural1[birlerbasamagikural1.Length - 1] == hane11) && (birlerbasamagikural2[birlerbasamagikural2.Length - 1] == hane10) && (birlerbasamagikural3[birlerbasamagikural3.Length - 1] == hane11))
                        {
                            durum = "Kimlik Numarası Geçerli";
                        }
                        else
                        {
                            durum = "Kimlik Numarası Geçerli Değildir";
                        }
                        textBox1.Focus();
                    }
                    else
                    {
                        durum = "TC Kimlik Numaranızı Eksik Girdiniz Lütfen Kontrol Ediniz!!!";
                        textBox1.Focus();
                    }
                }
                else
                {
                    durum = "Lütfen TC Kimlik Numaranızı Giriniz!!!";
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                durum = ex.Message;
            }
            return durum;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void uyguncelle()
        {
            SqlCommand cmd = new SqlCommand("update uye set isim=@isim, soyisim=@soyisim, bolum=@bolum, tc=@tc, eposta=@eposta, telefon=@telefon, cinsiyet=@cinsiyet, okunan=@okunan, barkoduye=@barkoduye, durum=@durum where id='" + gridView2.GetFocusedRowCellValue("id").ToString() + "'", con);
            cmd.Parameters.AddWithValue("@isim", uyeguncelle1.textBox2.Text);
            cmd.Parameters.AddWithValue("@soyisim", uyeguncelle1.textBox3.Text);
            cmd.Parameters.AddWithValue("@bolum", uyeguncelle1.textBox6.Text);
            cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(uyeguncelle1.textBox1.Text));
            cmd.Parameters.AddWithValue("@eposta", uyeguncelle1.textBox5.Text);
            cmd.Parameters.AddWithValue("@telefon", uyeguncelle1.maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", uyeguncelle1.lookUpEdit3.Text);
            cmd.Parameters.AddWithValue("@okunan", Convert.ToInt32(uyeguncelle1.textBox4.Text));
            cmd.Parameters.AddWithValue("@barkoduye", Convert.ToInt64(uyeguncelle1.textBox7.Text));
            if (uyeguncelle1.toggleSwitch1.IsOn)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount != 0)
            {
                SqlCommand cmd = new SqlCommand("update uye set durum=@durum where id='" + gridView2.GetFocusedRowCellValue("id").ToString() + "'", con);
                cmd.Parameters.AddWithValue("@durum", 0);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (comboBoxEdit1.Text == "Aktif Üyeler")
                {
                    gridControl3.DataSource = sqlDataSource1;
                    sqlDataSource1.FillAsync();
                }
                else
                {
                    gridControl3.DataSource = sqlDataSource2;
                    sqlDataSource2.FillAsync();
                }
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Üye Silindi";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
                counts();
            }
            else
            {
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Silinecek Üye Seçilmedi.";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
            }
            if (comboBoxEdit1.Text == "Aktif Üyeler")
            {
                gridControl3.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl3.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
        }

        string sil;

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //sil = gridView2.GetFocusedRowCellValue("id").ToString();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                uyeguncelle1.textBox1.Text = gridView2.GetFocusedRowCellValue("tc").ToString();
                uyeguncelle1.textBox2.Text = gridView2.GetFocusedRowCellValue("isim").ToString();
                uyeguncelle1.textBox3.Text = gridView2.GetFocusedRowCellValue("soyisim").ToString();
                uyeguncelle1.textBox5.Text = gridView2.GetFocusedRowCellValue("eposta").ToString();
                uyeguncelle1.textBox6.Text = gridView2.GetFocusedRowCellValue("bolum").ToString();
                uyeguncelle1.maskedTextBox1.Text = gridView2.GetFocusedRowCellValue("telefon").ToString();
                uyeguncelle1.lookUpEdit3.Text = gridView2.GetFocusedRowCellValue("cinsiyet").ToString();
                uyeguncelle1.textBox4.Text = gridView2.GetFocusedRowCellValue("okunan").ToString();
                uyeguncelle1.textBox7.Text = gridView2.GetFocusedRowCellValue("barkoduye").ToString();
                if (gridView2.GetFocusedRowCellValue("durum").ToString() == 0.ToString())
                {
                    uyeguncelle1.toggleSwitch1.IsOn = false;
                }
                else
                {
                    uyeguncelle1.toggleSwitch1.IsOn = true;
                }
                uyeguncelle1.StartPosition = FormStartPosition.CenterScreen;
                uyeguncelle1.ShowDialog();
            }
            catch (Exception)
            {
                
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty)
            {
                maskedTextBox1.Select(0, 0);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text == "Aktif Üyeler")
            {
                gridControl3.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl3.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
            counts();
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
                textBox6.Focus();

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
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox5.Focus();
            }
        }

        private void lookUpEdit3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TcDogrula(textBox1.Text), "Bilgi");
        }

        private void uyeDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView2_DoubleClick(sender, e);
        }

        private void emanetBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilgigecmisi bilgigecmisi = new bilgigecmisi();
            bilgigecmisi.gridView1.FindFilterText = gridView2.GetFocusedRowCellValue("tc").ToString();
            bilgigecmisi.ShowDialog();
        }

        private void barkodYazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyeguncellebutton2(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in groupControl1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    maskedTextBox1.Clear();
                    lookUpEdit3.Text = "Cinsiyet Seçiniz...";
                }
            }
        }
    }
}
