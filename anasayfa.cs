using DevExpress.XtraGrid.Views.Grid;
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
    public partial class anasayfa : UserControl
    {
        public anasayfa()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
            sqlDataSource3.FillAsync();
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

        private void anasayfa_Load(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            gridView2.GroupPanelText = "Filtrelemek İçin Sutunları Sürükleyiniz.";
            isim();
        }
    }
}
