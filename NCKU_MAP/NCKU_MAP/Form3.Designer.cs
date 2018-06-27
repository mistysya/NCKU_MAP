namespace NCKU_MAP
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblplace = new System.Windows.Forms.Label();
            this.tbxclass = new System.Windows.Forms.TextBox();
            this.tbxplace = new System.Windows.Forms.TextBox();
            this.gbxnewclass = new System.Windows.Forms.GroupBox();
            this.btndelclass = new System.Windows.Forms.Button();
            this.lbxClassLocate = new System.Windows.Forms.ListBox();
            this.btnbackcolor = new System.Windows.Forms.Button();
            this.btnsaveclass = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxnewclass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 711);
            this.panel1.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndelete.Location = new System.Drawing.Point(0, 160);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(180, 50);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "刪除課表";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnview
            // 
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnview.Location = new System.Drawing.Point(0, 110);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(180, 50);
            this.btnview.TabIndex = 2;
            this.btnview.Text = "檢視課表";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnnew
            // 
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnnew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnnew.Location = new System.Drawing.Point(0, 60);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(180, 50);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "編輯課表";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 60);
            this.panel2.TabIndex = 0;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitle.Location = new System.Drawing.Point(30, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(123, 35);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "課表地圖";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblclass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblclass.Location = new System.Drawing.Point(16, 42);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(105, 24);
            this.lblclass.TabIndex = 3;
            this.lblclass.Text = "課程名稱：";
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblplace.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblplace.Location = new System.Drawing.Point(16, 115);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(105, 24);
            this.lblplace.TabIndex = 4;
            this.lblplace.Text = "課程地點：";
            // 
            // tbxclass
            // 
            this.tbxclass.Location = new System.Drawing.Point(20, 70);
            this.tbxclass.Name = "tbxclass";
            this.tbxclass.Size = new System.Drawing.Size(165, 29);
            this.tbxclass.TabIndex = 6;
            // 
            // tbxplace
            // 
            this.tbxplace.Location = new System.Drawing.Point(20, 142);
            this.tbxplace.Name = "tbxplace";
            this.tbxplace.Size = new System.Drawing.Size(165, 29);
            this.tbxplace.TabIndex = 7;
            this.tbxplace.TextChanged += new System.EventHandler(this.tbxplace_TextChanged);
            this.tbxplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxplace_KeyDown);
            this.tbxplace.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxplace_KeyUp);
            // 
            // gbxnewclass
            // 
            this.gbxnewclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbxnewclass.Controls.Add(this.btndelclass);
            this.gbxnewclass.Controls.Add(this.lbxClassLocate);
            this.gbxnewclass.Controls.Add(this.btnbackcolor);
            this.gbxnewclass.Controls.Add(this.btnsaveclass);
            this.gbxnewclass.Controls.Add(this.lblclass);
            this.gbxnewclass.Controls.Add(this.tbxclass);
            this.gbxnewclass.Controls.Add(this.lblplace);
            this.gbxnewclass.Controls.Add(this.tbxplace);
            this.gbxnewclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxnewclass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxnewclass.Location = new System.Drawing.Point(875, 160);
            this.gbxnewclass.Name = "gbxnewclass";
            this.gbxnewclass.Size = new System.Drawing.Size(203, 338);
            this.gbxnewclass.TabIndex = 10;
            this.gbxnewclass.TabStop = false;
            this.gbxnewclass.Text = "新增課程";
            this.gbxnewclass.Visible = false;
            // 
            // btndelclass
            // 
            this.btndelclass.FlatAppearance.BorderSize = 0;
            this.btndelclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelclass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelclass.Location = new System.Drawing.Point(101, 283);
            this.btndelclass.Name = "btndelclass";
            this.btndelclass.Size = new System.Drawing.Size(45, 45);
            this.btndelclass.TabIndex = 12;
            this.btndelclass.Text = "Del";
            this.btndelclass.UseVisualStyleBackColor = true;
            this.btndelclass.Click += new System.EventHandler(this.btndelclass_Click);
            // 
            // lbxClassLocate
            // 
            this.lbxClassLocate.FormattingEnabled = true;
            this.lbxClassLocate.ItemHeight = 20;
            this.lbxClassLocate.Location = new System.Drawing.Point(20, 177);
            this.lbxClassLocate.Name = "lbxClassLocate";
            this.lbxClassLocate.Size = new System.Drawing.Size(165, 64);
            this.lbxClassLocate.TabIndex = 11;
            this.lbxClassLocate.Visible = false;
            // 
            // btnbackcolor
            // 
            this.btnbackcolor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbackcolor.FlatAppearance.BorderSize = 2;
            this.btnbackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackcolor.Location = new System.Drawing.Point(20, 247);
            this.btnbackcolor.Name = "btnbackcolor";
            this.btnbackcolor.Size = new System.Drawing.Size(165, 30);
            this.btnbackcolor.TabIndex = 10;
            this.btnbackcolor.Text = "自訂背景色";
            this.btnbackcolor.UseVisualStyleBackColor = true;
            this.btnbackcolor.Click += new System.EventHandler(this.btnbackcolor_Click);
            // 
            // btnsaveclass
            // 
            this.btnsaveclass.FlatAppearance.BorderSize = 0;
            this.btnsaveclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveclass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveclass.Location = new System.Drawing.Point(152, 283);
            this.btnsaveclass.Name = "btnsaveclass";
            this.btnsaveclass.Size = new System.Drawing.Size(45, 45);
            this.btnsaveclass.TabIndex = 9;
            this.btnsaveclass.Text = "OK!";
            this.btnsaveclass.UseVisualStyleBackColor = true;
            this.btnsaveclass.Click += new System.EventHandler(this.btnsaveclass_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1087, 711);
            this.Controls.Add(this.gbxnewclass);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxnewclass.ResumeLayout(false);
            this.gbxnewclass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.TextBox tbxclass;
        private System.Windows.Forms.TextBox tbxplace;
        private System.Windows.Forms.GroupBox gbxnewclass;
        private System.Windows.Forms.Button btnsaveclass;
        private System.Windows.Forms.Button btnbackcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lbxClassLocate;
        private System.Windows.Forms.Button btndelclass;
    }
}