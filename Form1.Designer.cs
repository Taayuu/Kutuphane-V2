
namespace IHHKTP
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.anasayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.kitap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.uye = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.emanet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button11);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::IHHKTP.Properties.Resources.icons8_minus_3;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::IHHKTP.Properties.Resources.icons8_maximize_button;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::IHHKTP.Properties.Resources.icons8_delete_3;
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.anasayfa,
            this.kitap,
            this.uye,
            this.accordionControlElement3,
            this.accordionControlElement5});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Height = 60;
            this.accordionControlElement1.ImageOptions.Image = global::IHHKTP.Properties.Resources.indir__4__ig6_icon;
            this.accordionControlElement1.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement1.Name = "accordionControlElement1";
            resources.ApplyResources(this.accordionControlElement1, "accordionControlElement1");
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement8.Appearance.Hovered.Font")));
            this.accordionControlElement8.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement8.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement8.Appearance.Normal.Font")));
            this.accordionControlElement8.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement8.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement8.Appearance.Pressed.Font")));
            this.accordionControlElement8.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement8.Height = 60;
            this.accordionControlElement8.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControlElement8.ImageOptions.Image = global::IHHKTP.Properties.Resources.login;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement8, "accordionControlElement8");
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("anasayfa.Appearance.Hovered.Font")));
            this.anasayfa.Appearance.Hovered.Options.UseFont = true;
            this.anasayfa.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("anasayfa.Appearance.Normal.Font")));
            this.anasayfa.Appearance.Normal.Options.UseFont = true;
            this.anasayfa.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("anasayfa.Appearance.Pressed.Font")));
            this.anasayfa.Appearance.Pressed.Options.UseFont = true;
            this.anasayfa.Height = 60;
            this.anasayfa.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.anasayfa.ImageOptions.Image = global::IHHKTP.Properties.Resources.homepage;
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.anasayfa, "anasayfa");
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // kitap
            // 
            this.kitap.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("kitap.Appearance.Hovered.Font")));
            this.kitap.Appearance.Hovered.Options.UseFont = true;
            this.kitap.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("kitap.Appearance.Normal.Font")));
            this.kitap.Appearance.Normal.Options.UseFont = true;
            this.kitap.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("kitap.Appearance.Pressed.Font")));
            this.kitap.Appearance.Pressed.Options.UseFont = true;
            this.kitap.Height = 60;
            this.kitap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.kitap.ImageOptions.Image = global::IHHKTP.Properties.Resources.bookshelf;
            this.kitap.Name = "kitap";
            this.kitap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.kitap, "kitap");
            this.kitap.Click += new System.EventHandler(this.kitap_Click);
            // 
            // uye
            // 
            this.uye.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("uye.Appearance.Hovered.Font")));
            this.uye.Appearance.Hovered.Options.UseFont = true;
            this.uye.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("uye.Appearance.Normal.Font")));
            this.uye.Appearance.Normal.Options.UseFont = true;
            this.uye.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("uye.Appearance.Pressed.Font")));
            this.uye.Appearance.Pressed.Options.UseFont = true;
            this.uye.Height = 60;
            this.uye.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.uye.ImageOptions.Image = global::IHHKTP.Properties.Resources.icons8_member;
            this.uye.Name = "uye";
            this.uye.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.uye, "uye");
            this.uye.Click += new System.EventHandler(this.uye_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement3.Appearance.Hovered.Font")));
            this.accordionControlElement3.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement3.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement3.Appearance.Normal.Font")));
            this.accordionControlElement3.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement3.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement3.Appearance.Pressed.Font")));
            this.accordionControlElement3.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.emanet,
            this.accordionControlElement4});
            this.accordionControlElement3.Height = 60;
            this.accordionControlElement3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControlElement3.ImageOptions.Image = global::IHHKTP.Properties.Resources.icons8_send_hot_list_2;
            this.accordionControlElement3.Name = "accordionControlElement3";
            resources.ApplyResources(this.accordionControlElement3, "accordionControlElement3");
            // 
            // emanet
            // 
            this.emanet.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("emanet.Appearance.Hovered.Font")));
            this.emanet.Appearance.Hovered.Options.UseFont = true;
            this.emanet.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("emanet.Appearance.Normal.Font")));
            this.emanet.Appearance.Normal.Options.UseFont = true;
            this.emanet.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("emanet.Appearance.Pressed.Font")));
            this.emanet.Appearance.Pressed.Options.UseFont = true;
            this.emanet.Expanded = true;
            this.emanet.Height = 60;
            this.emanet.ImageOptions.Image = global::IHHKTP.Properties.Resources.icons8_right;
            this.emanet.Name = "emanet";
            this.emanet.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.emanet, "emanet");
            this.emanet.Click += new System.EventHandler(this.emanet_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement4.Appearance.Hovered.Font")));
            this.accordionControlElement4.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement4.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement4.Appearance.Normal.Font")));
            this.accordionControlElement4.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement4.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement4.Appearance.Pressed.Font")));
            this.accordionControlElement4.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement4.Height = 60;
            this.accordionControlElement4.ImageOptions.Image = global::IHHKTP.Properties.Resources.icons8_left_1;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement4, "accordionControlElement4");
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement5.Appearance.Hovered.Font")));
            this.accordionControlElement5.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement5.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement5.Appearance.Normal.Font")));
            this.accordionControlElement5.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement5.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement5.Appearance.Pressed.Font")));
            this.accordionControlElement5.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement7});
            this.accordionControlElement5.Height = 60;
            this.accordionControlElement5.ImageOptions.Image = global::IHHKTP.Properties.Resources.icons8_barcode;
            this.accordionControlElement5.Name = "accordionControlElement5";
            resources.ApplyResources(this.accordionControlElement5, "accordionControlElement5");
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement6.Appearance.Hovered.Font")));
            this.accordionControlElement6.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement6.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement6.Appearance.Normal.Font")));
            this.accordionControlElement6.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement6.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement6.Appearance.Pressed.Font")));
            this.accordionControlElement6.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement6.Height = 60;
            this.accordionControlElement6.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement6, "accordionControlElement6");
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement7.Appearance.Hovered.Font")));
            this.accordionControlElement7.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement7.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement7.Appearance.Normal.Font")));
            this.accordionControlElement7.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement7.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("accordionControlElement7.Appearance.Pressed.Font")));
            this.accordionControlElement7.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement7.Height = 60;
            this.accordionControlElement7.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControlElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement7, "accordionControlElement7");
            this.accordionControlElement7.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.AccordionControl.BackColor2 = ((System.Drawing.Color)(resources.GetObject("accordionControl1.Appearance.AccordionControl.BackColor2")));
            this.accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.accordionControl1.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.Hint.BackColor2 = ((System.Drawing.Color)(resources.GetObject("accordionControl1.Appearance.Hint.BackColor2")));
            this.accordionControl1.Appearance.Hint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.Hint.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Hint.Options.UseBorderColor = true;
            resources.ApplyResources(this.accordionControl1, "accordionControl1");
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement2, "accordionControlElement2");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement anasayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement kitap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement uye;
        private DevExpress.XtraBars.Navigation.AccordionControlElement emanet;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
    }
}

