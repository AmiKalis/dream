using System.Windows.Forms;
using Repository;
using Repository.Entities;
using System;

namespace Travel
{
    public partial class HotelForm : Form
    {
        public int HotelID { get; set; }

        private Type Type { get; set; }

        private HotelRepository HotelRepository { get; set; }
        public Hotel SelectedHotel { get; set; }

        private void VisibilityButtons()
        {
            SaveButton.Enabled = Type == Type.Insert || Type == Type.Update;
            DeleteButton.Enabled = HotelDataGridView.Rows.Count > 0 || Type == Type.Reload;
        }

        public HotelForm()
        {
            InitializeComponent();
            HotelRepository = new HotelRepository();
            UpdateButton_Click(null, null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Type = Type.Reload;
            VisibilityButtons();
            HotelDataGridView.DataSource = HotelRepository.Get();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            HotelDataGridView.ClearSelection();
            HotelDataGroupBox.Enabled = true;
            Type = Type.Insert;
            CountryTextBox.Focus();
            VisibilityButtons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (CountryTextBox.Text == "")
            {
                errorProvider1.SetError(CountryTextBox, "Заполните местоположение отеля");
                return;
            }
            if (NameHotelTextBox.Text == "")
            {
                errorProvider1.SetError(NameHotelTextBox, "Введите название отеля");
                return;
            }
            try
            {
                var hotel = new Hotel
                {
                    Country = CountryTextBox.Text,
                    City = CityTextBox.Text,
                    Name = NameHotelTextBox.Text,
                    Star = Convert.ToInt32(StarTextBox.Text),
                };
                
                if (Type == Type.Insert)
                {
                    HotelRepository.Insert(hotel);
                    MessageBox.Show($"Добавления нового отеля прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CountryTextBox.Focus();
                }
                else if (Type == Type.Update)
                {
                    hotel.ID = HotelID;
                    HotelRepository.Edit(hotel);
                    MessageBox.Show($"Изменение нового отеля прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HotelDataGroupBox.Enabled = false;
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
            if (HotelDataGridView.RowCount > 0)
            {
                try
                {
                    HotelRepository.Delete(HotelRepository.GetByID(SelectedHotel.ID));
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
            SelectedHotel = ((Hotel)HotelDataGridView.CurrentRow.DataBoundItem);
            Type = Type.Update;
            VisibilityButtons();
            HotelID = SelectedHotel.ID;
            CountryTextBox.Text = SelectedHotel.Country;
            CityTextBox.Text = SelectedHotel.City;
            NameHotelTextBox.Text = SelectedHotel.Name;
            StarTextBox.Text = SelectedHotel.Star.ToString();
        }
    }
}
