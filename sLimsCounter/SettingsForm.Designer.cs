namespace sLimsCounter
{
    partial class SettingsForm
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
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.DbTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.RememberCk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProsesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(215, 20);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(160, 20);
            this.ServerTxt.TabIndex = 0;
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(215, 60);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(160, 20);
            this.PortTxt.TabIndex = 1;
            // 
            // DbTxt
            // 
            this.DbTxt.Location = new System.Drawing.Point(215, 100);
            this.DbTxt.Name = "DbTxt";
            this.DbTxt.Size = new System.Drawing.Size(160, 20);
            this.DbTxt.TabIndex = 2;
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(215, 140);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(160, 20);
            this.UserTxt.TabIndex = 3;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(215, 180);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(160, 20);
            this.PassTxt.TabIndex = 4;
            // 
            // RememberCk
            // 
            this.RememberCk.AutoSize = true;
            this.RememberCk.Location = new System.Drawing.Point(215, 222);
            this.RememberCk.Name = "RememberCk";
            this.RememberCk.Size = new System.Drawing.Size(108, 17);
            this.RememberCk.TabIndex = 6;
            this.RememberCk.Text = "Ingat Pengaturan";
            this.RememberCk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATABASE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "USERNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "PASSWORD";
            // 
            // ProsesBtn
            // 
            this.ProsesBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProsesBtn.Location = new System.Drawing.Point(123, 256);
            this.ProsesBtn.Name = "ProsesBtn";
            this.ProsesBtn.Size = new System.Drawing.Size(140, 43);
            this.ProsesBtn.TabIndex = 12;
            this.ProsesBtn.Text = "LOGIN";
            this.ProsesBtn.UseVisualStyleBackColor = true;
            this.ProsesBtn.Click += new System.EventHandler(this.ProsesBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.Controls.Add(this.ProsesBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RememberCk);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.DbTxt);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.ServerTxt);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: LOGIN ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.TextBox DbTxt;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.CheckBox RememberCk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ProsesBtn;
    }
}