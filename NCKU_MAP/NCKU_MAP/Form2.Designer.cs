﻿namespace NCKU_MAP
{
    partial class Form2
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
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLng = new System.Windows.Forms.Label();
            this.tbxLat = new System.Windows.Forms.TextBox();
            this.tbxLng = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.tbxPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxOpenTime = new System.Windows.Forms.TextBox();
            this.lblOpenTime = new System.Windows.Forms.Label();
            this.tbxDescript = new System.Windows.Forms.TextBox();
            this.lblDescript = new System.Windows.Forms.Label();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.tbxImgPath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneDescriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findKeywordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapInfoDataSet1 = new NCKU_MAP.MapInfoDataSet1();
            this.sceneInfoTableAdapter = new NCKU_MAP.MapInfoDataSet1TableAdapters.SceneInfoTableAdapter();
            this.btnDeleteFromDatabase = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapInfoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLat.Location = new System.Drawing.Point(6, 10);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(57, 20);
            this.lblLat.TabIndex = 0;
            this.lblLat.Text = "緯度：";
            // 
            // lblLng
            // 
            this.lblLng.AutoSize = true;
            this.lblLng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLng.Location = new System.Drawing.Point(6, 38);
            this.lblLng.Name = "lblLng";
            this.lblLng.Size = new System.Drawing.Size(57, 20);
            this.lblLng.TabIndex = 1;
            this.lblLng.Text = "經度：";
            // 
            // tbxLat
            // 
            this.tbxLat.Location = new System.Drawing.Point(69, 8);
            this.tbxLat.Name = "tbxLat";
            this.tbxLat.Size = new System.Drawing.Size(100, 22);
            this.tbxLat.TabIndex = 2;
            // 
            // tbxLng
            // 
            this.tbxLng.Location = new System.Drawing.Point(69, 36);
            this.tbxLng.Name = "tbxLng";
            this.tbxLng.Size = new System.Drawing.Size(100, 22);
            this.tbxLng.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(69, 92);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(6, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "名稱：";
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(69, 120);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(100, 22);
            this.tbxType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(6, 122);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 20);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "類別：";
            // 
            // tbxWebsite
            // 
            this.tbxWebsite.Location = new System.Drawing.Point(69, 148);
            this.tbxWebsite.Name = "tbxWebsite";
            this.tbxWebsite.Size = new System.Drawing.Size(100, 22);
            this.tbxWebsite.TabIndex = 9;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWebsite.Location = new System.Drawing.Point(6, 150);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(57, 20);
            this.lblWebsite.TabIndex = 8;
            this.lblWebsite.Text = "網址：";
            // 
            // tbxPhoneNum
            // 
            this.tbxPhoneNum.Location = new System.Drawing.Point(69, 176);
            this.tbxPhoneNum.Name = "tbxPhoneNum";
            this.tbxPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.tbxPhoneNum.TabIndex = 11;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhoneNum.Location = new System.Drawing.Point(6, 178);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(57, 20);
            this.lblPhoneNum.TabIndex = 10;
            this.lblPhoneNum.Text = "電話：";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(69, 232);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(132, 22);
            this.tbxAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(6, 234);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 20);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "地址：";
            // 
            // tbxOpenTime
            // 
            this.tbxOpenTime.Location = new System.Drawing.Point(101, 204);
            this.tbxOpenTime.Name = "tbxOpenTime";
            this.tbxOpenTime.Size = new System.Drawing.Size(100, 22);
            this.tbxOpenTime.TabIndex = 15;
            // 
            // lblOpenTime
            // 
            this.lblOpenTime.AutoSize = true;
            this.lblOpenTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOpenTime.Location = new System.Drawing.Point(6, 204);
            this.lblOpenTime.Name = "lblOpenTime";
            this.lblOpenTime.Size = new System.Drawing.Size(89, 20);
            this.lblOpenTime.TabIndex = 14;
            this.lblOpenTime.Text = "營業時間：";
            // 
            // tbxDescript
            // 
            this.tbxDescript.Location = new System.Drawing.Point(69, 260);
            this.tbxDescript.Multiline = true;
            this.tbxDescript.Name = "tbxDescript";
            this.tbxDescript.Size = new System.Drawing.Size(132, 82);
            this.tbxDescript.TabIndex = 17;
            // 
            // lblDescript
            // 
            this.lblDescript.AutoSize = true;
            this.lblDescript.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescript.Location = new System.Drawing.Point(6, 262);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(57, 20);
            this.lblDescript.TabIndex = 16;
            this.lblDescript.Text = "描述：";
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Location = new System.Drawing.Point(12, 407);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDatabase.TabIndex = 18;
            this.btnAddToDatabase.Text = "確定新增";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            this.btnAddToDatabase.Click += new System.EventHandler(this.btnAddToDatabase_Click);
            // 
            // lblImgPath
            // 
            this.lblImgPath.AutoSize = true;
            this.lblImgPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblImgPath.Location = new System.Drawing.Point(6, 348);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(201, 20);
            this.lblImgPath.TabIndex = 19;
            this.lblImgPath.Text = "圖片路徑：(Fromfile(@\"\"))";
            // 
            // tbxImgPath
            // 
            this.tbxImgPath.Location = new System.Drawing.Point(12, 371);
            this.tbxImgPath.Name = "tbxImgPath";
            this.tbxImgPath.Size = new System.Drawing.Size(189, 22);
            this.tbxImgPath.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapIDDataGridViewTextBoxColumn,
            this.sceneNameDataGridViewTextBoxColumn,
            this.sceneTypeDataGridViewTextBoxColumn,
            this.isMarkDataGridViewTextBoxColumn,
            this.sceneDescriptDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.openTimeDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn,
            this.findKeywordDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sceneInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(216, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 422);
            this.dataGridView1.TabIndex = 21;
            // 
            // mapIDDataGridViewTextBoxColumn
            // 
            this.mapIDDataGridViewTextBoxColumn.DataPropertyName = "mapID";
            this.mapIDDataGridViewTextBoxColumn.HeaderText = "mapID";
            this.mapIDDataGridViewTextBoxColumn.Name = "mapIDDataGridViewTextBoxColumn";
            // 
            // sceneNameDataGridViewTextBoxColumn
            // 
            this.sceneNameDataGridViewTextBoxColumn.DataPropertyName = "SceneName";
            this.sceneNameDataGridViewTextBoxColumn.HeaderText = "SceneName";
            this.sceneNameDataGridViewTextBoxColumn.Name = "sceneNameDataGridViewTextBoxColumn";
            // 
            // sceneTypeDataGridViewTextBoxColumn
            // 
            this.sceneTypeDataGridViewTextBoxColumn.DataPropertyName = "SceneType";
            this.sceneTypeDataGridViewTextBoxColumn.HeaderText = "SceneType";
            this.sceneTypeDataGridViewTextBoxColumn.Name = "sceneTypeDataGridViewTextBoxColumn";
            // 
            // isMarkDataGridViewTextBoxColumn
            // 
            this.isMarkDataGridViewTextBoxColumn.DataPropertyName = "IsMark";
            this.isMarkDataGridViewTextBoxColumn.HeaderText = "IsMark";
            this.isMarkDataGridViewTextBoxColumn.Name = "isMarkDataGridViewTextBoxColumn";
            // 
            // sceneDescriptDataGridViewTextBoxColumn
            // 
            this.sceneDescriptDataGridViewTextBoxColumn.DataPropertyName = "SceneDescript";
            this.sceneDescriptDataGridViewTextBoxColumn.HeaderText = "SceneDescript";
            this.sceneDescriptDataGridViewTextBoxColumn.Name = "sceneDescriptDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // openTimeDataGridViewTextBoxColumn
            // 
            this.openTimeDataGridViewTextBoxColumn.DataPropertyName = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.HeaderText = "OpenTime";
            this.openTimeDataGridViewTextBoxColumn.Name = "openTimeDataGridViewTextBoxColumn";
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            // 
            // findKeywordDataGridViewTextBoxColumn
            // 
            this.findKeywordDataGridViewTextBoxColumn.DataPropertyName = "FindKeyword";
            this.findKeywordDataGridViewTextBoxColumn.HeaderText = "FindKeyword";
            this.findKeywordDataGridViewTextBoxColumn.Name = "findKeywordDataGridViewTextBoxColumn";
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            // 
            // sceneInfoBindingSource
            // 
            this.sceneInfoBindingSource.DataMember = "SceneInfo";
            this.sceneInfoBindingSource.DataSource = this.mapInfoDataSet1;
            // 
            // mapInfoDataSet1
            // 
            this.mapInfoDataSet1.DataSetName = "MapInfoDataSet1";
            this.mapInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sceneInfoTableAdapter
            // 
            this.sceneInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteFromDatabase
            // 
            this.btnDeleteFromDatabase.Location = new System.Drawing.Point(126, 407);
            this.btnDeleteFromDatabase.Name = "btnDeleteFromDatabase";
            this.btnDeleteFromDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFromDatabase.TabIndex = 22;
            this.btnDeleteFromDatabase.Text = "刪除";
            this.btnDeleteFromDatabase.UseVisualStyleBackColor = true;
            this.btnDeleteFromDatabase.Click += new System.EventHandler(this.btnDeleteFromDatabase_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(6, 66);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(57, 20);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "編號：";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(69, 64);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 22);
            this.tbxID.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDeleteFromDatabase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxImgPath);
            this.Controls.Add(this.lblImgPath);
            this.Controls.Add(this.btnAddToDatabase);
            this.Controls.Add(this.tbxDescript);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.tbxOpenTime);
            this.Controls.Add(this.lblOpenTime);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxPhoneNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.tbxWebsite);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxLng);
            this.Controls.Add(this.tbxLat);
            this.Controls.Add(this.lblLng);
            this.Controls.Add(this.lblLat);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapInfoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLng;
        private System.Windows.Forms.TextBox tbxLat;
        private System.Windows.Forms.TextBox tbxLng;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbxWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox tbxPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxOpenTime;
        private System.Windows.Forms.Label lblOpenTime;
        private System.Windows.Forms.TextBox tbxDescript;
        private System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Button btnAddToDatabase;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.TextBox tbxImgPath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MapInfoDataSet1 mapInfoDataSet1;
        private System.Windows.Forms.BindingSource sceneInfoBindingSource;
        private MapInfoDataSet1TableAdapters.SceneInfoTableAdapter sceneInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceneDescriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn findKeywordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteFromDatabase;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxID;
    }
}