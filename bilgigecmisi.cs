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
    public partial class bilgigecmisi : Form
    {
        public bilgigecmisi()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
        }

        private void bilgigecmisi_Load(object sender, EventArgs e)
        {
            isim();
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
    }
}
