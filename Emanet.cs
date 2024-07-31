using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHHKTP
{
    public partial class Emanet : UserControl
    {
        public Emanet()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
            sqlDataSource3.FillAsync();
        }

        emanetnumara emanetnumara = new emanetnumara();
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\IHH;AttachDbFilename=|DataDirectory|\\IHHKTP.mdf;Initial Catalog=IHHKTP;Integrated Security=true;");
        XtraMessageBoxArgs mesaj = new XtraMessageBoxArgs();

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("kitap_adi").ToString() + " Adlı Kitap ";
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEdit2.Text = gridView2.GetFocusedRowCellValue("isim").ToString() + " Kişisine Verilecek";
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
            gridView2.Columns["tc"].Caption = "TC No";
            gridView2.Columns["isim"].Caption = "İsim";
            gridView2.Columns["soyisim"].Caption = "Soyisim";
            gridView2.Columns["telefon"].Caption = "Telefon";
            gridView2.Columns["bolum"].Caption = "Bölüm";
            gridView2.Columns["eposta"].Caption = "E-Posta";
            gridView2.Columns["cinsiyet"].Caption = "Cinsiyet";
            gridView2.Columns["okunan"].Caption = "Okunan";
            gridView2.Columns["ceza"].Caption = "Ceza";
        }

        private void Emanet_Load(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            gridView2.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            events();
            isim();
        }

        void events()
        {
            emanetnumara.button1.Click += emanetverbtn1_Click;
        }

        private void emanetverbtn1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from emanet WHERE DURUM=1 AND barkod='" + emanetnumara.textBox2.Text + "' AND tc='" + emanetnumara.textBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu kitap kişide mevcut.");
            }
            else
            {
                dr.Close();
                SqlCommand cmd3 = new SqlCommand("select k.id as k_id, kitap_adi,yazar_adi,yayin_evi,sayfa,stok,barkod,kitap_turu,k.durum as k_durum,u.id as u_id,isim,soyisim,telefon, tc, eposta, bolum, cinsiyet, u.durum as u_durum, okunan from kitap K CROSS JOIN uye U WHERE k.durum=1 and u.durum=1 and barkod='" + emanetnumara.textBox2.Text + "' AND tc='" + emanetnumara.textBox1.Text + "'", con);
                SqlDataReader dr2 = cmd3.ExecuteReader();
                cmd3.Connection = con;
                if (dr2.Read())
                {
                    if (int.Parse(dr2["stok"].ToString()) > 0)
                    {
                        dr2.Close();
                        SqlCommand cmd4 = new SqlCommand("select count(*) as sayi from emanet WHERE (DURUM = 1 or durum = 2) AND tc = '" + emanetnumara.textBox1.Text + "'", con);
                        SqlDataReader dr3 = cmd4.ExecuteReader();
                        cmd4.Connection = con;
                        if (dr3.Read())
                        {
                            if (int.Parse(dr3["sayi"].ToString()) >= 2)
                            {
                                MessageBox.Show("Bu Kişi Alınabilecek Kitap Sınırını Doldurmuştur.");
                            }
                            else
                            {
                                if (MessageBox.Show(dr2["kitap_adi"].ToString() + " kitabını " + dr2["isim"].ToString() + " kişisine emanet vermek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    dr.Close();
                                    cmd = new SqlCommand();
                                    cmd.Connection = con;
                                    cmd.CommandText = "insert into emanet(idk,kitap_adi,yazar_adi,kitap_turu,sayfa,barkod,yayin_evi,idu,tc,isim,soyisim,telefon,cinsiyet,alinma_tarihi,teslim_tarihi,durum) VALUES (@idk,@kitap_adi,@yazar_adi,@kitap_turu,@sayfa,@barkod,@yayin_evi,@idu,@tc,@isim,@soyisim,@telefon,@cinsiyet,@alinma_tarihi,@teslim_tarihi,@durum)";
                                    cmd.Parameters.AddWithValue("idk", dr2["k_id"].ToString());
                                    cmd.Parameters.AddWithValue("kitap_adi", dr2["kitap_adi"].ToString());
                                    cmd.Parameters.AddWithValue("yazar_adi", dr2["yazar_adi"].ToString());
                                    cmd.Parameters.AddWithValue("kitap_turu", dr2["kitap_turu"].ToString());
                                    cmd.Parameters.AddWithValue("sayfa", dr2["sayfa"].ToString());
                                    cmd.Parameters.AddWithValue("barkod", dr2["barkod"].ToString());
                                    cmd.Parameters.AddWithValue("yayin_evi", dr2["yayin_evi"].ToString());
                                    cmd.Parameters.AddWithValue("idu", dr2["u_id"].ToString());
                                    cmd.Parameters.AddWithValue("tc", dr2["tc"].ToString());
                                    cmd.Parameters.AddWithValue("isim", dr2["isim"].ToString());
                                    cmd.Parameters.AddWithValue("soyisim", dr2["soyisim"].ToString());
                                    cmd.Parameters.AddWithValue("cinsiyet", dr2["cinsiyet"].ToString());
                                    cmd.Parameters.AddWithValue("telefon", dr2["telefon"].ToString());
                                    cmd.Parameters.AddWithValue("alinma_tarihi", DateTime.Parse(DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy")));
                                    cmd.Parameters.AddWithValue("teslim_tarihi", DateTime.Parse(DateTime.Now.AddDays(+15).ToString("hh:mm:ss dd.MM.yyyy")));
                                    cmd.Parameters.AddWithValue("durum", 1);
                                    SqlCommand cmd2 = new SqlCommand("UPDATE kitap SET stok=stok-1 WHERE id='" + dr2["k_id"].ToString() + "'");
                                    cmd2.Connection = con;
                                    dr3.Close();
                                    dr2.Close();
                                    dr.Close();
                                    cmd.ExecuteNonQuery();
                                    cmd2.ExecuteNonQuery();
                                    cmd3.ExecuteNonQuery();
                                    cmd3.ExecuteNonQuery();
                                    if (con.State == ConnectionState.Open)
                                    {
                                        con.Close();
                                    }
                                    mesaj.AutoCloseOptions.Delay = 1000;
                                    mesaj.Caption = "Tamamlandı";
                                    mesaj.Text = "Kitap verildi.";
                                    mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                                    mesaj.DefaultButtonIndex = 1;
                                    mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                                    XtraMessageBox.Show(mesaj).ToString();
                                    emanetnumarakapat();
                                    sqlDataSource1.FillAsync();
                                    sqlDataSource3.FillAsync();
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu kitap için yeterli stok yok.");
                        emanetnumarakapat();
                    }
                }
                dr2.Close();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0 && gridView2.RowCount != 0)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from emanet WHERE DURUM=1 AND id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "' AND idu='" + gridView2.GetFocusedRowCellValue("id").ToString() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu kitap kişide mevcut.");
                }
                else
                {
                    dr.Close();
                    SqlCommand cmd3 = new SqlCommand("select k.id as k_id, kitap_adi,yazar_adi,yayin_evi,sayfa,stok,barkod,kitap_turu,k.durum as k_durum,u.id as u_id,isim,soyisim,telefon, tc, eposta, bolum, cinsiyet, u.durum as u_durum, okunan from kitap K CROSS JOIN uye U WHERE k.durum=1 and u.durum=1 and k.barkod='" + gridView1.GetFocusedRowCellValue("barkod").ToString() + "' AND tc='" + gridView2.GetFocusedRowCellValue("tc").ToString() + "'", con);
                    SqlDataReader dr2 = cmd3.ExecuteReader();
                    cmd3.Connection = con;
                    if (int.Parse(gridView1.GetFocusedRowCellValue("stok").ToString()) > 0)
                    {
                        dr2.Close();
                        SqlCommand cmd4 = new SqlCommand("select count(*) as sayi from emanet WHERE (DURUM = 1 or durum = 2) AND tc = '" + gridView2.GetFocusedRowCellValue("tc").ToString() + "'", con);
                        SqlDataReader dr3 = cmd4.ExecuteReader();
                        cmd4.Connection = con;
                        if (dr3.Read())
                        {
                            if (int.Parse(dr3["sayi"].ToString()) >= 2)
                            {
                                MessageBox.Show("Bu Kişi Alınabilecek Kitap Sınırını Doldurmuştur.");
                                dr3.Close();
                                dr2.Close();
                                dr.Close();
                            }
                            else
                            {
                                if (MessageBox.Show(gridView1.GetFocusedRowCellValue("kitap_adi").ToString() + " kitabını " + gridView2.GetFocusedRowCellValue("isim").ToString() + " kişisine emanet vermek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    dr.Close();
                                    cmd = new SqlCommand();
                                    cmd.Connection = con;
                                    cmd.CommandText = "insert into emanet(idk,kitap_adi,yazar_adi,kitap_turu,sayfa,barkod,yayin_evi,idu,tc,isim,soyisim,telefon,cinsiyet,alinma_tarihi,teslim_tarihi,durum) VALUES (@idk,@kitap_adi,@yazar_adi,@kitap_turu,@sayfa,@barkod,@yayin_evi,@idu,@tc,@isim,@soyisim,@telefon,@cinsiyet,@alinma_tarihi,@teslim_tarihi,@durum)";
                                    cmd.Parameters.AddWithValue("idk", gridView1.GetFocusedRowCellValue("id").ToString());
                                    cmd.Parameters.AddWithValue("kitap_adi", gridView1.GetFocusedRowCellValue("kitap_adi").ToString());
                                    cmd.Parameters.AddWithValue("yazar_adi", gridView1.GetFocusedRowCellValue("yazar_adi").ToString());
                                    cmd.Parameters.AddWithValue("kitap_turu", gridView1.GetFocusedRowCellValue("kitap_turu").ToString());
                                    cmd.Parameters.AddWithValue("sayfa", gridView1.GetFocusedRowCellValue("sayfa").ToString());
                                    cmd.Parameters.AddWithValue("barkod", gridView1.GetFocusedRowCellValue("barkod").ToString());
                                    cmd.Parameters.AddWithValue("yayin_evi", gridView1.GetFocusedRowCellValue("yayin_evi").ToString());
                                    cmd.Parameters.AddWithValue("idu", gridView2.GetFocusedRowCellValue("id").ToString());
                                    cmd.Parameters.AddWithValue("tc", gridView2.GetFocusedRowCellValue("tc").ToString());
                                    cmd.Parameters.AddWithValue("isim", gridView2.GetFocusedRowCellValue("isim").ToString());
                                    cmd.Parameters.AddWithValue("soyisim", gridView2.GetFocusedRowCellValue("soyisim").ToString());
                                    cmd.Parameters.AddWithValue("cinsiyet", gridView2.GetFocusedRowCellValue("cinsiyet").ToString());
                                    cmd.Parameters.AddWithValue("telefon", gridView2.GetFocusedRowCellValue("telefon").ToString());
                                    cmd.Parameters.AddWithValue("alinma_tarihi", DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy")));
                                    cmd.Parameters.AddWithValue("teslim_tarihi", DateTime.Parse(DateTime.Now.AddDays(+15).ToString("dd.MM.yyyy")));
                                    cmd.Parameters.AddWithValue("durum", 1);
                                    SqlCommand cmd2 = new SqlCommand("UPDATE kitap SET stok=stok-1 WHERE id='" + gridView1.GetFocusedRowCellValue("id").ToString() + "'");
                                    cmd2.Connection = con;
                                    dr3.Close();
                                    dr2.Close();
                                    dr.Close();
                                    cmd.ExecuteNonQuery();
                                    cmd2.ExecuteNonQuery();
                                    cmd3.ExecuteNonQuery();
                                    cmd3.ExecuteNonQuery();
                                    if (con.State == ConnectionState.Open)
                                    {
                                        con.Close();
                                    }
                                    mesaj.AutoCloseOptions.Delay = 1000;
                                    mesaj.Caption = "Tamamlandı";
                                    mesaj.Text = "Kitap verildi.";
                                    mesaj.Buttons = new DialogResult[] { DialogResult.OK };
                                    mesaj.DefaultButtonIndex = 1;
                                    mesaj.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                                    XtraMessageBox.Show(mesaj).ToString();
                                    sqlDataSource1.FillAsync();
                                    sqlDataSource3.FillAsync();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu kitap için yeterli stok yok.");
                    }
                }
                dr.Close();
            }
        }

        void emanetnumarakapat()
        {
            emanetnumara.Close();
            emanetnumara.textBox1.Clear();
            emanetnumara.textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emanetnumara.ShowDialog();
        }
    }
}
