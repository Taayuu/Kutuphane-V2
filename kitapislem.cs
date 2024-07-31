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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHHKTP
{
    public partial class kitapislem : UserControl
    {
        public kitapislem()
        {
            InitializeComponent();
            if (comboBoxEdit1.Text == "Aktif Kitaplar")
            {
                gridControl1.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl1.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\IHH;AttachDbFilename=|DataDirectory|\\IHHKTP.mdf;Initial Catalog=IHHKTP;Integrated Security=true;");
        XtraMessageBoxArgs mesaj = new XtraMessageBoxArgs();

        void ekle()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Insert Into kitap(kitap_adi,yazar_adi,yayin_evi,sayfa,stok,barkod,kitap_turu,durum,konu,dil,yayin_tarihi,bardurum) Values (@kitap_adi,@yazar_adi,@yayin_evi,@sayfa,@stok,@barkod,@kitap_turu,@durum,@konu,@dil,@yayin_tarihi,@bardurum)", con);
            SqlCommand cmd2 = new SqlCommand("select * from kitap WHERE DURUM=1 AND kitap_adi='" + textBox2.Text + "' AND yazar_adi='" + textBox3.Text + "' AND yayin_evi='" + textBox6.Text + "'", con);
            SqlDataReader dr = cmd2.ExecuteReader();
            cmd2.Connection = con;
            if (dr.Read())
            {
                SqlCommand cmd3 = new SqlCommand("UPDATE kitap SET stok=stok+1 WHERE id='" + dr["id"].ToString() + "'");
                cmd3.Connection = con;
                dr.Close();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                cmd.Parameters.AddWithValue("@kitap_adi", textBox2.Text);
                cmd.Parameters.AddWithValue("@yazar_adi", textBox3.Text);
                cmd.Parameters.AddWithValue("@yayin_evi", textBox6.Text);
                cmd.Parameters.AddWithValue("@sayfa", Convert.ToInt32(textBox5.Text));
                cmd.Parameters.AddWithValue("@barkod", Convert.ToInt64(textBox1.Text));
                string bkod = textBox1.Text;
                if (bkod.StartsWith("9042581") == true)
                {
                    cmd.Parameters.AddWithValue("@bardurum", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@bardurum", 0);
                }
                cmd.Parameters.AddWithValue("@kitap_turu", comboBoxEdit2.Text);
                cmd.Parameters.AddWithValue("@konu", textBox8.Text);
                cmd.Parameters.AddWithValue("@dil", lookUpEdit3.Text);
                if (maskedTextBox1.Text != string.Empty)
                {
                    cmd.Parameters.AddWithValue("@yayin_tarihi", Convert.ToInt64(maskedTextBox1.Text));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@yayin_tarihi", "");
                }
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt64(textBox7.Text));
                cmd.Parameters.AddWithValue("@durum", 1);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (comboBoxEdit1.Text == "Aktif Kitaplar")
            {
                gridControl1.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl1.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
            mesaj.AutoCloseOptions.Delay = 1000;
            mesaj.Caption = "Tamamlandı";
            mesaj.Text = "Kitap Eklendi";
            mesaj.Buttons = new DialogResult[] { DialogResult.OK };
            mesaj.DefaultButtonIndex = 1;
            mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            XtraMessageBox.Show(mesaj).ToString();
            txtsil();
        }

        public void txtsil()
        {
            foreach (var item in groupControl1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    maskedTextBox1.Clear();
                    lookUpEdit3.Text = "Dil Seçiniz...";
                    comboBoxEdit2.Text = "Konu Seçiniz...";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit3.Text != "Dil Seçiniz...")
            {
                bossifir();
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox7.Text != "" && textBox6.Text != "")
                {
                    textBox1.Focus();
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
                    textBox2.Focus();
                }
            }
            else
            {
                lookUpEdit3.ShowPopup();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                SqlCommand cmd = new SqlCommand("update kitap set durum=@durum where id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'", con);
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
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Kitap Silindi";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                counts();
                XtraMessageBox.Show(mesaj).ToString();
            }
            else
            {
                mesaj.AutoCloseOptions.Delay = 1000;
                mesaj.Caption = "Tamamlandı";
                mesaj.Text = "Silinecek Kitap Seçilmedi.";
                mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                mesaj.DefaultButtonIndex = 1;
                mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(mesaj).ToString();
            }
            if (comboBoxEdit1.Text == "Aktif Kitaplar")
            {
                gridControl1.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl1.DataSource = sqlDataSource2;
                sqlDataSource2.FillAsync();
            }
        }

        string sil;
        string guncelle;

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //try
            //{
            //    sil = gridView1.GetFocusedRowCellValue("id").ToString();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("");
            //}
        }

        kitapguncelle ktpgncl = new kitapguncelle();

        void kitapguncelle()
        {
            bossifirgnc();
            guncelle = gridView1.GetFocusedRowCellValue("id").ToString();
            SqlCommand cmd = new SqlCommand("update kitap set durum=@durum, kitap_adi=@kitap_adi, yazar_adi=@yazar_adi, yayin_evi=@yayin_evi,sayfa=@sayfa,stok=@stok,barkod=@barkod,kitap_turu=@kitap_turu,dil=@dil,yayin_tarihi=@yayin_tarihi,konu=@konu where id='" + guncelle + "'", con);
            cmd.Parameters.AddWithValue("@kitap_adi", ktpgncl.textBox2.Text);
            cmd.Parameters.AddWithValue("@yazar_adi", ktpgncl.textBox3.Text);
            cmd.Parameters.AddWithValue("@yayin_evi", ktpgncl.textBox6.Text);
            cmd.Parameters.AddWithValue("@sayfa", Convert.ToInt64(ktpgncl.textBox5.Text));
            cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(ktpgncl.textBox7.Text));
            cmd.Parameters.AddWithValue("@barkod", Convert.ToInt64(ktpgncl.textBox1.Text));
            cmd.Parameters.AddWithValue("@kitap_turu", ktpgncl.textBox4.Text);
            cmd.Parameters.AddWithValue("@yayin_tarihi", ktpgncl.maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@dil", ktpgncl.lookUpEdit3.Text);
            cmd.Parameters.AddWithValue("@konu", ktpgncl.comboBoxEdit2.Text);
            if (ktpgncl.toggleSwitch1.IsOn)
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

        private void Eventss()
        {
            ktpgncl.button1.Click += kptgnclbutton1;
            ktpgncl.button2.Click += kptgnclbutton2;
        }

        private void kptgnclbutton2(object sender, EventArgs e)
        {
            XtraReport1 rep = new XtraReport1
            {
                FilterString = "[id] ='" + gridView1.GetFocusedRowCellValue("id").ToString() + "' and [kitap_adi] ='" + gridView1.GetFocusedRowCellValue("kitap_adi").ToString() + "'"
            };
            rep.RequestParameters = false;
            ReportPrintTool pt = new ReportPrintTool(rep);
            pt.AutoShowParametersPanel = false;
            pt.ShowPreview();
        }

        public void kptgnclbutton1(object sender, EventArgs e)
        {
            if (ktpgncl.textBox2.Text != "" && ktpgncl.textBox3.Text != "" && ktpgncl.textBox7.Text != "" && ktpgncl.textBox6.Text != "")
            {
                kitapguncelle();
                ktpgncl.Close();
                if (comboBoxEdit1.Text == "Aktif Kitaplar")
                {
                    gridControl1.DataSource = sqlDataSource1;
                    sqlDataSource1.FillAsync();
                }
                else
                {
                    gridControl1.DataSource = sqlDataSource2;
                    sqlDataSource2.FillAsync();
                }
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
                ktpgncl.textBox1.Focus();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ktpgncl.textBox2.Text = gridView1.GetFocusedRowCellValue("kitap_adi").ToString();
                ktpgncl.textBox3.Text = gridView1.GetFocusedRowCellValue("yazar_adi").ToString();
                ktpgncl.textBox4.Text = gridView1.GetFocusedRowCellValue("kitap_turu").ToString();
                ktpgncl.textBox6.Text = gridView1.GetFocusedRowCellValue("yayin_evi").ToString();
                ktpgncl.textBox5.Text = gridView1.GetFocusedRowCellValue("sayfa").ToString();
                ktpgncl.textBox7.Text = gridView1.GetFocusedRowCellValue("stok").ToString();
                ktpgncl.textBox1.Text = gridView1.GetFocusedRowCellValue("barkod").ToString();
                ktpgncl.lookUpEdit3.Text = gridView1.GetFocusedRowCellValue("dil").ToString();
                ktpgncl.maskedTextBox1.Text = gridView1.GetFocusedRowCellValue("yayin_tarihi").ToString();
                ktpgncl.comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("konu").ToString();
                if (gridView1.GetFocusedRowCellValue("durum").ToString() == 0.ToString())
                {
                    ktpgncl.toggleSwitch1.IsOn = false;
                }
                else
                {
                    ktpgncl.toggleSwitch1.IsOn = true;
                }
                ktpgncl.StartPosition = FormStartPosition.CenterScreen;
                ktpgncl.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        void bossifir()
        {
            if (textBox7.Text.Trim() == "")
            {
                textBox7.Text = 0.ToString();
            }
            if (textBox5.Text.Trim() == "")
            {
                textBox5.Text = 0.ToString();
            }
        }

        void bossifirgnc()
        {
            if (ktpgncl.textBox7.Text.Trim() == "")
            {
                ktpgncl.textBox7.Text = 0.ToString();
            }
            if (ktpgncl.textBox5.Text.Trim() == "")
            {
                ktpgncl.textBox5.Text = 0.ToString();
            }
            if (ktpgncl.textBox1.Text.Trim() == "")
            {
                ktpgncl.textBox1.Text = 0.ToString();
            }
        }

        void isim()
        {
            gridView1.Columns["kitap_adi"].Caption = "Kitap Adı";
            gridView1.Columns["yazar_adi"].Caption = "Yazar Adı";
            gridView1.Columns["kitap_turu"].Caption = "Kitap Türü";
            gridView1.Columns["yayin_evi"].Caption = "Yayın Evi";
            gridView1.Columns["sayfa"].Caption = "Sayfa";
            gridView1.Columns["stok"].Caption = "Stok";
            gridView1.Columns["barkod"].Caption = "Barkod";
            gridView1.Columns["konu"].Caption = "Konu";
            gridView1.Columns["dil"].Caption = "Dil";
            gridView1.Columns["yayin_tarihi"].Caption = "Yayın Tarihi";
        }

        private void kitapislem_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            gridView1.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            Eventss();
            isim();
            counts();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text == "Aktif Kitaplar")
            {
                gridControl1.DataSource = sqlDataSource1;
                sqlDataSource1.FillAsync();
            }
            else
            {
                gridControl1.DataSource = sqlDataSource2;
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
                comboBoxEdit2.ShowPopup();
                comboBoxEdit2.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                comboBoxEdit2.ShowPopup();
                comboBoxEdit2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
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
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();

            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox8.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox8.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox5.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
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
                textBox6.Focus();
            }
        }

        private void lookUpEdit3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
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
                textBox8.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
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
                maskedTextBox1.Focus();
            }
        }

        Int64 barsayi = 1;
        Int64 barkod;

        public void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd3 = new SqlCommand("select barkod,bardurum from kitap where bardurum=1 order by barkod desc", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                barkod = Convert.ToInt64(dr3["barkod"].ToString()) + 1;
                dr3.Close();
                textBox1.Text = barkod.ToString();
            }
            else
            {
                PrintDocument doc = new PrintDocument();
                Ean13Barcode2005.Ean13 barcode = new Ean13Barcode2005.Ean13();
                barcode.CountryCode = "90";
                barcode.ManufacturerCode = "42581";
                barcode.ProductCode = barsayi.ToString("00000");
                barkod = Convert.ToInt64((barcode.CountryCode).ToString() + (barcode.ManufacturerCode).ToString() + (barcode.ProductCode).ToString());
                textBox1.Text = barkod.ToString();
                dr3.Close();
            }
            dr3.Close();
            string sira = "1";
        }

        string sira = "0";

        private void kitapDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1_DoubleClick(sender, e);
        }

        private void barkodYazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kptgnclbutton2(sender, e);
        }

        private void kitapGecmisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilgigecmisi bilgigecmisi = new bilgigecmisi();
            bilgigecmisi.gridView1.FindFilterText = gridView1.GetFocusedRowCellValue("barkod").ToString();
            bilgigecmisi.ShowDialog();
        }

        private void comboBoxEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sira == "1" || sira == "0")
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd4 = new SqlCommand("select * from kitap where barkod='" + textBox1.Text + "'", con);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                if (dr4.Read())
                {
                    textBox2.Text = dr4["kitap_adi"].ToString();
                    textBox3.Text = dr4["yazar_adi"].ToString();
                    comboBoxEdit2.Text = dr4["kitap_turu"].ToString();
                    textBox5.Text = Convert.ToInt32(dr4["sayfa"]).ToString();
                    textBox6.Text = dr4["yayin_evi"].ToString();
                    textBox8.Text = dr4["konu"].ToString();
                    lookUpEdit3.Text = dr4["dil"].ToString();
                    maskedTextBox1.Text = Convert.ToInt32(dr4["yayin_tarihi"]).ToString();
                    textBox7.Text = Convert.ToInt32(dr4["stok"]).ToString();
                    dr4.Close();
                }
                else
                {
                    dr4.Close();
                }
            }
        }

        void counts()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (comboBoxEdit1.Text == "Aktif Kitaplar")
            {
                SqlCommand cmd = new SqlCommand("select count(*) as count from kitap where durum = 1", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelControl13.Text = dr["count"].ToString();
                }
                dr.Close();
                SqlCommand cmd2 = new SqlCommand("select sum(stok) as countadet from kitap where durum = 1 ", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    labelControl14.Text = dr2["countadet"].ToString();
                }
                dr2.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select count(*) as count from kitap where durum = 0", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelControl13.Text = dr["count"].ToString();
                }
                dr.Close();
                SqlCommand cmd2 = new SqlCommand("select sum(stok) as countadet from kitap where durum = 0 ", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    labelControl14.Text = dr2["countadet"].ToString();
                    if (labelControl14.Text == "")
                    {
                        labelControl14.Text = "0";
                    }
                }
                dr2.Close();
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtsil();
        }
    }
}
