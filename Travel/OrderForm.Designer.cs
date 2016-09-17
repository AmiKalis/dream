namespace Travel
{
    partial class OrderForm
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
            this.OrderDataGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Туроператор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тур = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_отправления = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_прибытия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TouroperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TourComboBox = new System.Windows.Forms.ComboBox();
            this.TouroperatorComboBox = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.ArrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OrderDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.TouroperatorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGroupBox
            // 
            this.OrderDataGroupBox.Controls.Add(this.OrderDataGridView);
            this.OrderDataGroupBox.Location = new System.Drawing.Point(12, 7);
            this.OrderDataGroupBox.Name = "OrderDataGroupBox";
            this.OrderDataGroupBox.Size = new System.Drawing.Size(710, 242);
            this.OrderDataGroupBox.TabIndex = 47;
            this.OrderDataGroupBox.TabStop = false;
            this.OrderDataGroupBox.Text = "Информация";
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.AllowUserToDeleteRows = false;
            this.OrderDataGridView.AllowUserToResizeColumns = false;
            this.OrderDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.OrderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.Клиент,
            this.Туроператор,
            this.Тур,
            this.Дата_отправления,
            this.Дата_прибытия,
            this.Стоимость});
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridView.Location = new System.Drawing.Point(3, 16);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.RowHeadersVisible = false;
            this.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGridView.Size = new System.Drawing.Size(704, 223);
            this.OrderDataGridView.TabIndex = 0;
            this.OrderDataGridView.SelectionChanged += new System.EventHandler(this.OrderSelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID:";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 25;
            // 
            // Клиент
            // 
            this.Клиент.DataPropertyName = "Client";
            this.Клиент.HeaderText = "Клиент:";
            this.Клиент.Name = "Клиент";
            this.Клиент.ReadOnly = true;
            this.Клиент.Width = 200;
            // 
            // Туроператор
            // 
            this.Туроператор.DataPropertyName = "Touroperator";
            this.Туроператор.HeaderText = "Туроператор:";
            this.Туроператор.Name = "Туроператор";
            this.Туроператор.ReadOnly = true;
            // 
            // Тур
            // 
            this.Тур.DataPropertyName = "Tour";
            this.Тур.HeaderText = "Тур:";
            this.Тур.Name = "Тур";
            this.Тур.ReadOnly = true;
            // 
            // Дата_отправления
            // 
            this.Дата_отправления.DataPropertyName = "DateDeparture";
            this.Дата_отправления.HeaderText = "Дата отправления:";
            this.Дата_отправления.Name = "Дата_отправления";
            this.Дата_отправления.ReadOnly = true;
            // 
            // Дата_прибытия
            // 
            this.Дата_прибытия.DataPropertyName = "DateArrival";
            this.Дата_прибытия.HeaderText = "Дата прибытия:";
            this.Дата_прибытия.Name = "Дата_прибытия";
            this.Дата_прибытия.ReadOnly = true;
            // 
            // Стоимость
            // 
            this.Стоимость.DataPropertyName = "cost";
            this.Стоимость.HeaderText = "Стоимость:";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Width = 70;
            // 
            // TouroperatorGroupBox
            // 
            this.TouroperatorGroupBox.Controls.Add(this.DepartureDateTimePicker);
            this.TouroperatorGroupBox.Controls.Add(this.TourComboBox);
            this.TouroperatorGroupBox.Controls.Add(this.TouroperatorComboBox);
            this.TouroperatorGroupBox.Controls.Add(this.ClientComboBox);
            this.TouroperatorGroupBox.Controls.Add(this.ArrivalDateTimePicker);
            this.TouroperatorGroupBox.Controls.Add(this.label6);
            this.TouroperatorGroupBox.Controls.Add(this.label5);
            this.TouroperatorGroupBox.Controls.Add(this.label4);
            this.TouroperatorGroupBox.Controls.Add(this.label3);
            this.TouroperatorGroupBox.Controls.Add(this.label2);
            this.TouroperatorGroupBox.Controls.Add(this.label1);
            this.TouroperatorGroupBox.Controls.Add(this.CostTextBox);
            this.TouroperatorGroupBox.Location = new System.Drawing.Point(728, 12);
            this.TouroperatorGroupBox.Name = "TouroperatorGroupBox";
            this.TouroperatorGroupBox.Size = new System.Drawing.Size(309, 195);
            this.TouroperatorGroupBox.TabIndex = 40;
            this.TouroperatorGroupBox.TabStop = false;
            this.TouroperatorGroupBox.Text = "Добавление или изменение информации";
            // 
            // DepartureDateTimePicker
            // 
            this.DepartureDateTimePicker.Location = new System.Drawing.Point(159, 107);
            this.DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            this.DepartureDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.DepartureDateTimePicker.TabIndex = 35;
            // 
            // TourComboBox
            // 
            this.TourComboBox.DisplayMember = "ID";
            this.TourComboBox.FormattingEnabled = true;
            this.TourComboBox.Location = new System.Drawing.Point(159, 80);
            this.TourComboBox.Name = "TourComboBox";
            this.TourComboBox.Size = new System.Drawing.Size(145, 21);
            this.TourComboBox.TabIndex = 34;
            this.TourComboBox.ValueMember = "ID";
            // 
            // TouroperatorComboBox
            // 
            this.TouroperatorComboBox.DisplayMember = "ID";
            this.TouroperatorComboBox.FormattingEnabled = true;
            this.TouroperatorComboBox.Location = new System.Drawing.Point(159, 53);
            this.TouroperatorComboBox.Name = "TouroperatorComboBox";
            this.TouroperatorComboBox.Size = new System.Drawing.Size(145, 21);
            this.TouroperatorComboBox.TabIndex = 33;
            this.TouroperatorComboBox.ValueMember = "ID";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.DisplayMember = "Fio";
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(159, 25);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(145, 21);
            this.ClientComboBox.TabIndex = 32;
            this.ClientComboBox.ValueMember = "ID";
            // 
            // ArrivalDateTimePicker
            // 
            this.ArrivalDateTimePicker.Location = new System.Drawing.Point(159, 133);
            this.ArrivalDateTimePicker.Name = "ArrivalDateTimePicker";
            this.ArrivalDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.ArrivalDateTimePicker.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тур";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Дата прибытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата убытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Туроператор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Клиент";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(159, 159);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(145, 20);
            this.CostTextBox.TabIndex = 21;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(937, 209);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 45;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(726, 209);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 40);
            this.CreateButton.TabIndex = 42;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(834, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 261);
            this.Controls.Add(this.OrderDataGroupBox);
            this.Controls.Add(this.TouroperatorGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Заказы";
            this.OrderDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.TouroperatorGroupBox.ResumeLayout(false);
            this.TouroperatorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderDataGroupBox;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.GroupBox TouroperatorGroupBox;
        private System.Windows.Forms.DateTimePicker DepartureDateTimePicker;
        private System.Windows.Forms.ComboBox TourComboBox;
        private System.Windows.Forms.ComboBox TouroperatorComboBox;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.DateTimePicker ArrivalDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Клиент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Туроператор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тур;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_отправления;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_прибытия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
    }
}