namespace DebugForm
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
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRecognizeCaptcha = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCaptureCaptcha = new System.Windows.Forms.Button();
            this.txtHCapture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWCapture = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYCaptcha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXCaptcha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictFiltering = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictCapture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictCaptureContour = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXCaptureContour = new System.Windows.Forms.TextBox();
            this.Contour = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYCaptureContour = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWCaptureContour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHCaptureContour = new System.Windows.Forms.TextBox();
            this.btnCaptureContour = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBFiltering = new System.Windows.Forms.TextBox();
            this.txtGFiltering = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRFiltering = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOFiltering = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnFilteringCaptcha = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFiltering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCapture)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCaptureContour)).BeginInit();
            this.Contour.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(12, 25);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(213, 20);
            this.txtProcessName.TabIndex = 0;
            this.txtProcessName.Text = "BlackDesert64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process name";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 696);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnRecognizeCaptcha);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictFiltering);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictCapture);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Captcha";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRecognizeCaptcha
            // 
            this.btnRecognizeCaptcha.Location = new System.Drawing.Point(732, 642);
            this.btnRecognizeCaptcha.Name = "btnRecognizeCaptcha";
            this.btnRecognizeCaptcha.Size = new System.Drawing.Size(151, 23);
            this.btnRecognizeCaptcha.TabIndex = 7;
            this.btnRecognizeCaptcha.Text = "Recognize";
            this.btnRecognizeCaptcha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCaptureCaptcha);
            this.groupBox1.Controls.Add(this.txtHCapture);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtWCapture);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtYCaptcha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtXCaptcha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // btnCaptureCaptcha
            // 
            this.btnCaptureCaptcha.Location = new System.Drawing.Point(9, 69);
            this.btnCaptureCaptcha.Name = "btnCaptureCaptcha";
            this.btnCaptureCaptcha.Size = new System.Drawing.Size(132, 44);
            this.btnCaptureCaptcha.TabIndex = 6;
            this.btnCaptureCaptcha.Text = "Capture";
            this.btnCaptureCaptcha.UseVisualStyleBackColor = true;
            this.btnCaptureCaptcha.Click += new System.EventHandler(this.btnCaptureCaptcha_Click);
            // 
            // txtHCapture
            // 
            this.txtHCapture.Location = new System.Drawing.Point(99, 34);
            this.txtHCapture.Name = "txtHCapture";
            this.txtHCapture.Size = new System.Drawing.Size(42, 20);
            this.txtHCapture.TabIndex = 5;
            this.txtHCapture.Text = "350";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "H";
            // 
            // txtWCapture
            // 
            this.txtWCapture.Location = new System.Drawing.Point(99, 13);
            this.txtWCapture.Name = "txtWCapture";
            this.txtWCapture.Size = new System.Drawing.Size(42, 20);
            this.txtWCapture.TabIndex = 4;
            this.txtWCapture.Text = "350";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "W";
            // 
            // txtYCaptcha
            // 
            this.txtYCaptcha.Location = new System.Drawing.Point(26, 34);
            this.txtYCaptcha.Name = "txtYCaptcha";
            this.txtYCaptcha.Size = new System.Drawing.Size(43, 20);
            this.txtYCaptcha.TabIndex = 3;
            this.txtYCaptcha.Text = "450";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y";
            // 
            // txtXCaptcha
            // 
            this.txtXCaptcha.Location = new System.Drawing.Point(26, 13);
            this.txtXCaptcha.Name = "txtXCaptcha";
            this.txtXCaptcha.Size = new System.Drawing.Size(43, 20);
            this.txtXCaptcha.TabIndex = 1;
            this.txtXCaptcha.Text = "720";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Captcha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 644);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            // 
            // pictFiltering
            // 
            this.pictFiltering.Location = new System.Drawing.Point(497, 19);
            this.pictFiltering.Name = "pictFiltering";
            this.pictFiltering.Size = new System.Drawing.Size(485, 315);
            this.pictFiltering.TabIndex = 3;
            this.pictFiltering.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capture";
            // 
            // pictCapture
            // 
            this.pictCapture.Location = new System.Drawing.Point(6, 19);
            this.pictCapture.Name = "pictCapture";
            this.pictCapture.Size = new System.Drawing.Size(485, 315);
            this.pictCapture.TabIndex = 0;
            this.pictCapture.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Contour);
            this.tabPage2.Controls.Add(this.pictCaptureContour);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(724, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FindContour";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictCaptureContour
            // 
            this.pictCaptureContour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictCaptureContour.Location = new System.Drawing.Point(6, 3);
            this.pictCaptureContour.Name = "pictCaptureContour";
            this.pictCaptureContour.Size = new System.Drawing.Size(715, 398);
            this.pictCaptureContour.TabIndex = 0;
            this.pictCaptureContour.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            // 
            // txtXCaptureContour
            // 
            this.txtXCaptureContour.Location = new System.Drawing.Point(25, 19);
            this.txtXCaptureContour.Name = "txtXCaptureContour";
            this.txtXCaptureContour.Size = new System.Drawing.Size(47, 20);
            this.txtXCaptureContour.TabIndex = 3;
            this.txtXCaptureContour.Text = "550";
            // 
            // Contour
            // 
            this.Contour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Contour.Controls.Add(this.btnCaptureContour);
            this.Contour.Controls.Add(this.txtHCaptureContour);
            this.Contour.Controls.Add(this.label13);
            this.Contour.Controls.Add(this.txtWCaptureContour);
            this.Contour.Controls.Add(this.label12);
            this.Contour.Controls.Add(this.txtYCaptureContour);
            this.Contour.Controls.Add(this.label11);
            this.Contour.Controls.Add(this.txtXCaptureContour);
            this.Contour.Controls.Add(this.label10);
            this.Contour.Location = new System.Drawing.Point(6, 405);
            this.Contour.Name = "Contour";
            this.Contour.Size = new System.Drawing.Size(232, 95);
            this.Contour.TabIndex = 4;
            this.Contour.TabStop = false;
            this.Contour.Text = "groupBox2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Y";
            // 
            // txtYCaptureContour
            // 
            this.txtYCaptureContour.Location = new System.Drawing.Point(25, 44);
            this.txtYCaptureContour.Name = "txtYCaptureContour";
            this.txtYCaptureContour.Size = new System.Drawing.Size(47, 20);
            this.txtYCaptureContour.TabIndex = 5;
            this.txtYCaptureContour.Text = "300";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "W";
            // 
            // txtWCaptureContour
            // 
            this.txtWCaptureContour.Location = new System.Drawing.Point(102, 19);
            this.txtWCaptureContour.Name = "txtWCaptureContour";
            this.txtWCaptureContour.Size = new System.Drawing.Size(47, 20);
            this.txtWCaptureContour.TabIndex = 7;
            this.txtWCaptureContour.Text = "600";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "H";
            // 
            // txtHCaptureContour
            // 
            this.txtHCaptureContour.Location = new System.Drawing.Point(102, 44);
            this.txtHCaptureContour.Name = "txtHCaptureContour";
            this.txtHCaptureContour.Size = new System.Drawing.Size(47, 20);
            this.txtHCaptureContour.TabIndex = 9;
            this.txtHCaptureContour.Text = "600";
            // 
            // btnCaptureContour
            // 
            this.btnCaptureContour.Location = new System.Drawing.Point(155, 19);
            this.btnCaptureContour.Name = "btnCaptureContour";
            this.btnCaptureContour.Size = new System.Drawing.Size(70, 45);
            this.btnCaptureContour.TabIndex = 10;
            this.btnCaptureContour.Text = "Capture";
            this.btnCaptureContour.UseVisualStyleBackColor = true;
            this.btnCaptureContour.Click += new System.EventHandler(this.btnCaptureContour_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilteringCaptcha);
            this.groupBox2.Controls.Add(this.txtOFiltering);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtRFiltering);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtGFiltering);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtBFiltering);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(163, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "B";
            // 
            // txtBFiltering
            // 
            this.txtBFiltering.Location = new System.Drawing.Point(26, 13);
            this.txtBFiltering.Name = "txtBFiltering";
            this.txtBFiltering.Size = new System.Drawing.Size(48, 20);
            this.txtBFiltering.TabIndex = 1;
            this.txtBFiltering.Text = "20";
            // 
            // txtGFiltering
            // 
            this.txtGFiltering.Location = new System.Drawing.Point(26, 34);
            this.txtGFiltering.Name = "txtGFiltering";
            this.txtGFiltering.Size = new System.Drawing.Size(48, 20);
            this.txtGFiltering.TabIndex = 3;
            this.txtGFiltering.Text = "20";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "G";
            // 
            // txtRFiltering
            // 
            this.txtRFiltering.Location = new System.Drawing.Point(102, 13);
            this.txtRFiltering.Name = "txtRFiltering";
            this.txtRFiltering.Size = new System.Drawing.Size(48, 20);
            this.txtRFiltering.TabIndex = 5;
            this.txtRFiltering.Text = "200";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "R";
            // 
            // txtOFiltering
            // 
            this.txtOFiltering.Location = new System.Drawing.Point(102, 34);
            this.txtOFiltering.Name = "txtOFiltering";
            this.txtOFiltering.Size = new System.Drawing.Size(48, 20);
            this.txtOFiltering.TabIndex = 7;
            this.txtOFiltering.Text = "70";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "O";
            // 
            // btnFilteringCaptcha
            // 
            this.btnFilteringCaptcha.Location = new System.Drawing.Point(9, 69);
            this.btnFilteringCaptcha.Name = "btnFilteringCaptcha";
            this.btnFilteringCaptcha.Size = new System.Drawing.Size(141, 44);
            this.btnFilteringCaptcha.TabIndex = 7;
            this.btnFilteringCaptcha.Text = "Filtering";
            this.btnFilteringCaptcha.UseVisualStyleBackColor = true;
            this.btnFilteringCaptcha.Click += new System.EventHandler(this.btnFilteringCaptcha_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(389, 399);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(51, 20);
            this.txtArea.TabIndex = 9;
            this.txtArea.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 759);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcessName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFiltering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCapture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictCaptureContour)).EndInit();
            this.Contour.ResumeLayout(false);
            this.Contour.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRecognizeCaptcha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCaptureCaptcha;
        private System.Windows.Forms.TextBox txtHCapture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWCapture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYCaptcha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXCaptcha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictFiltering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictCapture;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Contour;
        private System.Windows.Forms.Button btnCaptureContour;
        private System.Windows.Forms.TextBox txtHCaptureContour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWCaptureContour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYCaptureContour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtXCaptureContour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictCaptureContour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilteringCaptcha;
        private System.Windows.Forms.TextBox txtOFiltering;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRFiltering;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGFiltering;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBFiltering;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArea;
    }
}

