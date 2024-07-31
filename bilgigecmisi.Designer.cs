
namespace IHHKTP
{
    partial class bilgigecmisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgigecmisi));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsayfa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colteslim_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyayin_evi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazar_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalinma_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.DataSource = this.sqlDataSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(773, 479);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbarkod,
            this.colid,
            this.colidk,
            this.colidu,
            this.colisim,
            this.colkitap_adi,
            this.colkitap_turu,
            this.colsayfa,
            this.colsoyisim,
            this.coltc,
            this.coltelefon,
            this.colteslim_tarihi,
            this.colyayin_evi,
            this.colcinsiyet,
            this.colyazar_adi,
            this.coldurum,
            this.colalinma_tarihi});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFind.FindNullPrompt = "Aramak İçin Yazınız...";
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // colbarkod
            // 
            this.colbarkod.FieldName = "barkod";
            this.colbarkod.Name = "colbarkod";
            this.colbarkod.Visible = true;
            this.colbarkod.VisibleIndex = 5;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colidk
            // 
            this.colidk.FieldName = "idk";
            this.colidk.Name = "colidk";
            // 
            // colidu
            // 
            this.colidu.FieldName = "idu";
            this.colidu.Name = "colidu";
            // 
            // colisim
            // 
            this.colisim.FieldName = "isim";
            this.colisim.Name = "colisim";
            this.colisim.Visible = true;
            this.colisim.VisibleIndex = 7;
            // 
            // colkitap_adi
            // 
            this.colkitap_adi.FieldName = "kitap_adi";
            this.colkitap_adi.Name = "colkitap_adi";
            this.colkitap_adi.Visible = true;
            this.colkitap_adi.VisibleIndex = 0;
            // 
            // colkitap_turu
            // 
            this.colkitap_turu.FieldName = "kitap_turu";
            this.colkitap_turu.Name = "colkitap_turu";
            this.colkitap_turu.Visible = true;
            this.colkitap_turu.VisibleIndex = 2;
            // 
            // colsayfa
            // 
            this.colsayfa.FieldName = "sayfa";
            this.colsayfa.Name = "colsayfa";
            this.colsayfa.Visible = true;
            this.colsayfa.VisibleIndex = 4;
            // 
            // colsoyisim
            // 
            this.colsoyisim.FieldName = "soyisim";
            this.colsoyisim.Name = "colsoyisim";
            this.colsoyisim.Visible = true;
            this.colsoyisim.VisibleIndex = 8;
            // 
            // coltc
            // 
            this.coltc.FieldName = "tc";
            this.coltc.Name = "coltc";
            this.coltc.Visible = true;
            this.coltc.VisibleIndex = 6;
            // 
            // coltelefon
            // 
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 9;
            // 
            // colteslim_tarihi
            // 
            this.colteslim_tarihi.FieldName = "teslim_tarihi";
            this.colteslim_tarihi.Name = "colteslim_tarihi";
            this.colteslim_tarihi.Visible = true;
            this.colteslim_tarihi.VisibleIndex = 12;
            // 
            // colyayin_evi
            // 
            this.colyayin_evi.FieldName = "yayin_evi";
            this.colyayin_evi.Name = "colyayin_evi";
            this.colyayin_evi.Visible = true;
            this.colyayin_evi.VisibleIndex = 3;
            // 
            // colcinsiyet
            // 
            this.colcinsiyet.FieldName = "cinsiyet";
            this.colcinsiyet.Name = "colcinsiyet";
            this.colcinsiyet.Visible = true;
            this.colcinsiyet.VisibleIndex = 10;
            // 
            // colyazar_adi
            // 
            this.colyazar_adi.FieldName = "yazar_adi";
            this.colyazar_adi.Name = "colyazar_adi";
            this.colyazar_adi.Visible = true;
            this.colyazar_adi.VisibleIndex = 1;
            // 
            // coldurum
            // 
            this.coldurum.FieldName = "durum";
            this.coldurum.Name = "coldurum";
            this.coldurum.Visible = true;
            this.coldurum.VisibleIndex = 13;
            // 
            // colalinma_tarihi
            // 
            this.colalinma_tarihi.FieldName = "alinma_tarihi";
            this.colalinma_tarihi.Name = "colalinma_tarihi";
            this.colalinma_tarihi.Visible = true;
            this.colalinma_tarihi.VisibleIndex = 11;
            // 
            // bilgigecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 479);
            this.Controls.Add(this.gridControl2);
            this.Name = "bilgigecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bilgigecmisi";
            this.Load += new System.EventHandler(this.bilgigecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidk;
        private DevExpress.XtraGrid.Columns.GridColumn colidu;
        private DevExpress.XtraGrid.Columns.GridColumn colisim;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_turu;
        private DevExpress.XtraGrid.Columns.GridColumn colsayfa;
        private DevExpress.XtraGrid.Columns.GridColumn colsoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn coltc;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colteslim_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colyayin_evi;
        private DevExpress.XtraGrid.Columns.GridColumn colcinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn colyazar_adi;
        private DevExpress.XtraGrid.Columns.GridColumn coldurum;
        private DevExpress.XtraGrid.Columns.GridColumn colalinma_tarihi;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}