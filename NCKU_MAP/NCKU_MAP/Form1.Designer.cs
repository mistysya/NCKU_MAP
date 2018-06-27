namespace NCKU_MAP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguide = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBookMark = new System.Windows.Forms.Label();
            this.pbxOpenTime = new System.Windows.Forms.PictureBox();
            this.lblOpenTime = new System.Windows.Forms.Label();
            this.pbxPhoneNum = new System.Windows.Forms.PictureBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.pbxWebsite = new System.Windows.Forms.PictureBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.pbxAddress = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxDescript = new System.Windows.Forms.TextBox();
            this.btnBookmark = new System.Windows.Forms.Button();
            this.pbxScene = new System.Windows.Forms.PictureBox();
            this.lblScene = new System.Windows.Forms.Label();
            this.lbxSearchBar = new System.Windows.Forms.ListBox();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnAddScene = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclasstable = new System.Windows.Forms.Button();
            this.btnsaved = new System.Windows.Forms.Button();
            this.panlogo = new System.Windows.Forms.Panel();
            this.btnclosesheet = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnsheet = new System.Windows.Forms.Button();
            this.panelNavigate = new System.Windows.Forms.Panel();
            this.btnNavigateFind = new System.Windows.Forms.Button();
            this.btncloseguide = new System.Windows.Forms.Button();
            this.lbxNavigate = new System.Windows.Forms.ListBox();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.panelStoreList = new System.Windows.Forms.Panel();
            this.lblStoreList = new System.Windows.Forms.Label();
            this.lbxStorelist = new System.Windows.Forms.ListBox();
            this.btnStoreClose = new System.Windows.Forms.Button();
            this.btnfeedback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScene)).BeginInit();
            this.panel2.SuspendLayout();
            this.panlogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.panelNavigate.SuspendLayout();
            this.panelStoreList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Location = new System.Drawing.Point(55, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(280, 35);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.Text = "搜尋地點";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            this.tbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1260, 680);
            this.webBrowser1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnguide);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblBookMark);
            this.panel1.Controls.Add(this.pbxOpenTime);
            this.panel1.Controls.Add(this.lblOpenTime);
            this.panel1.Controls.Add(this.pbxPhoneNum);
            this.panel1.Controls.Add(this.lblPhoneNum);
            this.panel1.Controls.Add(this.pbxWebsite);
            this.panel1.Controls.Add(this.lblWebsite);
            this.panel1.Controls.Add(this.pbxAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.tbxDescript);
            this.panel1.Controls.Add(this.btnBookmark);
            this.panel1.Controls.Add(this.pbxScene);
            this.panel1.Controls.Add(this.lblScene);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 680);
            this.panel1.TabIndex = 3;
            // 
            // btnguide
            // 
            this.btnguide.BackgroundImage = global::NCKU_MAP.Properties.Resources.guide_icon;
            this.btnguide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguide.FlatAppearance.BorderSize = 0;
            this.btnguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguide.Location = new System.Drawing.Point(287, 240);
            this.btnguide.Name = "btnguide";
            this.btnguide.Size = new System.Drawing.Size(60, 60);
            this.btnguide.TabIndex = 14;
            this.btnguide.UseVisualStyleBackColor = true;
            this.btnguide.Click += new System.EventHandler(this.btnguide_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(12, 298);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblBookMark
            // 
            this.lblBookMark.AutoSize = true;
            this.lblBookMark.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookMark.Location = new System.Drawing.Point(82, 343);
            this.lblBookMark.Name = "lblBookMark";
            this.lblBookMark.Size = new System.Drawing.Size(48, 24);
            this.lblBookMark.TabIndex = 12;
            this.lblBookMark.Text = "標記";
            // 
            // pbxOpenTime
            // 
            this.pbxOpenTime.BackgroundImage = global::NCKU_MAP.Properties.Resources.time_icon;
            this.pbxOpenTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxOpenTime.Location = new System.Drawing.Point(11, 649);
            this.pbxOpenTime.Name = "pbxOpenTime";
            this.pbxOpenTime.Size = new System.Drawing.Size(25, 25);
            this.pbxOpenTime.TabIndex = 11;
            this.pbxOpenTime.TabStop = false;
            // 
            // lblOpenTime
            // 
            this.lblOpenTime.AutoSize = true;
            this.lblOpenTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOpenTime.Location = new System.Drawing.Point(42, 650);
            this.lblOpenTime.Name = "lblOpenTime";
            this.lblOpenTime.Size = new System.Drawing.Size(88, 20);
            this.lblOpenTime.TabIndex = 10;
            this.lblOpenTime.Text = "OpenTime";
            // 
            // pbxPhoneNum
            // 
            this.pbxPhoneNum.BackgroundImage = global::NCKU_MAP.Properties.Resources.phone_icon;
            this.pbxPhoneNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPhoneNum.Location = new System.Drawing.Point(11, 619);
            this.pbxPhoneNum.Name = "pbxPhoneNum";
            this.pbxPhoneNum.Size = new System.Drawing.Size(25, 25);
            this.pbxPhoneNum.TabIndex = 9;
            this.pbxPhoneNum.TabStop = false;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhoneNum.Location = new System.Drawing.Point(42, 624);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(121, 20);
            this.lblPhoneNum.TabIndex = 8;
            this.lblPhoneNum.Text = "PhoneNumber";
            // 
            // pbxWebsite
            // 
            this.pbxWebsite.BackgroundImage = global::NCKU_MAP.Properties.Resources.website_icon;
            this.pbxWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWebsite.Location = new System.Drawing.Point(11, 590);
            this.pbxWebsite.Name = "pbxWebsite";
            this.pbxWebsite.Size = new System.Drawing.Size(25, 25);
            this.pbxWebsite.TabIndex = 7;
            this.pbxWebsite.TabStop = false;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWebsite.Location = new System.Drawing.Point(42, 595);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(70, 20);
            this.lblWebsite.TabIndex = 6;
            this.lblWebsite.Text = "Website";
            // 
            // pbxAddress
            // 
            this.pbxAddress.BackgroundImage = global::NCKU_MAP.Properties.Resources.address_icon;
            this.pbxAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAddress.Location = new System.Drawing.Point(11, 561);
            this.pbxAddress.Name = "pbxAddress";
            this.pbxAddress.Size = new System.Drawing.Size(25, 25);
            this.pbxAddress.TabIndex = 5;
            this.pbxAddress.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(42, 566);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // tbxDescript
            // 
            this.tbxDescript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDescript.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxDescript.Location = new System.Drawing.Point(0, 379);
            this.tbxDescript.Multiline = true;
            this.tbxDescript.Name = "tbxDescript";
            this.tbxDescript.ReadOnly = true;
            this.tbxDescript.Size = new System.Drawing.Size(350, 176);
            this.tbxDescript.TabIndex = 3;
            // 
            // btnBookmark
            // 
            this.btnBookmark.BackColor = System.Drawing.Color.LightBlue;
            this.btnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookmark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBookmark.Location = new System.Drawing.Point(12, 333);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(40, 40);
            this.btnBookmark.TabIndex = 2;
            this.btnBookmark.Text = "標";
            this.btnBookmark.UseVisualStyleBackColor = false;
            this.btnBookmark.Click += new System.EventHandler(this.btnBookmark_Click);
            // 
            // pbxScene
            // 
            this.pbxScene.BackColor = System.Drawing.Color.DarkRed;
            this.pbxScene.Image = ((System.Drawing.Image)(resources.GetObject("pbxScene.Image")));
            this.pbxScene.Location = new System.Drawing.Point(0, 0);
            this.pbxScene.Name = "pbxScene";
            this.pbxScene.Size = new System.Drawing.Size(350, 239);
            this.pbxScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScene.TabIndex = 1;
            this.pbxScene.TabStop = false;
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScene.Location = new System.Drawing.Point(5, 251);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(166, 34);
            this.lblScene.TabIndex = 0;
            this.lblScene.Text = "SceneName";
            // 
            // lbxSearchBar
            // 
            this.lbxSearchBar.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxSearchBar.FormattingEnabled = true;
            this.lbxSearchBar.ItemHeight = 24;
            this.lbxSearchBar.Location = new System.Drawing.Point(55, 49);
            this.lbxSearchBar.Name = "lbxSearchBar";
            this.lbxSearchBar.Size = new System.Drawing.Size(280, 148);
            this.lbxSearchBar.TabIndex = 16;
            this.lbxSearchBar.Visible = false;
            // 
            // btnSide
            // 
            this.btnSide.BackColor = System.Drawing.Color.White;
            this.btnSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSide.Location = new System.Drawing.Point(348, 0);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(20, 45);
            this.btnSide.TabIndex = 4;
            this.btnSide.Text = "‹";
            this.btnSide.UseVisualStyleBackColor = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnAddScene
            // 
            this.btnAddScene.FlatAppearance.BorderSize = 0;
            this.btnAddScene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddScene.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddScene.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddScene.Location = new System.Drawing.Point(0, 80);
            this.btnAddScene.Name = "btnAddScene";
            this.btnAddScene.Size = new System.Drawing.Size(309, 70);
            this.btnAddScene.TabIndex = 5;
            this.btnAddScene.Text = "新增地點";
            this.btnAddScene.UseVisualStyleBackColor = true;
            this.btnAddScene.Click += new System.EventHandler(this.btnAddScene_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnfeedback);
            this.panel2.Controls.Add(this.btnclasstable);
            this.panel2.Controls.Add(this.btnsaved);
            this.panel2.Controls.Add(this.btnAddScene);
            this.panel2.Location = new System.Drawing.Point(740, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 680);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // btnclasstable
            // 
            this.btnclasstable.FlatAppearance.BorderSize = 0;
            this.btnclasstable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclasstable.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclasstable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclasstable.Location = new System.Drawing.Point(0, 220);
            this.btnclasstable.Name = "btnclasstable";
            this.btnclasstable.Size = new System.Drawing.Size(309, 70);
            this.btnclasstable.TabIndex = 2;
            this.btnclasstable.Text = "課表地圖";
            this.btnclasstable.UseVisualStyleBackColor = true;
            this.btnclasstable.Click += new System.EventHandler(this.btnclasstable_Click);
            // 
            // btnsaved
            // 
            this.btnsaved.FlatAppearance.BorderSize = 0;
            this.btnsaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaved.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsaved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsaved.Location = new System.Drawing.Point(0, 150);
            this.btnsaved.Name = "btnsaved";
            this.btnsaved.Size = new System.Drawing.Size(309, 70);
            this.btnsaved.TabIndex = 0;
            this.btnsaved.Text = "儲存點";
            this.btnsaved.UseVisualStyleBackColor = true;
            this.btnsaved.Click += new System.EventHandler(this.btnsaved_Click);
            // 
            // panlogo
            // 
            this.panlogo.BackColor = System.Drawing.Color.Goldenrod;
            this.panlogo.Controls.Add(this.btnclosesheet);
            this.panlogo.Controls.Add(this.lbltitle);
            this.panlogo.Controls.Add(this.pbxlogo);
            this.panlogo.Location = new System.Drawing.Point(740, 0);
            this.panlogo.Name = "panlogo";
            this.panlogo.Size = new System.Drawing.Size(309, 80);
            this.panlogo.TabIndex = 9;
            this.panlogo.Visible = false;
            // 
            // btnclosesheet
            // 
            this.btnclosesheet.FlatAppearance.BorderSize = 0;
            this.btnclosesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosesheet.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosesheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclosesheet.Location = new System.Drawing.Point(274, 0);
            this.btnclosesheet.Name = "btnclosesheet";
            this.btnclosesheet.Size = new System.Drawing.Size(35, 80);
            this.btnclosesheet.TabIndex = 2;
            this.btnclosesheet.Text = "<<";
            this.btnclosesheet.UseVisualStyleBackColor = true;
            this.btnclosesheet.Click += new System.EventHandler(this.btnclosesheet_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitle.Location = new System.Drawing.Point(66, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(180, 39);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "NCKU MAP";
            // 
            // pbxlogo
            // 
            this.pbxlogo.BackgroundImage = global::NCKU_MAP.Properties.Resources.NCKU_logo;
            this.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxlogo.Location = new System.Drawing.Point(14, 12);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(50, 50);
            this.pbxlogo.TabIndex = 0;
            this.pbxlogo.TabStop = false;
            // 
            // btnsheet
            // 
            this.btnsheet.BackgroundImage = global::NCKU_MAP.Properties.Resources.function_icon;
            this.btnsheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsheet.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnsheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnsheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsheet.Location = new System.Drawing.Point(20, 12);
            this.btnsheet.Name = "btnsheet";
            this.btnsheet.Size = new System.Drawing.Size(35, 35);
            this.btnsheet.TabIndex = 8;
            this.btnsheet.UseVisualStyleBackColor = true;
            this.btnsheet.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelNavigate
            // 
            this.panelNavigate.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelNavigate.Controls.Add(this.pictureBox1);
            this.panelNavigate.Controls.Add(this.btnNavigateFind);
            this.panelNavigate.Controls.Add(this.btncloseguide);
            this.panelNavigate.Controls.Add(this.lbxNavigate);
            this.panelNavigate.Controls.Add(this.tbxEnd);
            this.panelNavigate.Controls.Add(this.tbxStart);
            this.panelNavigate.Location = new System.Drawing.Point(384, 0);
            this.panelNavigate.Name = "panelNavigate";
            this.panelNavigate.Size = new System.Drawing.Size(350, 680);
            this.panelNavigate.TabIndex = 17;
            this.panelNavigate.Visible = false;
            // 
            // btnNavigateFind
            // 
            this.btnNavigateFind.BackColor = System.Drawing.Color.Lavender;
            this.btnNavigateFind.FlatAppearance.BorderSize = 0;
            this.btnNavigateFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigateFind.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigateFind.Location = new System.Drawing.Point(288, 102);
            this.btnNavigateFind.Name = "btnNavigateFind";
            this.btnNavigateFind.Size = new System.Drawing.Size(50, 50);
            this.btnNavigateFind.TabIndex = 4;
            this.btnNavigateFind.Text = "Go";
            this.btnNavigateFind.UseVisualStyleBackColor = false;
            this.btnNavigateFind.Click += new System.EventHandler(this.btnNavigateFind_Click);
            // 
            // btncloseguide
            // 
            this.btncloseguide.FlatAppearance.BorderSize = 0;
            this.btncloseguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseguide.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseguide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncloseguide.Location = new System.Drawing.Point(300, 0);
            this.btncloseguide.Name = "btncloseguide";
            this.btncloseguide.Size = new System.Drawing.Size(50, 50);
            this.btncloseguide.TabIndex = 3;
            this.btncloseguide.Text = "X";
            this.btncloseguide.UseVisualStyleBackColor = true;
            this.btncloseguide.Click += new System.EventHandler(this.btncloseguide_Click);
            // 
            // lbxNavigate
            // 
            this.lbxNavigate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxNavigate.FormattingEnabled = true;
            this.lbxNavigate.ItemHeight = 17;
            this.lbxNavigate.Location = new System.Drawing.Point(67, 145);
            this.lbxNavigate.Name = "lbxNavigate";
            this.lbxNavigate.Size = new System.Drawing.Size(212, 123);
            this.lbxNavigate.TabIndex = 2;
            this.lbxNavigate.Visible = false;
            // 
            // tbxEnd
            // 
            this.tbxEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxEnd.Location = new System.Drawing.Point(67, 110);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(212, 29);
            this.tbxEnd.TabIndex = 1;
            this.tbxEnd.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxStart_KeyDown);
            this.tbxEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // tbxStart
            // 
            this.tbxStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxStart.Location = new System.Drawing.Point(67, 55);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(212, 29);
            this.tbxStart.TabIndex = 0;
            this.tbxStart.Text = "起始地點";
            this.tbxStart.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxStart_KeyDown);
            this.tbxStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // panelStoreList
            // 
            this.panelStoreList.BackColor = System.Drawing.Color.SteelBlue;
            this.panelStoreList.Controls.Add(this.lblStoreList);
            this.panelStoreList.Controls.Add(this.lbxStorelist);
            this.panelStoreList.Controls.Add(this.btnStoreClose);
            this.panelStoreList.Location = new System.Drawing.Point(372, 0);
            this.panelStoreList.Name = "panelStoreList";
            this.panelStoreList.Size = new System.Drawing.Size(350, 680);
            this.panelStoreList.TabIndex = 18;
            this.panelStoreList.Visible = false;
            // 
            // lblStoreList
            // 
            this.lblStoreList.AutoSize = true;
            this.lblStoreList.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStoreList.Location = new System.Drawing.Point(23, 25);
            this.lblStoreList.Name = "lblStoreList";
            this.lblStoreList.Size = new System.Drawing.Size(96, 34);
            this.lblStoreList.TabIndex = 5;
            this.lblStoreList.Text = "儲存點";
            // 
            // lbxStorelist
            // 
            this.lbxStorelist.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxStorelist.FormattingEnabled = true;
            this.lbxStorelist.ItemHeight = 27;
            this.lbxStorelist.Location = new System.Drawing.Point(28, 80);
            this.lbxStorelist.Name = "lbxStorelist";
            this.lbxStorelist.Size = new System.Drawing.Size(297, 517);
            this.lbxStorelist.TabIndex = 4;
            this.lbxStorelist.SelectedIndexChanged += new System.EventHandler(this.lbxStorelist_SelectedIndexChanged);
            // 
            // btnStoreClose
            // 
            this.btnStoreClose.FlatAppearance.BorderSize = 0;
            this.btnStoreClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreClose.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStoreClose.Location = new System.Drawing.Point(300, 0);
            this.btnStoreClose.Name = "btnStoreClose";
            this.btnStoreClose.Size = new System.Drawing.Size(50, 50);
            this.btnStoreClose.TabIndex = 3;
            this.btnStoreClose.Text = "X";
            this.btnStoreClose.UseVisualStyleBackColor = true;
            this.btnStoreClose.Click += new System.EventHandler(this.btnStoreClose_Click);
            // 
            // btnfeedback
            // 
            this.btnfeedback.FlatAppearance.BorderSize = 0;
            this.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfeedback.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnfeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfeedback.Location = new System.Drawing.Point(0, 613);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(309, 70);
            this.btnfeedback.TabIndex = 3;
            this.btnfeedback.Text = "意見回饋";
            this.btnfeedback.UseVisualStyleBackColor = true;
            this.btnfeedback.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NCKU_MAP.Properties.Resources.NCKU_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelStoreList);
            this.Controls.Add(this.lbxSearchBar);
            this.Controls.Add(this.panelNavigate);
            this.Controls.Add(this.panlogo);
            this.Controls.Add(this.btnsheet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScene)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panlogo.ResumeLayout(false);
            this.panlogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.panelNavigate.ResumeLayout(false);
            this.panelNavigate.PerformLayout();
            this.panelStoreList.ResumeLayout(false);
            this.panelStoreList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScene;
        private System.Windows.Forms.Button btnBookmark;
        private System.Windows.Forms.PictureBox pbxScene;
        private System.Windows.Forms.PictureBox pbxOpenTime;
        private System.Windows.Forms.Label lblOpenTime;
        private System.Windows.Forms.PictureBox pbxPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.PictureBox pbxWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.PictureBox pbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxDescript;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBookMark;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Button btnAddScene;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsheet;
        private System.Windows.Forms.Panel panlogo;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnclosesheet;
        private System.Windows.Forms.Button btnclasstable;
        private System.Windows.Forms.Button btnsaved;
        private System.Windows.Forms.Button btnguide;
        private System.Windows.Forms.ListBox lbxSearchBar;
        private System.Windows.Forms.Panel panelNavigate;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.ListBox lbxNavigate;
        private System.Windows.Forms.Button btncloseguide;
        private System.Windows.Forms.Button btnNavigateFind;
        private System.Windows.Forms.Panel panelStoreList;
        private System.Windows.Forms.ListBox lbxStorelist;
        private System.Windows.Forms.Button btnStoreClose;
        private System.Windows.Forms.Label lblStoreList;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnfeedback;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

