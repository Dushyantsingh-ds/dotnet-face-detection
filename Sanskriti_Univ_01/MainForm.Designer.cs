
namespace Sanskriti_Univ_01
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddNew_btn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dev_Link = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status_ = new System.Windows.Forms.Label();
            this.DisableDetection_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName_ = new System.Windows.Forms.Label();
            this.Detect_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EventAttendTime_ = new System.Windows.Forms.Label();
            this.BookingDateTime_ = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserCity_ = new System.Windows.Forms.Label();
            this.Mobilew = new System.Windows.Forms.Label();
            this.Mobile_ = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Role_ = new System.Windows.Forms.Label();
            this.DFG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addNew_UC1 = new Sanskriti_Univ_01.AddNew_UC();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.AddNew_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 435);
            this.panel2.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(-1, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 12;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Home_btn_click);
            // 
            // AddNew_btn
            // 
            this.AddNew_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.AddNew_btn.FlatAppearance.BorderSize = 0;
            this.AddNew_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNew_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNew_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddNew_btn.Location = new System.Drawing.Point(-1, 80);
            this.AddNew_btn.Name = "AddNew_btn";
            this.AddNew_btn.Size = new System.Drawing.Size(80, 80);
            this.AddNew_btn.TabIndex = 13;
            this.AddNew_btn.Text = "Records";
            this.AddNew_btn.UseVisualStyleBackColor = false;
            this.AddNew_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 54);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(930, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 18;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.Dev_Link);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 21);
            this.panel3.TabIndex = 41;
            // 
            // Dev_Link
            // 
            this.Dev_Link.AutoSize = true;
            this.Dev_Link.Location = new System.Drawing.Point(848, 3);
            this.Dev_Link.Name = "Dev_Link";
            this.Dev_Link.Size = new System.Drawing.Size(62, 13);
            this.Dev_Link.TabIndex = 1;
            this.Dev_Link.TabStop = true;
            this.Dev_Link.Text = "Spark 2021";
            this.Dev_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Dev_Link_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designed & Developed at";
            // 
            // button8
            // 
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(965, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 17;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 60);
            this.panel1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Status_);
            this.groupBox2.Controls.Add(this.DisableDetection_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UserName_);
            this.groupBox2.Controls.Add(this.Detect_btn);
            this.groupBox2.Location = new System.Drawing.Point(625, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 242);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Status";
            // 
            // Status_
            // 
            this.Status_.AutoSize = true;
            this.Status_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Status_.ForeColor = System.Drawing.Color.Blue;
            this.Status_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Status_.Location = new System.Drawing.Point(13, 111);
            this.Status_.Name = "Status_";
            this.Status_.Size = new System.Drawing.Size(37, 19);
            this.Status_.TabIndex = 53;
            this.Status_.Text = "Null";
            // 
            // DisableDetection_btn
            // 
            this.DisableDetection_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DisableDetection_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DisableDetection_btn.Location = new System.Drawing.Point(13, 192);
            this.DisableDetection_btn.Name = "DisableDetection_btn";
            this.DisableDetection_btn.Size = new System.Drawing.Size(80, 40);
            this.DisableDetection_btn.TabIndex = 18;
            this.DisableDetection_btn.Text = "Put Attendance";
            this.DisableDetection_btn.UseVisualStyleBackColor = true;
            this.DisableDetection_btn.Click += new System.EventHandler(this.DisableDetection_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persons present in the scene:";
            // 
            // UserName_
            // 
            this.UserName_.AutoSize = true;
            this.UserName_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.UserName_.ForeColor = System.Drawing.Color.Blue;
            this.UserName_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserName_.Location = new System.Drawing.Point(9, 48);
            this.UserName_.Name = "UserName_";
            this.UserName_.Size = new System.Drawing.Size(61, 19);
            this.UserName_.TabIndex = 16;
            this.UserName_.Text = "Nobody";
            // 
            // Detect_btn
            // 
            this.Detect_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Detect_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Detect_btn.Location = new System.Drawing.Point(114, 192);
            this.Detect_btn.Name = "Detect_btn";
            this.Detect_btn.Size = new System.Drawing.Size(80, 40);
            this.Detect_btn.TabIndex = 2;
            this.Detect_btn.Text = "1. Detect and recognize";
            this.Detect_btn.UseVisualStyleBackColor = true;
            this.Detect_btn.Click += new System.EventHandler(this.Detect_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.imageBoxFrameGrabber);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.addNew_UC1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 516);
            this.panel4.TabIndex = 46;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.03008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.96992F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.EventAttendTime_, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookingDateTime_, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserCity_, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mobilew, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Mobile_, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Role_, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DFG, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.76191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.23809F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 52);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // EventAttendTime_
            // 
            this.EventAttendTime_.AutoSize = true;
            this.EventAttendTime_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.EventAttendTime_.ForeColor = System.Drawing.Color.Blue;
            this.EventAttendTime_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EventAttendTime_.Location = new System.Drawing.Point(514, 28);
            this.EventAttendTime_.Name = "EventAttendTime_";
            this.EventAttendTime_.Size = new System.Drawing.Size(37, 19);
            this.EventAttendTime_.TabIndex = 57;
            this.EventAttendTime_.Text = "Null";
            // 
            // BookingDateTime_
            // 
            this.BookingDateTime_.AutoSize = true;
            this.BookingDateTime_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BookingDateTime_.ForeColor = System.Drawing.Color.Blue;
            this.BookingDateTime_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BookingDateTime_.Location = new System.Drawing.Point(368, 28);
            this.BookingDateTime_.Name = "BookingDateTime_";
            this.BookingDateTime_.Size = new System.Drawing.Size(37, 19);
            this.BookingDateTime_.TabIndex = 49;
            this.BookingDateTime_.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(368, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "Booking Time";
            // 
            // UserCity_
            // 
            this.UserCity_.AutoSize = true;
            this.UserCity_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.UserCity_.ForeColor = System.Drawing.Color.Red;
            this.UserCity_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserCity_.Location = new System.Drawing.Point(3, 28);
            this.UserCity_.Name = "UserCity_";
            this.UserCity_.Size = new System.Drawing.Size(35, 16);
            this.UserCity_.TabIndex = 48;
            this.UserCity_.Text = "Null";
            // 
            // Mobilew
            // 
            this.Mobilew.AutoSize = true;
            this.Mobilew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Mobilew.ForeColor = System.Drawing.Color.Black;
            this.Mobilew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mobilew.Location = new System.Drawing.Point(163, 0);
            this.Mobilew.Name = "Mobilew";
            this.Mobilew.Size = new System.Drawing.Size(51, 15);
            this.Mobilew.TabIndex = 56;
            this.Mobilew.Text = "Mobile";
            // 
            // Mobile_
            // 
            this.Mobile_.AutoSize = true;
            this.Mobile_.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Mobile_.ForeColor = System.Drawing.Color.Blue;
            this.Mobile_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mobile_.Location = new System.Drawing.Point(163, 28);
            this.Mobile_.Name = "Mobile_";
            this.Mobile_.Size = new System.Drawing.Size(37, 19);
            this.Mobile_.TabIndex = 55;
            this.Mobile_.Text = "Null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(261, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Role";
            // 
            // Role_
            // 
            this.Role_.AutoSize = true;
            this.Role_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Role_.ForeColor = System.Drawing.Color.Red;
            this.Role_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Role_.Location = new System.Drawing.Point(261, 28);
            this.Role_.Name = "Role_";
            this.Role_.Size = new System.Drawing.Size(35, 16);
            this.Role_.TabIndex = 52;
            this.Role_.Text = "Null";
            // 
            // DFG
            // 
            this.DFG.AutoSize = true;
            this.DFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.DFG.ForeColor = System.Drawing.Color.Black;
            this.DFG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DFG.Location = new System.Drawing.Point(514, 0);
            this.DFG.Name = "DFG";
            this.DFG.Size = new System.Drawing.Size(114, 15);
            this.DFG.TabIndex = 58;
            this.DFG.Text = "EventAttendTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "City";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(158, 108);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(443, 240);
            this.imageBoxFrameGrabber.TabIndex = 43;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(126, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 347);
            this.panel5.TabIndex = 47;
            // 
            // addNew_UC1
            // 
            this.addNew_UC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNew_UC1.Location = new System.Drawing.Point(102, 90);
            this.addNew_UC1.Name = "addNew_UC1";
            this.addNew_UC1.Size = new System.Drawing.Size(852, 363);
            this.addNew_UC1.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddNew_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserName_;
        private System.Windows.Forms.Button Detect_btn;
        private AddNew_UC addNew_UC1;
        private System.Windows.Forms.Panel panel4;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.LinkLabel Dev_Link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisableDetection_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status_;
        private System.Windows.Forms.Label EventAttendTime_;
        private System.Windows.Forms.Label DFG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookingDateTime_;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UserCity_;
        private System.Windows.Forms.Label Mobilew;
        private System.Windows.Forms.Label Mobile_;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Role_;
        private System.Windows.Forms.Panel panel5;
    }
}