
namespace IHHKTP
{
    partial class Emanet
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery8 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colokunan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colceza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazar_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyayin_evi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsayfa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyayin_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BorderColor = System.Drawing.Color.Maroon;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(655, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(134, 233);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Üyeler";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource3;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(130, 208);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery5.Name = "Query";
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Maroon;
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 13F);
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coltc,
            this.colisim,
            this.colsoyisim,
            this.colbolum,
            this.coltelefon,
            this.coleposta,
            this.colcinsiyet,
            this.coldurum,
            this.colokunan,
            this.colceza});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsFind.FindNullPrompt = "Aramak İçin Yazın...";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coltc
            // 
            this.coltc.FieldName = "tc";
            this.coltc.Name = "coltc";
            this.coltc.Visible = true;
            this.coltc.VisibleIndex = 0;
            // 
            // colisim
            // 
            this.colisim.FieldName = "isim";
            this.colisim.Name = "colisim";
            this.colisim.Visible = true;
            this.colisim.VisibleIndex = 1;
            // 
            // colsoyisim
            // 
            this.colsoyisim.FieldName = "soyisim";
            this.colsoyisim.Name = "colsoyisim";
            this.colsoyisim.Visible = true;
            this.colsoyisim.VisibleIndex = 2;
            // 
            // colbolum
            // 
            this.colbolum.FieldName = "bolum";
            this.colbolum.Name = "colbolum";
            this.colbolum.Visible = true;
            this.colbolum.VisibleIndex = 4;
            // 
            // coltelefon
            // 
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 3;
            // 
            // coleposta
            // 
            this.coleposta.FieldName = "eposta";
            this.coleposta.Name = "coleposta";
            this.coleposta.Visible = true;
            this.coleposta.VisibleIndex = 5;
            // 
            // colcinsiyet
            // 
            this.colcinsiyet.FieldName = "cinsiyet";
            this.colcinsiyet.Name = "colcinsiyet";
            this.colcinsiyet.Visible = true;
            this.colcinsiyet.VisibleIndex = 6;
            // 
            // coldurum
            // 
            this.coldurum.FieldName = "durum";
            this.coldurum.Name = "coldurum";
            // 
            // colokunan
            // 
            this.colokunan.FieldName = "okunan";
            this.colokunan.Name = "colokunan";
            this.colokunan.Visible = true;
            this.colokunan.VisibleIndex = 7;
            // 
            // colceza
            // 
            this.colceza.FieldName = "ceza";
            this.colceza.Name = "colceza";
            this.colceza.Visible = true;
            this.colceza.VisibleIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Maroon;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(655, 233);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kitaplar";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.DataSource = this.sqlDataSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 23);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(651, 208);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery6.Name = "Query";
            customSqlQuery6.Sql = resources.GetString("customSqlQuery6.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery6});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Maroon;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 13F);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colkitap_adi,
            this.colyazar_adi,
            this.colkitap_turu,
            this.colyayin_evi,
            this.colsayfa,
            this.colstok,
            this.colbarkod,
            this.colkonu,
            this.coldil,
            this.colyayin_tarihi});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFind.FindNullPrompt = "Aramak İçin Yazınız...";
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colkitap_adi
            // 
            this.colkitap_adi.FieldName = "kitap_adi";
            this.colkitap_adi.Name = "colkitap_adi";
            this.colkitap_adi.Visible = true;
            this.colkitap_adi.VisibleIndex = 0;
            // 
            // colyazar_adi
            // 
            this.colyazar_adi.FieldName = "yazar_adi";
            this.colyazar_adi.Name = "colyazar_adi";
            this.colyazar_adi.Visible = true;
            this.colyazar_adi.VisibleIndex = 1;
            // 
            // colkitap_turu
            // 
            this.colkitap_turu.FieldName = "kitap_turu";
            this.colkitap_turu.Name = "colkitap_turu";
            this.colkitap_turu.Visible = true;
            this.colkitap_turu.VisibleIndex = 2;
            // 
            // colyayin_evi
            // 
            this.colyayin_evi.FieldName = "yayin_evi";
            this.colyayin_evi.Name = "colyayin_evi";
            this.colyayin_evi.Visible = true;
            this.colyayin_evi.VisibleIndex = 3;
            // 
            // colsayfa
            // 
            this.colsayfa.FieldName = "sayfa";
            this.colsayfa.Name = "colsayfa";
            this.colsayfa.Visible = true;
            this.colsayfa.VisibleIndex = 4;
            // 
            // colstok
            // 
            this.colstok.FieldName = "stok";
            this.colstok.Name = "colstok";
            this.colstok.Visible = true;
            this.colstok.VisibleIndex = 5;
            // 
            // colbarkod
            // 
            this.colbarkod.FieldName = "barkod";
            this.colbarkod.Name = "colbarkod";
            this.colbarkod.Visible = true;
            this.colbarkod.VisibleIndex = 6;
            // 
            // colkonu
            // 
            this.colkonu.FieldName = "konu";
            this.colkonu.Name = "colkonu";
            this.colkonu.Visible = true;
            this.colkonu.VisibleIndex = 7;
            // 
            // coldil
            // 
            this.coldil.FieldName = "dil";
            this.coldil.Name = "coldil";
            this.coldil.Visible = true;
            this.coldil.VisibleIndex = 8;
            // 
            // colyayin_tarihi
            // 
            this.colyayin_tarihi.FieldName = "yayin_tarihi";
            this.colyayin_tarihi.Name = "colyayin_tarihi";
            this.colyayin_tarihi.Visible = true;
            this.colyayin_tarihi.VisibleIndex = 9;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupControl3.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Controls.Add(this.button1);
            this.groupControl3.Controls.Add(this.button2);
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 233);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(789, 285);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Emanet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(477, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Listeden Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(271, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Numara ile Ver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Verilecek Kitap Seçiniz";
            this.textEdit1.Location = new System.Drawing.Point(205, 44);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.NullText = "Verilecek Kitap";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(217, 139);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Verilecek Kişi Seçiniz";
            this.textEdit2.Location = new System.Drawing.Point(428, 44);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.NullText = "Verilecek Kişi";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(217, 139);
            this.textEdit2.TabIndex = 0;
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            customSqlQuery7.Name = "Query";
            customSqlQuery7.Sql = resources.GetString("customSqlQuery7.Sql");
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery7});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery8.Name = "Query";
            customSqlQuery8.Sql = resources.GetString("customSqlQuery8.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery8});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Name = "Emanet";
            this.Size = new System.Drawing.Size(789, 518);
            this.Load += new System.EventHandler(this.Emanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc;
        private DevExpress.XtraGrid.Columns.GridColumn colisim;
        private DevExpress.XtraGrid.Columns.GridColumn colsoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colbolum;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefon;
        private DevExpress.XtraGrid.Columns.GridColumn coleposta;
        private DevExpress.XtraGrid.Columns.GridColumn colcinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn coldurum;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit textEdit2;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colyazar_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_turu;
        private DevExpress.XtraGrid.Columns.GridColumn colyayin_evi;
        private DevExpress.XtraGrid.Columns.GridColumn colsayfa;
        private DevExpress.XtraGrid.Columns.GridColumn colstok;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkod;
        private System.Windows.Forms.Button button1;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraGrid.Columns.GridColumn colokunan;
        private DevExpress.XtraGrid.Columns.GridColumn colceza;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colkonu;
        private DevExpress.XtraGrid.Columns.GridColumn coldil;
        private DevExpress.XtraGrid.Columns.GridColumn colyayin_tarihi;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}
