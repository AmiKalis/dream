using System;
using System.Windows.Forms;
using Repository;
using Repository.Entities;

namespace Travel
{
    public partial class ClientForm : Form
    {
        public int ClientID { get; set; }
        
        public Type Type { get; set; }

        public ClientRepository ClientRepository { get; set; }
        public Client SelectedClient { get; set; }

        private void VisibilityButtons()
        {
            SaveButton.Enabled   = Type == Type.Insert || Type == Type.Update;
            DeleteButton.Enabled = ClientDataGridView.Rows.Count > 0 || Type == Type.Reload;
        }

        public ClientForm()
        {
            InitializeComponent();
            ClientRepository = new ClientRepository();
            UpdateButton_Click(null,null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Type = Type.Reload;
            ClientDataGridView.DataSource = ClientRepository.Get();
            VisibilityButtons();
            ClientDataGroupBox.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ClientDataGridView.ClearSelection();
            Type = Type.Insert;
            ClientDataGroupBox.Enabled = true;
            FIOTextBox.Focus();
            VisibilityButtons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (FIOTextBox.Text == "")
            {
                errorProvider1.SetError(FIOTextBox, "Заполните данные");
                return;
            }
            if (PhoneTextBox.Text == "")
            {
                errorProvider1.SetError(PhoneTextBox, "Введите номер телефона");
                return;
            }
            try
            {
                var client = new Client
                {
                    Fio = FIOTextBox.Text,
                    Address = AddressTextBox.Text,
                    Phone = Convert.ToInt32(PhoneTextBox.Text),
                    Email = EmailTextBox.Text,
                    DateOfBirth = Convert.ToDateTime(BirthdayDatePicker.Value),
                    Children = HasChildrenCheckBox.Checked,
                    Animal = HasAnimalheckBox.Checked,
                };                
                
                if (Type == Type.Insert)
                {
                    ClientRepository.Insert(client);
                    MessageBox.Show(@"Добавления нового клиента прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FIOTextBox.Focus();
                }
                else if (Type == Type.Update)
                {
                    client.ID = ClientID;
                    ClientRepository.Edit(client);
                    MessageBox.Show(@"Изменение клиента прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClientDataGroupBox.Enabled = false;
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
            if (ClientDataGridView.RowCount > 0)
            {
                try
                {
                    ClientRepository.Delete(ClientRepository.GetByID(SelectedClient.ID));
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

        private void ClientSelectionChanged(object sender, EventArgs e)
        {
            SelectedClient = ((Client)ClientDataGridView.CurrentRow.DataBoundItem);
            Type = Type.Update;
            ClientDataGroupBox.Enabled = true;
            VisibilityButtons();
            ClientID = SelectedClient.ID;
            FIOTextBox.Text = SelectedClient.Fio;
            AddressTextBox.Text = SelectedClient.Address;
            PhoneTextBox.Text = SelectedClient.Phone.ToString();
            EmailTextBox.Text = SelectedClient.Email;
            BirthdayDatePicker.Value = SelectedClient.DateOfBirth;
            HasChildrenCheckBox.Checked = SelectedClient.Children;
            HasAnimalheckBox.Checked = SelectedClient.Animal;
        }
    }
}
