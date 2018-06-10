namespace Google_Maps_CS
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelicon = new System.Windows.Forms.Panel();
            this.btnlocate = new System.Windows.Forms.Button();
            this.btnstar = new System.Windows.Forms.Button();
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
            this.btnSide = new System.Windows.Forms.Button();
            this.btnguide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelicon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScene)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Location = new System.Drawing.Point(532, 15);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(293, 35);
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
            this.panel1.Controls.Add(this.panelicon);
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
            this.panel1.Size = new System.Drawing.Size(368, 680);
            this.panel1.TabIndex = 3;
            // 
            // panelicon
            // 
            this.panelicon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelicon.Controls.Add(this.btnguide);
            this.panelicon.Controls.Add(this.btnlocate);
            this.panelicon.Controls.Add(this.btnstar);
            this.panelicon.Location = new System.Drawing.Point(0, 1);
            this.panelicon.Name = "panelicon";
            this.panelicon.Size = new System.Drawing.Size(368, 105);
            this.panelicon.TabIndex = 5;
            // 
            // btnlocate
            // 
            this.btnlocate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnlocate.FlatAppearance.BorderSize = 0;
            this.btnlocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnlocate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlocate.Image = global::NCKU_MAP.Properties.Resources.locate_icon;
            this.btnlocate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlocate.Location = new System.Drawing.Point(123, 0);
            this.btnlocate.Name = "btnlocate";
            this.btnlocate.Size = new System.Drawing.Size(123, 105);
            this.btnlocate.TabIndex = 1;
            this.btnlocate.Text = "定位";
            this.btnlocate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlocate.UseVisualStyleBackColor = true;
            // 
            // btnstar
            // 
            this.btnstar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnstar.FlatAppearance.BorderSize = 0;
            this.btnstar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstar.Image = global::NCKU_MAP.Properties.Resources.star_icon;
            this.btnstar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnstar.Location = new System.Drawing.Point(0, 0);
            this.btnstar.Name = "btnstar";
            this.btnstar.Size = new System.Drawing.Size(123, 105);
            this.btnstar.TabIndex = 0;
            this.btnstar.Text = "儲存點";
            this.btnstar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstar.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(13, 313);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblBookMark
            // 
            this.lblBookMark.AutoSize = true;
            this.lblBookMark.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookMark.Location = new System.Drawing.Point(74, 360);
            this.lblBookMark.Name = "lblBookMark";
            this.lblBookMark.Size = new System.Drawing.Size(48, 24);
            this.lblBookMark.TabIndex = 12;
            this.lblBookMark.Text = "標記";
            // 
            // pbxOpenTime
            // 
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
            this.tbxDescript.Location = new System.Drawing.Point(0, 399);
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
            this.btnBookmark.Location = new System.Drawing.Point(13, 350);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(40, 40);
            this.btnBookmark.TabIndex = 2;
            this.btnBookmark.Text = "標";
            this.btnBookmark.UseVisualStyleBackColor = false;
            // 
            // pbxScene
            // 
            this.pbxScene.BackColor = System.Drawing.Color.DarkRed;
            this.pbxScene.Location = new System.Drawing.Point(0, 104);
            this.pbxScene.Name = "pbxScene";
            this.pbxScene.Size = new System.Drawing.Size(368, 168);
            this.pbxScene.TabIndex = 1;
            this.pbxScene.TabStop = false;
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScene.Location = new System.Drawing.Point(7, 275);
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
            this.btnSide.Location = new System.Drawing.Point(366, 0);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(19, 64);
            this.btnSide.TabIndex = 4;
            this.btnSide.Text = "‹";
            this.btnSide.UseVisualStyleBackColor = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnguide
            // 
            this.btnguide.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnguide.FlatAppearance.BorderSize = 0;
            this.btnguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguide.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnguide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguide.Image = global::NCKU_MAP.Properties.Resources.guide_icon;
            this.btnguide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguide.Location = new System.Drawing.Point(246, 0);
            this.btnguide.Name = "btnguide";
            this.btnguide.Size = new System.Drawing.Size(122, 105);
            this.btnguide.TabIndex = 2;
            this.btnguide.Text = "導航";
            this.btnguide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelicon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScene)).EndInit();
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
        private System.Windows.Forms.Panel panelicon;
        private System.Windows.Forms.Button btnstar;
        private System.Windows.Forms.Button btnlocate;
        private System.Windows.Forms.Button btnguide;
    }
}

