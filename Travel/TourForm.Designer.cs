namespace Travel
{
    partial class TourForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TourDataGroupBox = new System.Windows.Forms.GroupBox();
            this.TourDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Направление = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Экскурсии = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Транпорт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Питание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourGroupBox = new System.Windows.Forms.GroupBox();
            this.ExcursionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HotelComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodCheckBox = new System.Windows.Forms.CheckBox();
            this.TransferCheckBox = new System.Windows.Forms.CheckBox();
            this.DirectionTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TourDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourDataGridView)).BeginInit();
            this.TourGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TourDataGroupBox
            // 
            this.TourDataGroupBox.Controls.Add(this.TourDataGridView);
            this.TourDataGroupBox.Location = new System.Drawing.Point(13, 7);
            this.TourDataGroupBox.Name = "TourDataGroupBox";
            this.TourDataGroupBox.Size = new System.Drawing.Size(710, 242);
            this.TourDataGroupBox.TabIndex = 47;
            this.TourDataGroupBox.TabStop = false;
            this.TourDataGroupBox.Text = "Информация";
            // 
            // TourDataGridView
            // 
            this.TourDataGridView.AllowUserToAddRows = false;
            this.TourDataGridView.AllowUserToDeleteRows = false;
            this.TourDataGridView.AllowUserToResizeColumns = false;
            this.TourDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.TourDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TourDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TourDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TourDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TourDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Отель,
            this.Направление,
            this.Экскурсии,
            this.Транпорт,
            this.Питание});
            this.TourDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TourDataGridView.Location = new System.Drawing.Point(3, 16);
            this.TourDataGridView.Name = "TourDataGridView";
            this.TourDataGridView.ReadOnly = true;
            this.TourDataGridView.RowHeadersVisible = false;
            this.TourDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TourDataGridView.Size = new System.Drawing.Size(704, 223);
            this.TourDataGridView.TabIndex = 0;
            this.TourDataGridView.SelectionChanged += new System.EventHandler(this.HotelSelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID:";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Отель
            // 
            this.Отель.DataPropertyName = "Hotel";
            this.Отель.HeaderText = "Отель:";
            this.Отель.Name = "Отель";
            this.Отель.ReadOnly = true;
            this.Отель.Width = 150;
            // 
            // Направление
            // 
            this.Направление.DataPropertyName = "direction";
            this.Направление.HeaderText = "Направление:";
            this.Направление.Name = "Направление";
            this.Направление.ReadOnly = true;
            this.Направление.Width = 150;
            // 
            // Экскурсии
            // 
            this.Экскурсии.DataPropertyName = "exursion";
            this.Экскурсии.HeaderText = "Количество экскурсий:";
            this.Экскурсии.Name = "Экскурсии";
            this.Экскурсии.ReadOnly = true;
            // 
            // Транпорт
            // 
            this.Транпорт.DataPropertyName = "transfer";
            this.Транпорт.HeaderText = "Наличие транспорта:";
            this.Транпорт.Name = "Транпорт";
            this.Транпорт.ReadOnly = true;
            // 
            // Питание
            // 
            this.Питание.DataPropertyName = "food";
            this.Питание.HeaderText = "Наличие питания:";
            this.Питание.Name = "Питание";
            this.Питание.ReadOnly = true;
            // 
            // TourGroupBox
            // 
            this.TourGroupBox.Controls.Add(this.ExcursionNumericUpDown);
            this.TourGroupBox.Controls.Add(this.HotelComboBox);
            this.TourGroupBox.Controls.Add(this.label5);
            this.TourGroupBox.Controls.Add(this.label4);
            this.TourGroupBox.Controls.Add(this.label3);
            this.TourGroupBox.Controls.Add(this.label2);
            this.TourGroupBox.Controls.Add(this.label1);
            this.TourGroupBox.Controls.Add(this.FoodCheckBox);
            this.TourGroupBox.Controls.Add(this.TransferCheckBox);
            this.TourGroupBox.Controls.Add(this.DirectionTextBox);
            this.TourGroupBox.Location = new System.Drawing.Point(728, 12);
            this.TourGroupBox.Name = "TourGroupBox";
            this.TourGroupBox.Size = new System.Drawing.Size(309, 188);
            this.TourGroupBox.TabIndex = 40;
            this.TourGroupBox.TabStop = false;
            this.TourGroupBox.Text = "Добавление или изменение информации";
            // 
            // ExcursionNumericUpDown
            // 
            this.ExcursionNumericUpDown.Location = new System.Drawing.Point(144, 95);
            this.ExcursionNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExcursionNumericUpDown.Name = "ExcursionNumericUpDown";
            this.ExcursionNumericUpDown.Size = new System.Drawing.Size(145, 20);
            this.ExcursionNumericUpDown.TabIndex = 30;
            // 
            // HotelComboBox
            // 
            this.HotelComboBox.DisplayMember = "ID";
            this.HotelComboBox.FormattingEnabled = true;
            this.HotelComboBox.Location = new System.Drawing.Point(144, 41);
            this.HotelComboBox.Name = "HotelComboBox";
            this.HotelComboBox.Size = new System.Drawing.Size(145, 21);
            this.HotelComboBox.TabIndex = 29;
            this.HotelComboBox.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Еда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Трансфер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Экскурсии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Отель";
            // 
            // FoodCheckBox
            // 
            this.FoodCheckBox.AutoSize = true;
            this.FoodCheckBox.Location = new System.Drawing.Point(173, 127);
            this.FoodCheckBox.Name = "FoodCheckBox";
            this.FoodCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FoodCheckBox.TabIndex = 23;
            this.FoodCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransferCheckBox
            // 
            this.TransferCheckBox.AutoSize = true;
            this.TransferCheckBox.Location = new System.Drawing.Point(84, 126);
            this.TransferCheckBox.Name = "TransferCheckBox";
            this.TransferCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TransferCheckBox.TabIndex = 22;
            this.TransferCheckBox.UseVisualStyleBackColor = true;
            // 
            // DirectionTextBox
            // 
            this.DirectionTextBox.Location = new System.Drawing.Point(144, 69);
            this.DirectionTextBox.Name = "DirectionTextBox";
            this.DirectionTextBox.Size = new System.Drawing.Size(145, 20);
            this.DirectionTextBox.TabIndex = 19;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(937, 206);
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
            this.CreateButton.Location = new System.Drawing.Point(725, 206);
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
            this.SaveButton.Location = new System.Drawing.Point(831, 206);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 261);
            this.Controls.Add(this.TourDataGroupBox);
            this.Controls.Add(this.TourGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мечта - Туры";
            this.TourDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TourDataGridView)).EndInit();
            this.TourGroupBox.ResumeLayout(false);
            this.TourGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TourDataGroupBox;
        private System.Windows.Forms.DataGridView TourDataGridView;
        private System.Windows.Forms.GroupBox TourGroupBox;
        private System.Windows.Forms.ComboBox HotelComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FoodCheckBox;
        private System.Windows.Forms.CheckBox TransferCheckBox;
        private System.Windows.Forms.TextBox DirectionTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.NumericUpDown ExcursionNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Направление;
        private System.Windows.Forms.DataGridViewTextBoxColumn Экскурсии;
        private System.Windows.Forms.DataGridViewTextBoxColumn Транпорт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Питание;
    }
}