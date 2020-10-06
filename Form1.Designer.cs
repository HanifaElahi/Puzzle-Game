namespace Puzzle
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
            this.groupboxPuzzle = new System.Windows.Forms.GroupBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.realPic = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.soundBtn = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.playBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonImageBrowse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.platBtn = new System.Windows.Forms.Button();
            this.groupboxPuzzle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.realPic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxPuzzle
            // 
            this.groupboxPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.groupboxPuzzle.Controls.Add(this.pause);
            this.groupboxPuzzle.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPuzzle.ForeColor = System.Drawing.Color.Yellow;
            this.groupboxPuzzle.Location = new System.Drawing.Point(14, 12);
            this.groupboxPuzzle.Name = "groupboxPuzzle";
            this.groupboxPuzzle.Size = new System.Drawing.Size(979, 626);
            this.groupboxPuzzle.TabIndex = 1;
            this.groupboxPuzzle.TabStop = false;
            this.groupboxPuzzle.Text = "PUZZLE";
            // 
            // pause
            // 
            this.pause.Image = global::Puzzle.Properties.Resources.PAUSEbox;
            this.pause.Location = new System.Drawing.Point(0, 0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(1015, 626);
            this.pause.TabIndex = 1;
            this.pause.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonLevel3);
            this.groupBox2.Controls.Add(this.buttonLevel2);
            this.groupBox2.Controls.Add(this.buttonLevel1);
            this.groupBox2.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(1010, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Play Mode";
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevel3.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonLevel3.Image = ((System.Drawing.Image)(resources.GetObject("buttonLevel3.Image")));
            this.buttonLevel3.Location = new System.Drawing.Point(104, 196);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(293, 50);
            this.buttonLevel3.TabIndex = 4;
            this.buttonLevel3.Text = "HARD";
            this.buttonLevel3.UseVisualStyleBackColor = true;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevel2.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonLevel2.Image = ((System.Drawing.Image)(resources.GetObject("buttonLevel2.Image")));
            this.buttonLevel2.Location = new System.Drawing.Point(104, 132);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(293, 50);
            this.buttonLevel2.TabIndex = 3;
            this.buttonLevel2.Text = "MEDIUM";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevel1.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonLevel1.Image = ((System.Drawing.Image)(resources.GetObject("buttonLevel1.Image")));
            this.buttonLevel1.Location = new System.Drawing.Point(104, 60);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(293, 50);
            this.buttonLevel1.TabIndex = 2;
            this.buttonLevel1.Text = "EASY";
            this.buttonLevel1.UseVisualStyleBackColor = true;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // realPic
            // 
            this.realPic.BackColor = System.Drawing.Color.Transparent;
            this.realPic.Controls.Add(this.labelStatus);
            this.realPic.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realPic.ForeColor = System.Drawing.Color.Yellow;
            this.realPic.Location = new System.Drawing.Point(1010, 12);
            this.realPic.Name = "realPic";
            this.realPic.Size = new System.Drawing.Size(443, 352);
            this.realPic.TabIndex = 3;
            this.realPic.TabStop = false;
            this.realPic.Text = "Original Picture";
            this.realPic.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(25, 30);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 38);
            this.labelStatus.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.muteBtn);
            this.groupBox1.Controls.Add(this.soundBtn);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.playBtn);
            this.groupBox1.Controls.Add(this.pauseBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonImageBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(22, 641);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(1425, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(921, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // muteBtn
            // 
            this.muteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("muteBtn.BackgroundImage")));
            this.muteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteBtn.Location = new System.Drawing.Point(1293, 36);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(58, 61);
            this.muteBtn.TabIndex = 4;
            this.muteBtn.UseVisualStyleBackColor = true;
            this.muteBtn.Click += new System.EventHandler(this.muteBtn_Click);
            // 
            // soundBtn
            // 
            this.soundBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundBtn.BackgroundImage")));
            this.soundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundBtn.Location = new System.Drawing.Point(1351, 36);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(58, 61);
            this.soundBtn.TabIndex = 3;
            this.soundBtn.UseVisualStyleBackColor = true;
            this.soundBtn.Click += new System.EventHandler(this.soundBtn_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Silver;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.Location = new System.Drawing.Point(1225, 100);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(200, 29);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "HOW TO PLAY?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Location = new System.Drawing.Point(797, 43);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(61, 57);
            this.playBtn.TabIndex = 2;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click_1);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseBtn.BackgroundImage")));
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.pauseBtn.Location = new System.Drawing.Point(730, 42);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(61, 57);
            this.pauseBtn.TabIndex = 0;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(458, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 59);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "00:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonImageBrowse
            // 
            this.buttonImageBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImageBrowse.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImageBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageBrowse.Image")));
            this.buttonImageBrowse.Location = new System.Drawing.Point(43, 42);
            this.buttonImageBrowse.Name = "buttonImageBrowse";
            this.buttonImageBrowse.Size = new System.Drawing.Size(332, 58);
            this.buttonImageBrowse.TabIndex = 1;
            this.buttonImageBrowse.Text = "CHOOSE IMAGE";
            this.buttonImageBrowse.UseVisualStyleBackColor = true;
            this.buttonImageBrowse.Click += new System.EventHandler(this.buttonImageBrowse_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.platBtn);
            this.groupBox3.Location = new System.Drawing.Point(-4, -18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1481, 810);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.Location = new System.Drawing.Point(565, 492);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(324, 43);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HOW TO PLAY?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 163);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // platBtn
            // 
            this.platBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platBtn.BackgroundImage")));
            this.platBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platBtn.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.platBtn.Location = new System.Drawing.Point(459, 362);
            this.platBtn.Name = "platBtn";
            this.platBtn.Size = new System.Drawing.Size(563, 89);
            this.platBtn.TabIndex = 2;
            this.platBtn.Text = "PLAY";
            this.platBtn.UseVisualStyleBackColor = true;
            this.platBtn.Click += new System.EventHandler(this.platBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1473, 775);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupboxPuzzle);
            this.Controls.Add(this.realPic);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxPuzzle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.realPic.ResumeLayout(false);
            this.realPic.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupboxPuzzle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.GroupBox realPic;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonImageBrowse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button platBtn;
        private System.Windows.Forms.PictureBox pause;
    }
}

