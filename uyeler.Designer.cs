
namespace IHHKTP
{
    partial class uyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeler));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lookUpEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uyeDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barkodYazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.colbarkoduye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(5, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Üye Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(5, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Üye Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 161);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 24);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Cinsiyet:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 24);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Bölüm/Fak:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 24);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "E-posta:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Telefon No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Soyisim:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 24);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "TC No:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.textBox1.Location = new System.Drawing.Point(102, 24);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İsim:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.textBox6.Location = new System.Drawing.Point(101, 194);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.textBox5.Location = new System.Drawing.Point(102, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.textBox3.Location = new System.Drawing.Point(102, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.textBox2.Location = new System.Drawing.Point(102, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Maroon;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.button4);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.maskedTextBox1);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textBox6);
            this.groupControl1.Controls.Add(this.textBox5);
            this.groupControl1.Controls.Add(this.textBox3);
            this.groupControl1.Controls.Add(this.textBox2);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.lookUpEdit3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 518);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Üye Bilgileri";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(216, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 19);
            this.button4.TabIndex = 9;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Location = new System.Drawing.Point(4, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 41);
            this.panel1.TabIndex = 56;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl13.Location = new System.Drawing.Point(108, 6);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(94, 24);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "Kitap Sayısı:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 13F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(6, 6);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(83, 24);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Üye Sayısı:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.BackgroundImage = global::IHHKTP.Properties.Resources.icons8_tick_box;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(250, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 22);
            this.button3.TabIndex = 55;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Aktif Üyeler";
            this.comboBoxEdit1.Location = new System.Drawing.Point(101, 1);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.comboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.comboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseBorderColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Aktif Üyeler",
            "Pasif Üyeler"});
            this.comboBoxEdit1.Properties.NullText = "Dil Seçiniz...";
            this.comboBoxEdit1.Properties.PopupSizeable = true;
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(169, 20);
            this.comboBoxEdit1.TabIndex = 0;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.maskedTextBox1.Location = new System.Drawing.Point(102, 111);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(169, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(101, 168);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.lookUpEdit3.Properties.NullText = "Cinsiyet Seçiniz...";
            this.lookUpEdit3.Properties.PopupSizeable = true;
            this.lookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lookUpEdit3.Size = new System.Drawing.Size(169, 20);
            this.lookUpEdit3.TabIndex = 5;
            this.lookUpEdit3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpEdit3_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyeDuzenleToolStripMenuItem,
            this.emanetBilgisiToolStripMenuItem,
            this.barkodYazdirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // uyeDuzenleToolStripMenuItem
            // 
            this.uyeDuzenleToolStripMenuItem.Name = "uyeDuzenleToolStripMenuItem";
            this.uyeDuzenleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.uyeDuzenleToolStripMenuItem.Text = "Üye Düzenle";
            this.uyeDuzenleToolStripMenuItem.Click += new System.EventHandler(this.uyeDuzenleToolStripMenuItem_Click);
            // 
            // emanetBilgisiToolStripMenuItem
            // 
            this.emanetBilgisiToolStripMenuItem.Name = "emanetBilgisiToolStripMenuItem";
            this.emanetBilgisiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.emanetBilgisiToolStripMenuItem.Text = "Emanet Bilgisi";
            this.emanetBilgisiToolStripMenuItem.Click += new System.EventHandler(this.emanetBilgisiToolStripMenuItem_Click);
            // 
            // barkodYazdirToolStripMenuItem
            // 
            this.barkodYazdirToolStripMenuItem.Name = "barkodYazdirToolStripMenuItem";
            this.barkodYazdirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.barkodYazdirToolStripMenuItem.Text = "Barkod Yazdır";
            this.barkodYazdirToolStripMenuItem.Click += new System.EventHandler(this.barkodYazdirToolStripMenuItem_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl3.DataMember = "Query";
            this.gridControl3.DataSource = this.sqlDataSource1;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(278, 0);
            this.gridControl3.MainView = this.gridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(511, 518);
            this.gridControl3.TabIndex = 3;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"uye\".*\r\n  from \"dbo\".\"uye\" \"uye\" where durum=1";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.colceza,
            this.colbarkoduye});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl3;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
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
            this.coltc.Width = 54;
            // 
            // colisim
            // 
            this.colisim.FieldName = "isim";
            this.colisim.Name = "colisim";
            this.colisim.Visible = true;
            this.colisim.VisibleIndex = 1;
            this.colisim.Width = 54;
            // 
            // colsoyisim
            // 
            this.colsoyisim.FieldName = "soyisim";
            this.colsoyisim.Name = "colsoyisim";
            this.colsoyisim.Visible = true;
            this.colsoyisim.VisibleIndex = 2;
            this.colsoyisim.Width = 54;
            // 
            // colbolum
            // 
            this.colbolum.FieldName = "bolum";
            this.colbolum.Name = "colbolum";
            this.colbolum.Visible = true;
            this.colbolum.VisibleIndex = 5;
            this.colbolum.Width = 56;
            // 
            // coltelefon
            // 
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 3;
            this.coltelefon.Width = 54;
            // 
            // coleposta
            // 
            this.coleposta.FieldName = "eposta";
            this.coleposta.Name = "coleposta";
            this.coleposta.Visible = true;
            this.coleposta.VisibleIndex = 4;
            // 
            // colcinsiyet
            // 
            this.colcinsiyet.FieldName = "cinsiyet";
            this.colcinsiyet.Name = "colcinsiyet";
            this.colcinsiyet.Visible = true;
            this.colcinsiyet.VisibleIndex = 6;
            this.colcinsiyet.Width = 33;
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
            this.colokunan.Width = 36;
            // 
            // colceza
            // 
            this.colceza.FieldName = "ceza";
            this.colceza.Name = "colceza";
            // 
            // colbarkoduye
            // 
            this.colbarkoduye.FieldName = "barkoduye";
            this.colbarkoduye.Name = "colbarkoduye";
            this.colbarkoduye.Visible = true;
            this.colbarkoduye.VisibleIndex = 8;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_IHHKTP_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select \"uye\".*\r\n  from \"dbo\".\"uye\" \"uye\" where durum=2";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // uyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "uyeler";
            this.Size = new System.Drawing.Size(789, 518);
            this.Load += new System.EventHandler(this.uyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DevExpress.XtraEditors.ComboBoxEdit lookUpEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uyeDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetBilgisiToolStripMenuItem;
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
        private DevExpress.XtraGrid.Columns.GridColumn colokunan;
        private DevExpress.XtraGrid.Columns.GridColumn colceza;
        public DevExpress.XtraGrid.GridControl gridControl3;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkoduye;
        private System.Windows.Forms.ToolStripMenuItem barkodYazdirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.Button button4;
    }
}
