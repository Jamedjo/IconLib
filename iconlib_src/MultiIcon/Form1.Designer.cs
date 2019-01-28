namespace MultiIconTester
{
    partial class FormIconBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIconBrowser));
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.dlgBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.lblIcons = new System.Windows.Forms.Label();
            this.lbxIcons = new System.Windows.Forms.ListBox();
            this.lblImages = new System.Windows.Forms.Label();
            this.lbxImages = new System.Windows.Forms.ListBox();
            this.pbxXORImage = new System.Windows.Forms.PictureBox();
            this.lblXORImage = new System.Windows.Forms.Label();
            this.lblAndImage = new System.Windows.Forms.Label();
            this.pbxANDImage = new System.Windows.Forms.PictureBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.gbxFiles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblColorDepth = new System.Windows.Forms.Label();
            this.lblCompression = new System.Windows.Forms.Label();
            this.gbxImageInfo = new System.Windows.Forms.GroupBox();
            this.lblCompressionValue = new System.Windows.Forms.Label();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblColorDepthValue = new System.Windows.Forms.Label();
            this.lblWidthValue = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExportBMP = new System.Windows.Forms.Button();
            this.btnExportAND = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXORImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxANDImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.gbxFiles.SuspendLayout();
            this.gbxImageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(11, 32);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(170, 121);
            this.lbxFiles.TabIndex = 2;
            this.lbxFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFiles_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(106, 159);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(8, 16);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(33, 13);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "Files";
            // 
            // lblIcons
            // 
            this.lblIcons.AutoSize = true;
            this.lblIcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcons.Location = new System.Drawing.Point(184, 16);
            this.lblIcons.Name = "lblIcons";
            this.lblIcons.Size = new System.Drawing.Size(38, 13);
            this.lblIcons.TabIndex = 6;
            this.lblIcons.Text = "Icons";
            // 
            // lbxIcons
            // 
            this.lbxIcons.FormattingEnabled = true;
            this.lbxIcons.Location = new System.Drawing.Point(187, 32);
            this.lbxIcons.Name = "lbxIcons";
            this.lbxIcons.Size = new System.Drawing.Size(170, 121);
            this.lbxIcons.TabIndex = 5;
            this.lbxIcons.SelectedIndexChanged += new System.EventHandler(this.lbxIcons_SelectedIndexChanged);
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImages.Location = new System.Drawing.Point(360, 16);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(47, 13);
            this.lblImages.TabIndex = 8;
            this.lblImages.Text = "Images";
            // 
            // lbxImages
            // 
            this.lbxImages.FormattingEnabled = true;
            this.lbxImages.Location = new System.Drawing.Point(363, 32);
            this.lbxImages.Name = "lbxImages";
            this.lbxImages.Size = new System.Drawing.Size(188, 121);
            this.lbxImages.TabIndex = 7;
            this.lbxImages.SelectedIndexChanged += new System.EventHandler(this.lbxImages_SelectedIndexChanged);
            // 
            // pbxXORImage
            // 
            this.pbxXORImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxXORImage.Location = new System.Drawing.Point(12, 221);
            this.pbxXORImage.Name = "pbxXORImage";
            this.pbxXORImage.Size = new System.Drawing.Size(256, 256);
            this.pbxXORImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxXORImage.TabIndex = 9;
            this.pbxXORImage.TabStop = false;
            // 
            // lblXORImage
            // 
            this.lblXORImage.AutoSize = true;
            this.lblXORImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXORImage.Location = new System.Drawing.Point(9, 205);
            this.lblXORImage.Name = "lblXORImage";
            this.lblXORImage.Size = new System.Drawing.Size(71, 13);
            this.lblXORImage.TabIndex = 10;
            this.lblXORImage.Text = "XOR Image";
            // 
            // lblAndImage
            // 
            this.lblAndImage.AutoSize = true;
            this.lblAndImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndImage.Location = new System.Drawing.Point(271, 205);
            this.lblAndImage.Name = "lblAndImage";
            this.lblAndImage.Size = new System.Drawing.Size(71, 13);
            this.lblAndImage.TabIndex = 12;
            this.lblAndImage.Text = "AND Image";
            // 
            // pbxANDImage
            // 
            this.pbxANDImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxANDImage.Location = new System.Drawing.Point(274, 221);
            this.pbxANDImage.Name = "pbxANDImage";
            this.pbxANDImage.Size = new System.Drawing.Size(256, 256);
            this.pbxANDImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxANDImage.TabIndex = 11;
            this.pbxANDImage.TabStop = false;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Location = new System.Drawing.Point(533, 205);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(70, 13);
            this.lblIcon.TabIndex = 14;
            this.lblIcon.Text = "Icon Image";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxIcon.Location = new System.Drawing.Point(536, 221);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(256, 256);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 13;
            this.pbxIcon.TabStop = false;
            // 
            // gbxFiles
            // 
            this.gbxFiles.Controls.Add(this.lblFiles);
            this.gbxFiles.Controls.Add(this.lbxFiles);
            this.gbxFiles.Controls.Add(this.btnBrowse);
            this.gbxFiles.Controls.Add(this.lbxIcons);
            this.gbxFiles.Controls.Add(this.lblIcons);
            this.gbxFiles.Controls.Add(this.lbxImages);
            this.gbxFiles.Controls.Add(this.lblImages);
            this.gbxFiles.Location = new System.Drawing.Point(12, 12);
            this.gbxFiles.Name = "gbxFiles";
            this.gbxFiles.Size = new System.Drawing.Size(563, 190);
            this.gbxFiles.TabIndex = 15;
            this.gbxFiles.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Image Information";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(6, 46);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 13);
            this.lblWidth.TabIndex = 17;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(6, 68);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 13);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Height:";
            // 
            // lblColorDepth
            // 
            this.lblColorDepth.AutoSize = true;
            this.lblColorDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorDepth.Location = new System.Drawing.Point(6, 90);
            this.lblColorDepth.Name = "lblColorDepth";
            this.lblColorDepth.Size = new System.Drawing.Size(78, 13);
            this.lblColorDepth.TabIndex = 19;
            this.lblColorDepth.Text = "Color Depth:";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompression.Location = new System.Drawing.Point(6, 112);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(82, 13);
            this.lblCompression.TabIndex = 20;
            this.lblCompression.Text = "Compression:";
            // 
            // gbxImageInfo
            // 
            this.gbxImageInfo.Controls.Add(this.lblCompressionValue);
            this.gbxImageInfo.Controls.Add(this.lblHeightValue);
            this.gbxImageInfo.Controls.Add(this.lblColorDepthValue);
            this.gbxImageInfo.Controls.Add(this.lblWidthValue);
            this.gbxImageInfo.Controls.Add(this.label1);
            this.gbxImageInfo.Controls.Add(this.lblCompression);
            this.gbxImageInfo.Controls.Add(this.lblWidth);
            this.gbxImageInfo.Controls.Add(this.lblColorDepth);
            this.gbxImageInfo.Controls.Add(this.lblHeight);
            this.gbxImageInfo.Location = new System.Drawing.Point(581, 12);
            this.gbxImageInfo.Name = "gbxImageInfo";
            this.gbxImageInfo.Size = new System.Drawing.Size(211, 190);
            this.gbxImageInfo.TabIndex = 21;
            this.gbxImageInfo.TabStop = false;
            // 
            // lblCompressionValue
            // 
            this.lblCompressionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressionValue.Location = new System.Drawing.Point(88, 112);
            this.lblCompressionValue.Name = "lblCompressionValue";
            this.lblCompressionValue.Size = new System.Drawing.Size(105, 13);
            this.lblCompressionValue.TabIndex = 24;
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightValue.Location = new System.Drawing.Point(88, 68);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(105, 13);
            this.lblHeightValue.TabIndex = 23;
            // 
            // lblColorDepthValue
            // 
            this.lblColorDepthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorDepthValue.Location = new System.Drawing.Point(88, 90);
            this.lblColorDepthValue.Name = "lblColorDepthValue";
            this.lblColorDepthValue.Size = new System.Drawing.Size(121, 13);
            this.lblColorDepthValue.TabIndex = 22;
            // 
            // lblWidthValue
            // 
            this.lblWidthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthValue.Location = new System.Drawing.Point(88, 46);
            this.lblWidthValue.Name = "lblWidthValue";
            this.lblWidthValue.Size = new System.Drawing.Size(105, 13);
            this.lblWidthValue.TabIndex = 21;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(717, 483);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "icl";
            this.dlgSave.Filter = "Windows Icon File (*.ico)|*.ico|Icon Library File (*.icl)|*.icl|DLL Library File " +
                "(*.dll)|*.dll|PNG Image File (*.png)|*.png";
            this.dlgSave.SupportMultiDottedExtensions = true;
            this.dlgSave.Title = "Export MultiIcon to";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 483);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExportBMP
            // 
            this.btnExportBMP.Location = new System.Drawing.Point(193, 483);
            this.btnExportBMP.Name = "btnExportBMP";
            this.btnExportBMP.Size = new System.Drawing.Size(75, 23);
            this.btnExportBMP.TabIndex = 24;
            this.btnExportBMP.Text = "Export";
            this.btnExportBMP.UseVisualStyleBackColor = true;
            this.btnExportBMP.Click += new System.EventHandler(this.btnExportBMP_Click);
            // 
            // btnExportAND
            // 
            this.btnExportAND.Location = new System.Drawing.Point(455, 483);
            this.btnExportAND.Name = "btnExportAND";
            this.btnExportAND.Size = new System.Drawing.Size(75, 23);
            this.btnExportAND.TabIndex = 25;
            this.btnExportAND.Text = "Export";
            this.btnExportAND.UseVisualStyleBackColor = true;
            this.btnExportAND.Click += new System.EventHandler(this.btnExportAND_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIconBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportAND);
            this.Controls.Add(this.btnExportBMP);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbxImageInfo);
            this.Controls.Add(this.gbxFiles);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.lblAndImage);
            this.Controls.Add(this.pbxANDImage);
            this.Controls.Add(this.lblXORImage);
            this.Controls.Add(this.pbxXORImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIconBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormIconBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxXORImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxANDImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.gbxFiles.ResumeLayout(false);
            this.gbxFiles.PerformLayout();
            this.gbxImageInfo.ResumeLayout(false);
            this.gbxImageInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowse;
        private System.Windows.Forms.Label lblIcons;
        private System.Windows.Forms.ListBox lbxIcons;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.ListBox lbxImages;
        private System.Windows.Forms.PictureBox pbxXORImage;
        private System.Windows.Forms.Label lblXORImage;
        private System.Windows.Forms.Label lblAndImage;
        private System.Windows.Forms.PictureBox pbxANDImage;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.GroupBox gbxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblColorDepth;
        private System.Windows.Forms.Label lblCompression;
        private System.Windows.Forms.GroupBox gbxImageInfo;
        private System.Windows.Forms.Label lblCompressionValue;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblColorDepthValue;
        private System.Windows.Forms.Label lblWidthValue;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExportBMP;
        private System.Windows.Forms.Button btnExportAND;
        private System.Windows.Forms.Button button1;
    }
}

