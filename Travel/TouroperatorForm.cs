using Repository;
using Repository.Entities;
using System;
using System.Windows.Forms;

namespace Travel
{
    public partial class TouroperatorForm : Form
    {
        public int TouroperatorID { get; set; }

        private Type Type { get; set; }

        private TouroperatorRepository TouroperatorRepository { get; set; }
        public Touroperator SeletedTouroperator { get; set; }

        private void VisibilityButtons()
        {
            SaveButton.Enabled = Type == Type.Insert || Type == Type.Update;
            DeleteButton.Enabled = TouroperatorDataGridView.Rows.Count > 0 || Type == Type.Reload;
        }

        public TouroperatorForm()
        {
            InitializeComponent();
            TouroperatorRepository = new TouroperatorRepository();
            UpdateButton_Click(null, null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Type = Type.Reload;
            TouroperatorDataGridView.DataSource = TouroperatorRepository.Get();
            VisibilityButtons();
            TouroperatorGroupBox.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TouroperatorDataGridView.ClearSelection();
            Type = Type.Insert;
            TouroperatorGroupBox.Enabled = true;
            NameTextBox.Focus();
            VisibilityButtons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (NameTextBox.Text == "")
            {
                errorProvider1.SetError(NameTextBox, "Заполните название туроператора");
                return;
            }
            if (PhoneTextBox.Text == "")
            {
                errorProvider1.SetError(PhoneTextBox, "Введите номер телефона");
                return;
            }
            try
            {
                var tourperator = new Touroperator
                {
                    Name = NameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Phone = Convert.ToInt32(PhoneTextBox.Text),
                    Email = EmailTextBox.Text,
                };
                
                if (Type == Type.Insert)
                {
                    TouroperatorRepository.Insert(tourperator);
                    MessageBox.Show($"Добавления нового туроператора прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameTextBox.Focus();
                }
                else if (Type == Type.Update)
                {
                    tourperator.ID = TouroperatorID;
                    TouroperatorRepository.Edit(tourperator);
                    MessageBox.Show($"Изменение нового туроператора прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TouroperatorGroupBox.Enabled = false;
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
            if (TouroperatorDataGridView.RowCount > 0)
            {
                try
                {
                    TouroperatorRepository.Delete(TouroperatorRepository.GetByID(SeletedTouroperator.ID));
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

        private void TouroperatorSelectionChanged(object sender, EventArgs e)
        {
            SeletedTouroperator = ((Touroperator)TouroperatorDataGridView.CurrentRow.DataBoundItem);
            Type = Type.Update;
            TouroperatorGroupBox.Enabled = true;
            VisibilityButtons();
            TouroperatorID = SeletedTouroperator.ID;
            NameTextBox.Text = SeletedTouroperator.Name;
            AddressTextBox.Text = SeletedTouroperator.Address;
            PhoneTextBox.Text = SeletedTouroperator.Phone.ToString();
            EmailTextBox.Text = SeletedTouroperator.Email;
        }
    }
}
