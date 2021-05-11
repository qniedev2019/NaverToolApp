namespace NaverToolApp
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
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.rtbLink = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnPaste = new System.Windows.Forms.Button();
            this.rdbPost = new System.Windows.Forms.RadioButton();
            this.rdbEntertain = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTopStar = new System.Windows.Forms.RadioButton();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.cbbSite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpenFolder = new System.Windows.Forms.CheckBox();
            this.download_progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Download_stt = new System.Windows.Forms.Label();
            this.btnExif = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSource
            // 
            this.rtbSource.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSource.DetectUrls = false;
            this.rtbSource.Location = new System.Drawing.Point(472, 360);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(42, 31);
            this.rtbSource.TabIndex = 0;
            this.rtbSource.Text = resources.GetString("rtbSource.Text");
            this.rtbSource.Visible = false;
            this.rtbSource.Click += new System.EventHandler(this.rtbSource_Click);
            // 
            // rtbLink
            // 
            this.rtbLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.rtbLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLink.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLink.Location = new System.Drawing.Point(328, 167);
            this.rtbLink.Name = "rtbLink";
            this.rtbLink.Size = new System.Drawing.Size(307, 137);
            this.rtbLink.TabIndex = 7;
            this.rtbLink.Text = "";
            this.rtbLink.Click += new System.EventHandler(this.rtbLink_Click);
            this.rtbLink.TextChanged += new System.EventHandler(this.rtbLink_TextChanged);
            this.rtbLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtbLink_MouseUp);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(648, 186);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(118, 35);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "DOWNLOAD";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(593, 360);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(36, 20);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Text File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(675, 385);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "L O N G  K E N J";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.Location = new System.Drawing.Point(648, 145);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(118, 35);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "PASTE LINK";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // rdbPost
            // 
            this.rdbPost.AutoSize = true;
            this.rdbPost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPost.Location = new System.Drawing.Point(3, 16);
            this.rdbPost.Name = "rdbPost";
            this.rdbPost.Size = new System.Drawing.Size(87, 21);
            this.rdbPost.TabIndex = 0;
            this.rdbPost.TabStop = true;
            this.rdbPost.Text = "Post Naver";
            this.rdbPost.UseVisualStyleBackColor = true;
            // 
            // rdbEntertain
            // 
            this.rdbEntertain.AutoSize = true;
            this.rdbEntertain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntertain.Location = new System.Drawing.Point(3, 39);
            this.rdbEntertain.Name = "rdbEntertain";
            this.rdbEntertain.Size = new System.Drawing.Size(113, 21);
            this.rdbEntertain.TabIndex = 1;
            this.rdbEntertain.TabStop = true;
            this.rdbEntertain.Text = "Entertain Naver";
            this.rdbEntertain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdbTopStar);
            this.groupBox1.Controls.Add(this.rdbEntertain);
            this.groupBox1.Controls.Add(this.rdbPost);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(529, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(38, 35);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Site:";
            this.groupBox1.Visible = false;
            // 
            // rdbTopStar
            // 
            this.rdbTopStar.AutoSize = true;
            this.rdbTopStar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTopStar.Location = new System.Drawing.Point(3, 63);
            this.rdbTopStar.Name = "rdbTopStar";
            this.rdbTopStar.Size = new System.Drawing.Size(103, 21);
            this.rdbTopStar.TabIndex = 2;
            this.rdbTopStar.TabStop = true;
            this.rdbTopStar.Text = "TopStar News";
            this.rdbTopStar.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(649, 268);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(118, 35);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NaverToolApp.Properties.Resources.download_ani;
            this.pictureBox1.Location = new System.Drawing.Point(646, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(328, 111);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(307, 25);
            this.txtURL.TabIndex = 0;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(326, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Paste link url here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(746, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Gray;
            this.lblClose.Location = new System.Drawing.Point(739, 25);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 12);
            this.lblClose.TabIndex = 14;
            this.lblClose.Text = "Close";
            this.lblClose.Visible = false;
            // 
            // cbbSite
            // 
            this.cbbSite.BackColor = System.Drawing.Color.White;
            this.cbbSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSite.FormattingEnabled = true;
            this.cbbSite.Items.AddRange(new object[] {
            "Post Naver",
            "Entertain Naver",
            "Topstar News",
            "Twitter"});
            this.cbbSite.Location = new System.Drawing.Point(648, 111);
            this.cbbSite.Name = "cbbSite";
            this.cbbSite.Size = new System.Drawing.Size(116, 25);
            this.cbbSite.TabIndex = 1;
            this.cbbSite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbSite_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(648, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select website:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Naver Image Downloader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Version 1.2.1 Beta";
            // 
            // cbOpenFolder
            // 
            this.cbOpenFolder.AutoSize = true;
            this.cbOpenFolder.BackColor = System.Drawing.Color.White;
            this.cbOpenFolder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpenFolder.ForeColor = System.Drawing.Color.Gray;
            this.cbOpenFolder.Location = new System.Drawing.Point(328, 140);
            this.cbOpenFolder.Name = "cbOpenFolder";
            this.cbOpenFolder.Size = new System.Drawing.Size(268, 21);
            this.cbOpenFolder.TabIndex = 2;
            this.cbOpenFolder.Text = "Auto open folder when download complete.";
            this.cbOpenFolder.UseVisualStyleBackColor = false;
            // 
            // download_progress
            // 
            this.download_progress.BackColor = System.Drawing.Color.White;
            this.download_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.download_progress.Location = new System.Drawing.Point(328, 310);
            this.download_progress.Name = "download_progress";
            this.download_progress.Size = new System.Drawing.Size(304, 23);
            this.download_progress.TabIndex = 19;
            this.download_progress.Visible = false;
            // 
            // lbl_Download_stt
            // 
            this.lbl_Download_stt.AutoSize = true;
            this.lbl_Download_stt.BackColor = System.Drawing.Color.White;
            this.lbl_Download_stt.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic);
            this.lbl_Download_stt.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Download_stt.Location = new System.Drawing.Point(427, 336);
            this.lbl_Download_stt.Name = "lbl_Download_stt";
            this.lbl_Download_stt.Size = new System.Drawing.Size(90, 12);
            this.lbl_Download_stt.TabIndex = 20;
            this.lbl_Download_stt.Text = "Downloading status";
            this.lbl_Download_stt.Visible = false;
            // 
            // btnExif
            // 
            this.btnExif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExif.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExif.ForeColor = System.Drawing.Color.White;
            this.btnExif.Location = new System.Drawing.Point(649, 227);
            this.btnExif.Name = "btnExif";
            this.btnExif.Size = new System.Drawing.Size(118, 35);
            this.btnExif.TabIndex = 21;
            this.btnExif.Text = "EXIF INFO";
            this.btnExif.UseVisualStyleBackColor = false;
            this.btnExif.Click += new System.EventHandler(this.btnExif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BackgroundImage = global::NaverToolApp.Properties.Resources.naver_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 416);
            this.Controls.Add(this.btnExif);
            this.Controls.Add(this.lbl_Download_stt);
            this.Controls.Add(this.download_progress);
            this.Controls.Add(this.cbOpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbSite);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.rtbLink);
            this.Controls.Add(this.rtbSource);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAVER IMAGE DOWNLOADER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.RichTextBox rtbLink;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.RadioButton rdbPost;
        private System.Windows.Forms.RadioButton rdbEntertain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.RadioButton rdbTopStar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ComboBox cbbSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbOpenFolder;
        private System.Windows.Forms.ProgressBar download_progress;
        private System.Windows.Forms.Label lbl_Download_stt;
        private System.Windows.Forms.Button btnExif;
    }
}

