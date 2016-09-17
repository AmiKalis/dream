namespace Travel
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TouroperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(118, 17);
            this.DateLabel.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimeUpdateTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.TouroperatorToolStripMenuItem,
            this.HotelToolStripMenuItem,
            this.TourToolStripMenuItem,
            this.OrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.BackgroundImage = global::Travel.Properties.Resources.travel;
            this.ClientToolStripMenuItem.Image = global::Travel.Properties.Resources.client;
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ClientToolStripMenuItem.Text = "Клиенты";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // TouroperatorToolStripMenuItem
            // 
            this.TouroperatorToolStripMenuItem.BackgroundImage = global::Travel.Properties.Resources.travel;
            this.TouroperatorToolStripMenuItem.Image = global::Travel.Properties.Resources.touroperator;
            this.TouroperatorToolStripMenuItem.Name = "TouroperatorToolStripMenuItem";
            this.TouroperatorToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.TouroperatorToolStripMenuItem.Text = "Туроператоры";
            this.TouroperatorToolStripMenuItem.Click += new System.EventHandler(this.TouroperatorToolStripMenuItem_Click);
            // 
            // HotelToolStripMenuItem
            // 
            this.HotelToolStripMenuItem.BackgroundImage = global::Travel.Properties.Resources.travel;
            this.HotelToolStripMenuItem.Image = global::Travel.Properties.Resources.hotel;
            this.HotelToolStripMenuItem.Name = "HotelToolStripMenuItem";
            this.HotelToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.HotelToolStripMenuItem.Text = "Отели";
            this.HotelToolStripMenuItem.Click += new System.EventHandler(this.HotelToolStripMenuItem_Click);
            // 
            // TourToolStripMenuItem
            // 
            this.TourToolStripMenuItem.BackgroundImage = global::Travel.Properties.Resources.travel;
            this.TourToolStripMenuItem.Image = global::Travel.Properties.Resources.tour;
            this.TourToolStripMenuItem.Name = "TourToolStripMenuItem";
            this.TourToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.TourToolStripMenuItem.Text = "Туры";
            this.TourToolStripMenuItem.Click += new System.EventHandler(this.TourToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.BackgroundImage = global::Travel.Properties.Resources.travel;
            this.OrderToolStripMenuItem.Image = global::Travel.Properties.Resources.order;
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.OrderToolStripMenuItem.Text = "Заказы";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Travel.Properties.Resources.travel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Туристическое Агентство";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel DateLabel;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TouroperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}