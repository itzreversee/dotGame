namespace dotManager
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
            this.gpanel = new System.Windows.Forms.Panel();
            this.lstatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.otherinfo = new System.Windows.Forms.Label();
            this.setuptype = new System.Windows.Forms.Label();
            this.repacksize = new System.Windows.Forms.Label();
            this.originalsize = new System.Windows.Forms.Label();
            this.gtitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quitbtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.installBtn = new System.Windows.Forms.Button();
            this.dropMeta = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.gpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpanel
            // 
            this.gpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpanel.Controls.Add(this.lstatus);
            this.gpanel.Controls.Add(this.label7);
            this.gpanel.Controls.Add(this.progressBar1);
            this.gpanel.Controls.Add(this.otherinfo);
            this.gpanel.Controls.Add(this.setuptype);
            this.gpanel.Controls.Add(this.repacksize);
            this.gpanel.Controls.Add(this.originalsize);
            this.gpanel.Controls.Add(this.gtitle);
            this.gpanel.Controls.Add(this.label5);
            this.gpanel.Controls.Add(this.label6);
            this.gpanel.Controls.Add(this.label3);
            this.gpanel.Controls.Add(this.label2);
            this.gpanel.Controls.Add(this.label1);
            this.gpanel.Location = new System.Drawing.Point(12, 12);
            this.gpanel.Name = "gpanel";
            this.gpanel.Size = new System.Drawing.Size(655, 426);
            this.gpanel.TabIndex = 0;
            this.gpanel.Visible = false;
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstatus.Location = new System.Drawing.Point(69, 370);
            this.lstatus.Name = "lstatus";
            this.lstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstatus.Size = new System.Drawing.Size(34, 18);
            this.lstatus.TabIndex = 12;
            this.lstatus.Text = "N/A";
            this.lstatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(615, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // otherinfo
            // 
            this.otherinfo.AutoSize = true;
            this.otherinfo.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otherinfo.Location = new System.Drawing.Point(98, 132);
            this.otherinfo.Name = "otherinfo";
            this.otherinfo.Size = new System.Drawing.Size(29, 18);
            this.otherinfo.TabIndex = 9;
            this.otherinfo.Text = "foo";
            // 
            // setuptype
            // 
            this.setuptype.AutoSize = true;
            this.setuptype.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setuptype.Location = new System.Drawing.Point(106, 103);
            this.setuptype.Name = "setuptype";
            this.setuptype.Size = new System.Drawing.Size(29, 18);
            this.setuptype.TabIndex = 8;
            this.setuptype.Text = "foo";
            // 
            // repacksize
            // 
            this.repacksize.AutoSize = true;
            this.repacksize.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repacksize.Location = new System.Drawing.Point(113, 74);
            this.repacksize.Name = "repacksize";
            this.repacksize.Size = new System.Drawing.Size(29, 18);
            this.repacksize.TabIndex = 7;
            this.repacksize.Text = "foo";
            // 
            // originalsize
            // 
            this.originalsize.AutoSize = true;
            this.originalsize.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.originalsize.Location = new System.Drawing.Point(112, 45);
            this.originalsize.Name = "originalsize";
            this.originalsize.Size = new System.Drawing.Size(29, 18);
            this.originalsize.TabIndex = 6;
            this.originalsize.Text = "foo";
            // 
            // gtitle
            // 
            this.gtitle.AutoSize = true;
            this.gtitle.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gtitle.Location = new System.Drawing.Point(104, 16);
            this.gtitle.Name = "gtitle";
            this.gtitle.Size = new System.Drawing.Size(29, 18);
            this.gtitle.TabIndex = 5;
            this.gtitle.Text = "foo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Other Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Setup Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repack Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Original Size:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.quitbtn);
            this.panel2.Controls.Add(this.downloadBtn);
            this.panel2.Controls.Add(this.installBtn);
            this.panel2.Location = new System.Drawing.Point(673, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 426);
            this.panel2.TabIndex = 1;
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quitbtn.Location = new System.Drawing.Point(20, 390);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(75, 23);
            this.quitbtn.TabIndex = 2;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.downloadBtn.Enabled = false;
            this.downloadBtn.Location = new System.Drawing.Point(20, 45);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // installBtn
            // 
            this.installBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.installBtn.Enabled = false;
            this.installBtn.Location = new System.Drawing.Point(20, 16);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(75, 23);
            this.installBtn.TabIndex = 0;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = false;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // dropMeta
            // 
            this.dropMeta.AutoSize = true;
            this.dropMeta.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropMeta.Location = new System.Drawing.Point(246, 202);
            this.dropMeta.Name = "dropMeta";
            this.dropMeta.Size = new System.Drawing.Size(221, 18);
            this.dropMeta.TabIndex = 0;
            this.dropMeta.Text = "Drop Metadata file here to begin!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "https://github.com/reversee-dev/dotGame";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropMeta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gpanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "dotInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpanel.ResumeLayout(false);
            this.gpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.Label otherinfo;
        private System.Windows.Forms.Label setuptype;
        private System.Windows.Forms.Label repacksize;
        private System.Windows.Forms.Label originalsize;
        private System.Windows.Forms.Label gtitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lstatus;
        public System.Windows.Forms.Label dropMeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
    }
}

