namespace sLimsCounter
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
            this.welcome_message = new System.Windows.Forms.Label();
            this.place_name = new System.Windows.Forms.Label();
            this.institution_name = new System.Windows.Forms.Label();
            this.Img = new System.Windows.Forms.PictureBox();
            this.system_date = new System.Windows.Forms.Label();
            this.system_clock = new System.Windows.Forms.Label();
            this.ServerTime = new System.Windows.Forms.Timer(this.components);
            this.InputIDTxt = new System.Windows.Forms.TextBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.StatisticTablePanel = new System.Windows.Forms.Panel();
            this.AllTotal = new System.Windows.Forms.Label();
            this.YearTotal = new System.Windows.Forms.Label();
            this.MonthTotal = new System.Windows.Forms.Label();
            this.TodayTotal = new System.Windows.Forms.Label();
            this.Pnc4 = new System.Windows.Forms.Label();
            this.Pnc3 = new System.Windows.Forms.Label();
            this.Pnc2 = new System.Windows.Forms.Label();
            this.Pnc1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.StatisticHeader = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.Motto = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ValidatePanel = new System.Windows.Forms.Panel();
            this.InputNote1 = new System.Windows.Forms.Label();
            this.InputNote = new System.Windows.Forms.Label();
            this.InputMessage = new System.Windows.Forms.Label();
            this.RepoLink = new System.Windows.Forms.LinkLabel();
            this.Copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.StatisticTablePanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.ValidatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_message
            // 
            this.welcome_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome_message.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_message.Location = new System.Drawing.Point(0, 0);
            this.welcome_message.Name = "welcome_message";
            this.welcome_message.Size = new System.Drawing.Size(565, 42);
            this.welcome_message.TabIndex = 0;
            this.welcome_message.Text = "SELAMAT DATANG";
            this.welcome_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // place_name
            // 
            this.place_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.place_name.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_name.Location = new System.Drawing.Point(0, 45);
            this.place_name.Name = "place_name";
            this.place_name.Size = new System.Drawing.Size(565, 42);
            this.place_name.TabIndex = 1;
            this.place_name.Text = "PERPUSTAKAAN";
            this.place_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // institution_name
            // 
            this.institution_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.institution_name.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institution_name.Location = new System.Drawing.Point(0, 87);
            this.institution_name.Name = "institution_name";
            this.institution_name.Size = new System.Drawing.Size(565, 90);
            this.institution_name.TabIndex = 2;
            this.institution_name.Text = "Institution_Name";
            this.institution_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Img
            // 
            this.Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Img.Location = new System.Drawing.Point(25, 12);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(172, 179);
            this.Img.TabIndex = 3;
            this.Img.TabStop = false;
            // 
            // system_date
            // 
            this.system_date.AutoSize = true;
            this.system_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.system_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_date.Location = new System.Drawing.Point(0, 0);
            this.system_date.Name = "system_date";
            this.system_date.Size = new System.Drawing.Size(94, 19);
            this.system_date.TabIndex = 4;
            this.system_date.Text = "System_Date";
            // 
            // system_clock
            // 
            this.system_clock.AutoSize = true;
            this.system_clock.Dock = System.Windows.Forms.DockStyle.Right;
            this.system_clock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_clock.Location = new System.Drawing.Point(368, 0);
            this.system_clock.Name = "system_clock";
            this.system_clock.Size = new System.Drawing.Size(98, 19);
            this.system_clock.TabIndex = 5;
            this.system_clock.Text = "System_Clock";
            // 
            // ServerTime
            // 
            this.ServerTime.Enabled = true;
            this.ServerTime.Interval = 1000;
            this.ServerTime.Tick += new System.EventHandler(this.ServerTime_Tick);
            // 
            // InputIDTxt
            // 
            this.InputIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputIDTxt.Location = new System.Drawing.Point(31, 16);
            this.InputIDTxt.Name = "InputIDTxt";
            this.InputIDTxt.Size = new System.Drawing.Size(226, 47);
            this.InputIDTxt.TabIndex = 6;
            this.InputIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputIDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputIDTxt_KeyDown);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.welcome_message);
            this.HeaderPanel.Controls.Add(this.place_name);
            this.HeaderPanel.Controls.Add(this.institution_name);
            this.HeaderPanel.Location = new System.Drawing.Point(208, 12);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(567, 179);
            this.HeaderPanel.TabIndex = 13;
            // 
            // StatisticTablePanel
            // 
            this.StatisticTablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatisticTablePanel.Controls.Add(this.AllTotal);
            this.StatisticTablePanel.Controls.Add(this.YearTotal);
            this.StatisticTablePanel.Controls.Add(this.MonthTotal);
            this.StatisticTablePanel.Controls.Add(this.TodayTotal);
            this.StatisticTablePanel.Controls.Add(this.Pnc4);
            this.StatisticTablePanel.Controls.Add(this.Pnc3);
            this.StatisticTablePanel.Controls.Add(this.Pnc2);
            this.StatisticTablePanel.Controls.Add(this.Pnc1);
            this.StatisticTablePanel.Controls.Add(this.Total);
            this.StatisticTablePanel.Controls.Add(this.Year);
            this.StatisticTablePanel.Controls.Add(this.Month);
            this.StatisticTablePanel.Controls.Add(this.Today);
            this.StatisticTablePanel.Controls.Add(this.StatisticHeader);
            this.StatisticTablePanel.Location = new System.Drawing.Point(529, 211);
            this.StatisticTablePanel.Name = "StatisticTablePanel";
            this.StatisticTablePanel.Size = new System.Drawing.Size(247, 196);
            this.StatisticTablePanel.TabIndex = 14;
            // 
            // AllTotal
            // 
            this.AllTotal.AutoSize = true;
            this.AllTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTotal.Location = new System.Drawing.Point(119, 146);
            this.AllTotal.Name = "AllTotal";
            this.AllTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllTotal.Size = new System.Drawing.Size(118, 29);
            this.AllTotal.TabIndex = 27;
            this.AllTotal.Text = "TotalSemua";
            // 
            // YearTotal
            // 
            this.YearTotal.AutoSize = true;
            this.YearTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTotal.Location = new System.Drawing.Point(119, 123);
            this.YearTotal.Name = "YearTotal";
            this.YearTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.YearTotal.Size = new System.Drawing.Size(112, 29);
            this.YearTotal.TabIndex = 26;
            this.YearTotal.Text = "TotalTahun";
            // 
            // MonthTotal
            // 
            this.MonthTotal.AutoSize = true;
            this.MonthTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthTotal.Location = new System.Drawing.Point(119, 99);
            this.MonthTotal.Name = "MonthTotal";
            this.MonthTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MonthTotal.Size = new System.Drawing.Size(106, 29);
            this.MonthTotal.TabIndex = 25;
            this.MonthTotal.Text = "TotalBulan";
            // 
            // TodayTotal
            // 
            this.TodayTotal.AutoSize = true;
            this.TodayTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayTotal.Location = new System.Drawing.Point(119, 77);
            this.TodayTotal.Name = "TodayTotal";
            this.TodayTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TodayTotal.Size = new System.Drawing.Size(92, 29);
            this.TodayTotal.TabIndex = 24;
            this.TodayTotal.Text = "TotalHari";
            // 
            // Pnc4
            // 
            this.Pnc4.AutoSize = true;
            this.Pnc4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnc4.Location = new System.Drawing.Point(95, 146);
            this.Pnc4.Name = "Pnc4";
            this.Pnc4.Size = new System.Drawing.Size(18, 29);
            this.Pnc4.TabIndex = 23;
            this.Pnc4.Text = ":";
            // 
            // Pnc3
            // 
            this.Pnc3.AutoSize = true;
            this.Pnc3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnc3.Location = new System.Drawing.Point(95, 123);
            this.Pnc3.Name = "Pnc3";
            this.Pnc3.Size = new System.Drawing.Size(18, 29);
            this.Pnc3.TabIndex = 22;
            this.Pnc3.Text = ":";
            // 
            // Pnc2
            // 
            this.Pnc2.AutoSize = true;
            this.Pnc2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnc2.Location = new System.Drawing.Point(95, 99);
            this.Pnc2.Name = "Pnc2";
            this.Pnc2.Size = new System.Drawing.Size(18, 29);
            this.Pnc2.TabIndex = 21;
            this.Pnc2.Text = ":";
            // 
            // Pnc1
            // 
            this.Pnc1.AutoSize = true;
            this.Pnc1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnc1.Location = new System.Drawing.Point(95, 77);
            this.Pnc1.Name = "Pnc1";
            this.Pnc1.Size = new System.Drawing.Size(18, 29);
            this.Pnc1.TabIndex = 20;
            this.Pnc1.Text = ":";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(4, 146);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(56, 29);
            this.Total.TabIndex = 19;
            this.Total.Text = "Total";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(4, 123);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(93, 29);
            this.Year.TabIndex = 18;
            this.Year.Text = "Tahun Ini";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.Location = new System.Drawing.Point(4, 99);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(87, 29);
            this.Month.TabIndex = 17;
            this.Month.Text = "Bulan Ini";
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.Location = new System.Drawing.Point(4, 77);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(73, 29);
            this.Today.TabIndex = 16;
            this.Today.Text = "Hari Ini";
            // 
            // StatisticHeader
            // 
            this.StatisticHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticHeader.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticHeader.Location = new System.Drawing.Point(0, 0);
            this.StatisticHeader.Name = "StatisticHeader";
            this.StatisticHeader.Size = new System.Drawing.Size(245, 99);
            this.StatisticHeader.TabIndex = 15;
            this.StatisticHeader.Text = "STATISTIK PENGUNJUNG";
            this.StatisticHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FooterPanel.Controls.Add(this.Motto);
            this.FooterPanel.Location = new System.Drawing.Point(25, 364);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(468, 72);
            this.FooterPanel.TabIndex = 15;
            // 
            // Motto
            // 
            this.Motto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Motto.Location = new System.Drawing.Point(0, 0);
            this.Motto.Name = "Motto";
            this.Motto.Size = new System.Drawing.Size(466, 70);
            this.Motto.TabIndex = 0;
            this.Motto.Text = "Motto_Message";
            this.Motto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.ValidatePanel);
            this.InputPanel.Controls.Add(this.system_date);
            this.InputPanel.Controls.Add(this.system_clock);
            this.InputPanel.Location = new System.Drawing.Point(26, 218);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(468, 140);
            this.InputPanel.TabIndex = 16;
            // 
            // ValidatePanel
            // 
            this.ValidatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidatePanel.Controls.Add(this.InputNote1);
            this.ValidatePanel.Controls.Add(this.InputNote);
            this.ValidatePanel.Controls.Add(this.InputMessage);
            this.ValidatePanel.Controls.Add(this.InputIDTxt);
            this.ValidatePanel.Location = new System.Drawing.Point(85, 17);
            this.ValidatePanel.Name = "ValidatePanel";
            this.ValidatePanel.Size = new System.Drawing.Size(295, 118);
            this.ValidatePanel.TabIndex = 9;
            // 
            // InputNote1
            // 
            this.InputNote1.AutoSize = true;
            this.InputNote1.ForeColor = System.Drawing.Color.Red;
            this.InputNote1.Location = new System.Drawing.Point(37, 81);
            this.InputNote1.Name = "InputNote1";
            this.InputNote1.Size = new System.Drawing.Size(220, 13);
            this.InputNote1.TabIndex = 9;
            this.InputNote1.Text = "ATAU MENGURUS KE PETUGAS PERPUS";
            // 
            // InputNote
            // 
            this.InputNote.AutoSize = true;
            this.InputNote.ForeColor = System.Drawing.Color.Red;
            this.InputNote.Location = new System.Drawing.Point(44, 68);
            this.InputNote.Name = "InputNote";
            this.InputNote.Size = new System.Drawing.Size(206, 13);
            this.InputNote.TabIndex = 8;
            this.InputNote.Text = "JIKA TIDAK PUNYA MEMBER,KOSONGI";
            // 
            // InputMessage
            // 
            this.InputMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputMessage.Location = new System.Drawing.Point(0, 0);
            this.InputMessage.Name = "InputMessage";
            this.InputMessage.Size = new System.Drawing.Size(293, 13);
            this.InputMessage.TabIndex = 7;
            this.InputMessage.Text = "MASUKKAN MEMBER ID";
            this.InputMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RepoLink
            // 
            this.RepoLink.AutoSize = true;
            this.RepoLink.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
            this.RepoLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RepoLink.Location = new System.Drawing.Point(641, 426);
            this.RepoLink.Name = "RepoLink";
            this.RepoLink.Size = new System.Drawing.Size(95, 13);
            this.RepoLink.TabIndex = 18;
            this.RepoLink.TabStop = true;
            this.RepoLink.Text = "Erick Surya Dinata";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(526, 426);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(51, 13);
            this.Copyright.TabIndex = 19;
            this.Copyright.Text = "Copyright";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.RepoLink);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.StatisticTablePanel);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.HeaderPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SLIMS COUNTER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.StatisticTablePanel.ResumeLayout(false);
            this.StatisticTablePanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ValidatePanel.ResumeLayout(false);
            this.ValidatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_message;
        private System.Windows.Forms.Label place_name;
        private System.Windows.Forms.Label institution_name;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Label system_date;
        private System.Windows.Forms.Label system_clock;
        private System.Windows.Forms.Timer ServerTime;
        private System.Windows.Forms.TextBox InputIDTxt;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel StatisticTablePanel;
        private System.Windows.Forms.Label StatisticHeader;
        private System.Windows.Forms.Label AllTotal;
        private System.Windows.Forms.Label YearTotal;
        private System.Windows.Forms.Label MonthTotal;
        private System.Windows.Forms.Label TodayTotal;
        private System.Windows.Forms.Label Pnc4;
        private System.Windows.Forms.Label Pnc3;
        private System.Windows.Forms.Label Pnc2;
        private System.Windows.Forms.Label Pnc1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label Motto;
        private System.Windows.Forms.Label InputMessage;
        private System.Windows.Forms.Panel ValidatePanel;
        private System.Windows.Forms.Label InputNote1;
        private System.Windows.Forms.Label InputNote;
        private System.Windows.Forms.LinkLabel RepoLink;
        private System.Windows.Forms.Label Copyright;
    }
}