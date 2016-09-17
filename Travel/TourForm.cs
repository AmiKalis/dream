using System.Windows.Forms;
using System;
using Repository;
using Repository.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Travel
{
    public partial class TourForm : Form
    {
        public int TourID { get; set; }

        public Type Type { get; set; }
        public TourRepository TourRepository { get; set; }
        public Tour SelectedTour { get; set; }

        void VisibilityButtons()
        {
            SaveButton.Enabled = Type == Type.Insert || Type == Type.Update;
            DeleteButton.Enabled = TourDataGridView.Rows.Count > 0 || Type == Type.Reload;
        }

        public TourForm()
        {
            InitializeComponent();
            TourRepository = new TourRepository();
            HotelComboBox.DataSource = new HotelRepository().Get();
            UpdateButton_Click(null, null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Type = Type.Reload;
            TourDataGridView.DataSource = TourRepository.Get();
            VisibilityButtons();
            TourGroupBox.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TourDataGridView.ClearSelection();
            Type = Type.Insert;
            TourGroupBox.Enabled = true;
            DirectionTextBox.Focus();
            VisibilityButtons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            if (DirectionTextBox.Text == "")
            {
                ErrorProvider.SetError(DirectionTextBox, "Заполните данные");
                return;
            }
            try
            {
                var tour = new Tour
                {
                    Direction = DirectionTextBox.Text.Trim(),
                    Excursion = (short)ExcursionNumericUpDown.Value,
                    Transfer = TransferCheckBox.Checked,
                    Food = FoodCheckBox.Checked,
                    Hotel = new Hotel
                    {
                        ID = (int)HotelComboBox.SelectedValue
                    },
                };

                if (Type == Type.Insert)
                {
                    TourRepository.Insert(tour);
                    MessageBox.Show($"Добавления нового тура прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DirectionTextBox.Focus();
                }
                else if (Type == Type.Update)
                {
                    tour.ID = TourID;
                    TourRepository.Edit(tour);
                    MessageBox.Show($"Изменение тура прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Type = Type.Reload;
                VisibilityButtons();
            }
            catch (Exception ex)
            {
                if (Type == Type.Insert)
                    MessageBox.Show($"Ошибка добавления: {ex.Message}", @"Добавить", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Type == Type.Update)
                    MessageBox.Show($"Ошибка изменения: {ex.Message}", @"Изменить", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateButton_Click(null, null);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (TourDataGridView.RowCount > 0)
            {
                try
                {
                    TourRepository.Delete(TourRepository.GetByID(SelectedTour.ID));
                    MessageBox.Show(@"Удаление прошло успешно", @"Инфрмация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", @"Удалить", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    UpdateButton_Click(null, null);
                }
            }
        }

        private void HotelSelectionChanged(object sender, EventArgs e)
        {
            SelectedTour = ((Tour)TourDataGridView.CurrentRow.DataBoundItem);
            Type = Type.Update;
            TourGroupBox.Enabled = true;
            VisibilityButtons();
            TourID = SelectedTour.ID;
            HotelComboBox.SelectedIndex = HotelComboBox.Items.IndexOf(((List<Hotel>)HotelComboBox.DataSource).First(x => x.ID == SelectedTour.Hotel.ID));
            DirectionTextBox.Text = SelectedTour.Direction;
            ExcursionNumericUpDown.Value = SelectedTour.Excursion;
            TransferCheckBox.Checked = SelectedTour.Transfer;
            FoodCheckBox.Checked = SelectedTour.Food;
        }
        
    }
}
