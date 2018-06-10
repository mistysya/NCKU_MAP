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
            this.components = new System.ComponentModel.Container();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBookMark = new System.Windows.Forms.Label();
            this.lblOpenTime = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxDescript = new System.Windows.Forms.TextBox();
            this.btnBookmark = new System.Windows.Forms.Button();
            this.lblScene = new System.Windows.Forms.Label();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnAddScene = new System.Windows.Forms.Button();
            this.btnguide = new System.Windows.Forms.Button();
            this.btnlocate = new System.Windows.Forms.Button();
            this.btnstar = new System.Windows.Forms.Button();
            this.pbxOpenTime = new System.Windows.Forms.PictureBox();
            this.pbxPhoneNum = new System.Windows.Forms.PictureBox();
            this.pbxWebsite = new System.Windows.Forms.PictureBox();
            this.pbxAddress = new System.Windows.Forms.PictureBox();
            this.pbxScene = new System.Windows.Forms.PictureBox();
            this.mapInfoDataSet = new NCKU_MAP.MapInfoDataSet();
            this.sceneInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sceneInfoTableAdapter = new NCKU_MAP.MapInfoDataSetTableAdapters.SceneInfoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Location = new System.Drawing.Point(566, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(331, 35);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.Text = "搜尋地點";
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
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
            this.panel1.Controls.Add(this.btnlocate);
            this.panel1.Controls.Add(this.btnstar);
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(13, 320);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblBookMark
            // 
            this.lblBookMark.AutoSize = true;
            this.lblBookMark.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookMark.Location = new System.Drawing.Point(74, 367);
            this.lblBookMark.Name = "lblBookMark";
            this.lblBookMark.Size = new System.Drawing.Size(48, 24);
            this.lblBookMark.TabIndex = 12;
            this.lblBookMark.Text = "標記";
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
            this.tbxDescript.Location = new System.Drawing.Point(0, 406);
            this.tbxDescript.Multiline = true;
            this.tbxDescript.Name = "tbxDescript";
            this.tbxDescript.ReadOnly = true;
            this.tbxDescript.Size = new System.Drawing.Size(350, 148);
            this.tbxDescript.TabIndex = 3;
            // 
            // btnBookmark
            // 
            this.btnBookmark.BackColor = System.Drawing.Color.LightBlue;
            this.btnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookmark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBookmark.Location = new System.Drawing.Point(13, 357);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(40, 40);
            this.btnBookmark.TabIndex = 2;
            this.btnBookmark.Text = "標";
            this.btnBookmark.UseVisualStyleBackColor = false;
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScene.Location = new System.Drawing.Point(7, 282);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(166, 34);
            this.lblScene.TabIndex = 0;
            this.lblScene.Text = "SceneName";
            // 
            // btnSide
            // 
            this.btnSide.BackColor = System.Drawing.Color.White;
            this.btnSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSide.Location = new System.Drawing.Point(348, 0);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(19, 47);
            this.btnSide.TabIndex = 4;
            this.btnSide.Text = "‹";
            this.btnSide.UseVisualStyleBackColor = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnAddScene
            // 
            this.btnAddScene.Location = new System.Drawing.Point(913, 12);
            this.btnAddScene.Name = "btnAddScene";
            this.btnAddScene.Size = new System.Drawing.Size(80, 35);
            this.btnAddScene.TabIndex = 5;
            this.btnAddScene.Text = "新增地點";
            this.btnAddScene.UseVisualStyleBackColor = true;
            this.btnAddScene.Click += new System.EventHandler(this.btnAddScene_Click);
            // 
            // btnguide
            // 
            this.btnguide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(236)))));
            this.btnguide.FlatAppearance.BorderSize = 0;
            this.btnguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguide.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnguide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguide.Image = global::NCKU_MAP.Properties.Resources.guide_icon;
            this.btnguide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguide.Location = new System.Drawing.Point(233, 0);
            this.btnguide.Name = "btnguide";
            this.btnguide.Size = new System.Drawing.Size(117, 100);
            this.btnguide.TabIndex = 16;
            this.btnguide.Text = "導航";
            this.btnguide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguide.UseVisualStyleBackColor = false;
            // 
            // btnlocate
            // 
            this.btnlocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(236)))));
            this.btnlocate.FlatAppearance.BorderSize = 0;
            this.btnlocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnlocate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlocate.Image = global::NCKU_MAP.Properties.Resources.locate_icon;
            this.btnlocate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlocate.Location = new System.Drawing.Point(117, 0);
            this.btnlocate.Name = "btnlocate";
            this.btnlocate.Size = new System.Drawing.Size(116, 100);
            this.btnlocate.TabIndex = 15;
            this.btnlocate.Text = "定位";
            this.btnlocate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlocate.UseVisualStyleBackColor = false;
            // 
            // btnstar
            // 
            this.btnstar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(236)))));
            this.btnstar.FlatAppearance.BorderSize = 0;
            this.btnstar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnstar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstar.Image = global::NCKU_MAP.Properties.Resources.star_icon;
            this.btnstar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnstar.Location = new System.Drawing.Point(0, 0);
            this.btnstar.Name = "btnstar";
            this.btnstar.Size = new System.Drawing.Size(117, 100);
            this.btnstar.TabIndex = 14;
            this.btnstar.Text = "儲存點";
            this.btnstar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstar.UseVisualStyleBackColor = false;
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
            // pbxScene
            // 
            this.pbxScene.BackColor = System.Drawing.Color.DarkRed;
            this.pbxScene.Location = new System.Drawing.Point(0, 100);
            this.pbxScene.Name = "pbxScene";
            this.pbxScene.Size = new System.Drawing.Size(350, 180);
            this.pbxScene.TabIndex = 1;
            this.pbxScene.TabStop = false;
            // 
            // mapInfoDataSet
            // 
            this.mapInfoDataSet.DataSetName = "MapInfoDataSet";
            this.mapInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sceneInfoBindingSource
            // 
            this.sceneInfoBindingSource.DataMember = "SceneInfo";
            this.sceneInfoBindingSource.DataSource = this.mapInfoDataSet;
            // 
            // sceneInfoTableAdapter
            // 
            this.sceneInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAddScene);
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
            ((System.ComponentModel.ISupportInitialize)(this.mapInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
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
        private System.Windows.Forms.Button btnstar;
        private System.Windows.Forms.Button btnguide;
        private System.Windows.Forms.Button btnlocate;
        private MapInfoDataSet mapInfoDataSet;
        private System.Windows.Forms.BindingSource sceneInfoBindingSource;
        private MapInfoDataSetTableAdapters.SceneInfoTableAdapter sceneInfoTableAdapter;
    }
}

