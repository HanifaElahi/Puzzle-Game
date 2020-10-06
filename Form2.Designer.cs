namespace Puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.youloseBox = new System.Windows.Forms.PictureBox();
            this.welldoneBox = new System.Windows.Forms.PictureBox();
            this.again = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.losepictureBox = new System.Windows.Forms.PictureBox();
            this.myPictureBox1 = new Puzzle.MyPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.youloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welldoneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelr.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelr.Location = new System.Drawing.Point(446, 150);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(0, 78);
            this.labelr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(22, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 78);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(982, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 78);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // youloseBox
            // 
            this.youloseBox.BackColor = System.Drawing.Color.LawnGreen;
            this.youloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.youloseBox.Image = global::Puzzle.Properties.Resources.youlose;
            this.youloseBox.ImageLocation = "";
            this.youloseBox.Location = new System.Drawing.Point(455, 392);
            this.youloseBox.Name = "youloseBox";
            this.youloseBox.Size = new System.Drawing.Size(545, 190);
            this.youloseBox.TabIndex = 13;
            this.youloseBox.TabStop = false;
            // 
            // welldoneBox
            // 
            this.welldoneBox.BackColor = System.Drawing.Color.Transparent;
            this.welldoneBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welldoneBox.Image = global::Puzzle.Properties.Resources.welldone1;
            this.welldoneBox.Location = new System.Drawing.Point(444, 219);
            this.welldoneBox.Name = "welldoneBox";
            this.welldoneBox.Size = new System.Drawing.Size(549, 158);
            this.welldoneBox.TabIndex = 10;
            this.welldoneBox.TabStop = false;
            // 
            // again
            // 
            this.again.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("again.BackgroundImage")));
            this.again.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.again.Cursor = System.Windows.Forms.Cursors.Hand;
            this.again.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.again.Location = new System.Drawing.Point(454, 588);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(547, 89);
            this.again.TabIndex = 4;
            this.again.Text = "PLAY AGAIN";
            this.again.UseVisualStyleBackColor = true;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Puzzle.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(454, -159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 372);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ExitBtn.Location = new System.Drawing.Point(454, 683);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(549, 89);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // losepictureBox
            // 
            this.losepictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("losepictureBox.BackgroundImage")));
            this.losepictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.losepictureBox.Location = new System.Drawing.Point(-1, -3);
            this.losepictureBox.Name = "losepictureBox";
            this.losepictureBox.Size = new System.Drawing.Size(1481, 810);
            this.losepictureBox.TabIndex = 7;
            this.losepictureBox.TabStop = false;
            // 
            // myPictureBox1
            // 
            this.myPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPictureBox1.BackgroundImage")));
            this.myPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPictureBox1.ImageIndex = 0;
            this.myPictureBox1.Index = 0;
            this.myPictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.myPictureBox1.Name = "myPictureBox1";
            this.myPictureBox1.Size = new System.Drawing.Size(1481, 810);
            this.myPictureBox1.TabIndex = 6;
            this.myPictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 779);
            this.Controls.Add(this.welldoneBox);
            this.Controls.Add(this.youloseBox);
            this.Controls.Add(this.again);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.myPictureBox1);
            this.Controls.Add(this.losepictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixMe";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.youloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welldoneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button again;
        private MyPictureBox myPictureBox1;
        private System.Windows.Forms.PictureBox losepictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox welldoneBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox youloseBox;
    }
}