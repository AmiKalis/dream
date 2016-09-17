namespace Travel
{
    partial class HotelForm
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
            var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HotelDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StarTextBox = new System.Windows.Forms.TextBox();
            this.NameHotelTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.HotelGroupBox = new System.Windows.Forms.GroupBox();
            this.HotelDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Страна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Город = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеОтеля = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Звезды = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HotelDataGroupBox.SuspendLayout();
            this.HotelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelDataGroupBox
            // 
            this.HotelDataGroupBox.Controls.Add(this.label4);
            this.HotelDataGroupBox.Controls.Add(this.label3);
            this.HotelDataGroupBox.Controls.Add(this.label2);
            this.HotelDataGroupBox.Controls.Add(this.label1);
            this.HotelDataGroupBox.Controls.Add(this.StarTextBox);
            this.HotelDataGroupBox.Controls.Add(this.NameHotelTextBox);
            this.HotelDataGroupBox.Controls.Add(this.CityTextBox);
            this.HotelDataGroupBox.Controls.Add(this.CountryTextBox);
            this.HotelDataGroupBox.Location = new System.Drawing.Point(728, 12);
            this.HotelDataGroupBox.Name = "HotelDataGroupBox";
            this.HotelDataGroupBox.Size = new System.Drawing.Size(304, 185);
            this.HotelDataGroupBox.TabIndex = 3;
            this.HotelDataGroupBox.TabStop = false;
            this.HotelDataGroupBox.Text = "Добавление или изменение информации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Звезды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название отеля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Страна";
            // 
            // StarTextBox
            // 
            this.StarTextBox.Location = new System.Drawing.Point(140, 125);
            this.StarTextBox.Name = "StarTextBox";
            this.StarTextBox.Size = new System.Drawing.Size(145, 20);
            this.StarTextBox.TabIndex = 21;
            // 
            // NameHotelTextBox
            // 
            this.NameHotelTextBox.Location = new System.Drawing.Point(140, 99);
            this.NameHotelTextBox.Name = "NameHotelTextBox";
            this.NameHotelTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameHotelTextBox.TabIndex = 20;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(140, 71);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(145, 20);
            this.CityTextBox.TabIndex = 19;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(140, 44);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(145, 20);
            this.CountryTextBox.TabIndex = 18;
            // 
            // HotelGroupBox
            // 
            this.HotelGroupBox.Controls.Add(this.HotelDataGridView);
            this.HotelGroupBox.Location = new System.Drawing.Point(12, 7);
            this.HotelGroupBox.Name = "HotelGroupBox";
            this.HotelGroupBox.Size = new System.Drawing.Size(710, 242);
            this.HotelGroupBox.TabIndex = 2;
            this.HotelGroupBox.TabStop = false;
            this.HotelGroupBox.Text = "Информация";
            // 
            // HotelDataGridView
            // 
            this.HotelDataGridView.AllowUserToAddRows = false;
            this.HotelDataGridView.AllowUserToDeleteRows = false;
            this.HotelDataGridView.AllowUserToResizeColumns = false;
            this.HotelDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.HotelDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HotelDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HotelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.HotelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HotelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Страна,
            this.Город,
            this.НазваниеОтеля,
            this.Звезды});
            this.HotelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelDataGridView.Location = new System.Drawing.Point(3, 16);
            this.HotelDataGridView.Name = "HotelDataGridView";
            this.HotelDataGridView.ReadOnly = true;
            this.HotelDataGridView.RowHeadersVisible = false;
            this.HotelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HotelDataGridView.Size = new System.Drawing.Size(704, 223);
            this.HotelDataGridView.TabIndex = 0;
            this.HotelDataGridView.SelectionChanged += new System.EventHandler(this.HotelSelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID:";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Страна
            // 
            this.Страна.DataPropertyName = "country";
            this.Страна.HeaderText = "Страна:";
            this.Страна.Name = "Страна";
            this.Страна.ReadOnly = true;
            this.Страна.Width = 150;
            // 
            // Город
            // 
            this.Город.DataPropertyName = "city";
            this.Город.HeaderText = "Город:";
            this.Город.Name = "Город";
            this.Город.ReadOnly = true;
            this.Город.Width = 150;
            // 
            // НазваниеОтеля
            // 
            this.НазваниеОтеля.DataPropertyName = "NameHotel";
            this.НазваниеОтеля.HeaderText = "Название отеля:";
            this.НазваниеОтеля.Name = "НазваниеОтеля";
            this.НазваниеОтеля.ReadOnly = true;
            this.НазваниеОтеля.Width = 200;
            // 
            // Звезды
            // 
            this.Звезды.DataPropertyName = "star";
            this.Звезды.HeaderText = "Звезды:";
            this.Звезды.Name = "Звезды";
            this.Звезды.ReadOnly = true;
            this.Звезды.Width = 150;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(937, 203);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 42;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(723, 203);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 40);
            this.CreateButton.TabIndex = 39;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(829, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 40;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 261);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HotelDataGroupBox);
            this.Controls.Add(this.HotelGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Отели";
            this.HotelDataGroupBox.ResumeLayout(false);
            this.HotelDataGroupBox.PerformLayout();
            this.HotelGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HotelDataGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StarTextBox;
        private System.Windows.Forms.TextBox NameHotelTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.GroupBox HotelGroupBox;
        private System.Windows.Forms.DataGridView HotelDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Город;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеОтеля;
        private System.Windows.Forms.DataGridViewTextBoxColumn Звезды;
    }
}