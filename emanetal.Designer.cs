
namespace IHHKTP
{
    partial class emanetal
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetal));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button6 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.BorderColor = System.Drawing.Color.Maroon;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.Controls.Add(this.comboBoxEdit1);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(278, 518);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Kitap Bilgileri";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "";
            this.comboBoxEdit1.Location = new System.Drawing.Point(108, 1);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.comboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.comboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Tüm Emanetler",
            "Vaktinde Emanetler",
            "Gecikmiş Emanetler",
            "Pasif Emanetler"});
            this.comboBoxEdit1.Properties.NullText = "Dil Seçiniz...";
            this.comboBoxEdit1.Properties.PopupSizeable = true;
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(169, 20);
            this.comboBoxEdit1.TabIndex = 55;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.button6);
            this.groupControl1.Controls.Add(this.maskedTextBox1);
            this.groupControl1.Controls.Add(this.button5);
            this.groupControl1.Controls.Add(this.button4);
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Location = new System.Drawing.Point(7, 355);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(265, 123);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Süre Ekle";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(151, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 27);
            this.button6.TabIndex = 3;
            this.button6.Text = "Onayla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 84);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(122, 27);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(179, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "+15";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(92, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "+10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(5, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "+7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(153, 24);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Aktif Emanet Sayısı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 24);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "___";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 243);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(27, 24);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "___";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "___";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 213);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(153, 24);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Pasif Emanet Sayısı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(185, 24);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Gecikmiş Emanet Sayısı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 24);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "___";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(174, 24);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Toplam Emanet Sayısı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(5, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "İade Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.DataSource = this.sqlDataSource2;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(278, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(511, 518);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 13F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Maroon;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 13F);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
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
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // emanetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupControl2);
            this.Name = "emanetal";
            this.Size = new System.Drawing.Size(789, 518);
            this.Load += new System.EventHandler(this.emanetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
