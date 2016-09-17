namespace Travel
{
    partial class ClientForm
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
            var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientDataGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HasAnimalheckBox = new System.Windows.Forms.CheckBox();
            this.HasChildrenCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HotelGroupBox = new System.Windows.Forms.GroupBox();
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Электроная_почта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дети = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Животные = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.HotelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDataGroupBox
            // 
            this.ClientDataGroupBox.Controls.Add(this.BirthdayDatePicker);
            this.ClientDataGroupBox.Controls.Add(this.label7);
            this.ClientDataGroupBox.Controls.Add(this.label6);
            this.ClientDataGroupBox.Controls.Add(this.label5);
            this.ClientDataGroupBox.Controls.Add(this.label4);
            this.ClientDataGroupBox.Controls.Add(this.label3);
            this.ClientDataGroupBox.Controls.Add(this.label2);
            this.ClientDataGroupBox.Controls.Add(this.label1);
            this.ClientDataGroupBox.Controls.Add(this.HasAnimalheckBox);
            this.ClientDataGroupBox.Controls.Add(this.HasChildrenCheckBox);
            this.ClientDataGroupBox.Controls.Add(this.EmailTextBox);
            this.ClientDataGroupBox.Controls.Add(this.PhoneTextBox);
            this.ClientDataGroupBox.Controls.Add(this.AddressTextBox);
            this.ClientDataGroupBox.Controls.Add(this.FIOTextBox);
            this.ClientDataGroupBox.Location = new System.Drawing.Point(728, 25);
            this.ClientDataGroupBox.Name = "ClientDataGroupBox";
            this.ClientDataGroupBox.Size = new System.Drawing.Size(312, 179);
            this.ClientDataGroupBox.TabIndex = 1;
            this.ClientDataGroupBox.TabStop = false;
            this.ClientDataGroupBox.Text = "Добавление или изменение информации";
            // 
            // BirthdayDatePicker
            // 
            this.BirthdayDatePicker.Location = new System.Drawing.Point(142, 129);
            this.BirthdayDatePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.BirthdayDatePicker.Name = "BirthdayDatePicker";
            this.BirthdayDatePicker.Size = new System.Drawing.Size(145, 20);
            this.BirthdayDatePicker.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Животные (есть/нет)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Дети (есть/нет)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Электронная почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ФИО";
            // 
            // HasAnimalheckBox
            // 
            this.HasAnimalheckBox.AutoSize = true;
            this.HasAnimalheckBox.Location = new System.Drawing.Point(272, 155);
            this.HasAnimalheckBox.Name = "HasAnimalheckBox";
            this.HasAnimalheckBox.Size = new System.Drawing.Size(15, 14);
            this.HasAnimalheckBox.TabIndex = 23;
            this.HasAnimalheckBox.UseVisualStyleBackColor = true;
            // 
            // HasChildrenCheckBox
            // 
            this.HasChildrenCheckBox.AutoSize = true;
            this.HasChildrenCheckBox.Location = new System.Drawing.Point(111, 154);
            this.HasChildrenCheckBox.Name = "HasChildrenCheckBox";
            this.HasChildrenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HasChildrenCheckBox.TabIndex = 22;
            this.HasChildrenCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(142, 100);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(145, 20);
            this.EmailTextBox.TabIndex = 21;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(142, 74);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.PhoneTextBox.TabIndex = 20;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(142, 46);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.AddressTextBox.TabIndex = 19;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(142, 19);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(145, 20);
            this.FIOTextBox.TabIndex = 18;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(940, 210);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 36;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(834, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(728, 210);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 40);
            this.CreateButton.TabIndex = 33;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HotelGroupBox
            // 
            this.HotelGroupBox.Controls.Add(this.ClientDataGridView);
            this.HotelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.HotelGroupBox.Name = "HotelGroupBox";
            this.HotelGroupBox.Size = new System.Drawing.Size(710, 238);
            this.HotelGroupBox.TabIndex = 39;
            this.HotelGroupBox.TabStop = false;
            this.HotelGroupBox.Text = "Информация";
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.AllowUserToAddRows = false;
            this.ClientDataGridView.AllowUserToDeleteRows = false;
            this.ClientDataGridView.AllowUserToResizeColumns = false;
            this.ClientDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ФИО,
            this.Адрес,
            this.Телефон,
            this.Электроная_почта,
            this.Дата_рождения,
            this.Дети,
            this.Животные});
            this.ClientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.ReadOnly = true;
            this.ClientDataGridView.RowHeadersVisible = false;
            this.ClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGridView.Size = new System.Drawing.Size(704, 219);
            this.ClientDataGridView.TabIndex = 0;
            this.ClientDataGridView.SelectionChanged += new System.EventHandler(this.ClientSelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID:";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // ФИО
            // 
            this.ФИО.DataPropertyName = "FIO";
            this.ФИО.HeaderText = "Фамилия Имя Отчество:";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Width = 150;
            // 
            // Адрес
            // 
            this.Адрес.DataPropertyName = "address";
            this.Адрес.HeaderText = "Адрес:";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            // 
            // Телефон
            // 
            this.Телефон.DataPropertyName = "phone";
            this.Телефон.HeaderText = "Телефон:";
            this.Телефон.Name = "Телефон";
            this.Телефон.ReadOnly = true;
            // 
            // Электроная_почта
            // 
            this.Электроная_почта.DataPropertyName = "email";
            this.Электроная_почта.HeaderText = "Электроная почта:";
            this.Электроная_почта.Name = "Электроная_почта";
            this.Электроная_почта.ReadOnly = true;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.DataPropertyName = "DateOfBirth";
            this.Дата_рождения.HeaderText = "Дата рождения:";
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.ReadOnly = true;
            // 
            // Дети
            // 
            this.Дети.DataPropertyName = "children";
            this.Дети.HeaderText = "Дети:";
            this.Дети.Name = "Дети";
            this.Дети.ReadOnly = true;
            this.Дети.Width = 50;
            // 
            // Животные
            // 
            this.Животные.DataPropertyName = "animal";
            this.Животные.HeaderText = "Животные:";
            this.Животные.Name = "Животные";
            this.Животные.ReadOnly = true;
            this.Животные.Width = 70;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 261);
            this.Controls.Add(this.HotelGroupBox);
            this.Controls.Add(this.ClientDataGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Клиенты";
            this.ClientDataGroupBox.ResumeLayout(false);
            this.ClientDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.HotelGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ClientDataGroupBox;
        private System.Windows.Forms.DateTimePicker BirthdayDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox HasAnimalheckBox;
        private System.Windows.Forms.CheckBox HasChildrenCheckBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox HotelGroupBox;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Электроная_почта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дети;
        private System.Windows.Forms.DataGridViewTextBoxColumn Животные;
    }
}