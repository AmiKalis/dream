namespace Travel
{
    partial class TouroperatorForm
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
            this.TouroperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TouroperatorDataGroupBox = new System.Windows.Forms.GroupBox();
            this.TouroperatorDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеТуроператора = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Электроная_почта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TouroperatorGroupBox.SuspendLayout();
            this.TouroperatorDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TouroperatorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TouroperatorGroupBox
            // 
            this.TouroperatorGroupBox.Controls.Add(this.label4);
            this.TouroperatorGroupBox.Controls.Add(this.label3);
            this.TouroperatorGroupBox.Controls.Add(this.label2);
            this.TouroperatorGroupBox.Controls.Add(this.label1);
            this.TouroperatorGroupBox.Controls.Add(this.EmailTextBox);
            this.TouroperatorGroupBox.Controls.Add(this.PhoneTextBox);
            this.TouroperatorGroupBox.Controls.Add(this.AddressTextBox);
            this.TouroperatorGroupBox.Controls.Add(this.NameTextBox);
            this.TouroperatorGroupBox.Location = new System.Drawing.Point(738, 12);
            this.TouroperatorGroupBox.Name = "TouroperatorGroupBox";
            this.TouroperatorGroupBox.Size = new System.Drawing.Size(299, 185);
            this.TouroperatorGroupBox.TabIndex = 39;
            this.TouroperatorGroupBox.TabStop = false;
            this.TouroperatorGroupBox.Text = "Добавление или изменение информации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Электронная почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название туроператора";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(141, 122);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(145, 20);
            this.EmailTextBox.TabIndex = 21;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(141, 96);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.PhoneTextBox.TabIndex = 20;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(141, 68);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.AddressTextBox.TabIndex = 19;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 18;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(937, 203);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 44;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(725, 203);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 40);
            this.CreateButton.TabIndex = 41;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(831, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 42;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TouroperatorDataGroupBox
            // 
            this.TouroperatorDataGroupBox.Controls.Add(this.TouroperatorDataGridView);
            this.TouroperatorDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TouroperatorDataGroupBox.Name = "TouroperatorDataGroupBox";
            this.TouroperatorDataGroupBox.Size = new System.Drawing.Size(710, 237);
            this.TouroperatorDataGroupBox.TabIndex = 46;
            this.TouroperatorDataGroupBox.TabStop = false;
            this.TouroperatorDataGroupBox.Text = "Информация";
            // 
            // TouroperatorDataGridView
            // 
            this.TouroperatorDataGridView.AllowUserToAddRows = false;
            this.TouroperatorDataGridView.AllowUserToDeleteRows = false;
            this.TouroperatorDataGridView.AllowUserToResizeColumns = false;
            this.TouroperatorDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.TouroperatorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TouroperatorDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TouroperatorDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TouroperatorDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TouroperatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TouroperatorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.НазваниеТуроператора,
            this.Адрес,
            this.Телефон,
            this.Электроная_почта});
            this.TouroperatorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TouroperatorDataGridView.Location = new System.Drawing.Point(3, 16);
            this.TouroperatorDataGridView.Name = "TouroperatorDataGridView";
            this.TouroperatorDataGridView.ReadOnly = true;
            this.TouroperatorDataGridView.RowHeadersVisible = false;
            this.TouroperatorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TouroperatorDataGridView.Size = new System.Drawing.Size(704, 218);
            this.TouroperatorDataGridView.TabIndex = 0;
            this.TouroperatorDataGridView.SelectionChanged += new System.EventHandler(this.TouroperatorSelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID:";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // НазваниеТуроператора
            // 
            this.НазваниеТуроператора.DataPropertyName = "name";
            this.НазваниеТуроператора.HeaderText = "Название туроператора:";
            this.НазваниеТуроператора.Name = "НазваниеТуроператора";
            this.НазваниеТуроператора.ReadOnly = true;
            this.НазваниеТуроператора.Width = 200;
            // 
            // Адрес
            // 
            this.Адрес.DataPropertyName = "address";
            this.Адрес.HeaderText = "Адрес:";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            this.Адрес.Width = 150;
            // 
            // Телефон
            // 
            this.Телефон.DataPropertyName = "phone";
            this.Телефон.HeaderText = "Телефон:";
            this.Телефон.Name = "Телефон";
            this.Телефон.ReadOnly = true;
            this.Телефон.Width = 150;
            // 
            // Электроная_почта
            // 
            this.Электроная_почта.DataPropertyName = "email";
            this.Электроная_почта.HeaderText = "Электроная почта:";
            this.Электроная_почта.Name = "Электроная_почта";
            this.Электроная_почта.ReadOnly = true;
            this.Электроная_почта.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TouroperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 261);
            this.Controls.Add(this.TouroperatorDataGroupBox);
            this.Controls.Add(this.TouroperatorGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TouroperatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Туроператоры";
            this.TouroperatorGroupBox.ResumeLayout(false);
            this.TouroperatorGroupBox.PerformLayout();
            this.TouroperatorDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TouroperatorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox TouroperatorGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox TouroperatorDataGroupBox;
        private System.Windows.Forms.DataGridView TouroperatorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеТуроператора;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Электроная_почта;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}