using System.Windows.Forms;
using System;
using Repository;
using Repository.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Travel
{
    public partial class OrderForm : Form
    {
        public int OrderID { get; set; }

        private Type Type { get; set; }

        public OrderRepository OrderRepository;
        public Order SelectedOrder { get; set; }

        private void VisibilityButtons()
        {
            SaveButton.Enabled   = Type == Type.Insert || Type == Type.Update;
            DeleteButton.Enabled = OrderDataGridView.Rows.Count > 0 || Type == Type.Reload;
        }

        public OrderForm()
        {
            InitializeComponent();
            OrderRepository = new OrderRepository();
            ClientComboBox.DataSource = new ClientRepository().Get();
            TouroperatorComboBox.DataSource = new TouroperatorRepository().Get();
            TourComboBox.DataSource = new TourRepository().Get();
            UpdateButton_Click(null, null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Type = Type.Reload;
            OrderDataGridView.DataSource = OrderRepository.Get();
            VisibilityButtons();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            OrderDataGridView.ClearSelection();
            Type = Type.Insert;
            CostTextBox.Focus();
            VisibilityButtons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (CostTextBox.Text == "")
            {
                errorProvider1.SetError(CostTextBox, "Заполните данные");
                return;
            }
            try
            {
                var order = new Order
                {
                    Client = new Client()
                    {
                       ID = (int)ClientComboBox.SelectedValue
                    },
                    Touroperator = new Touroperator()
                    {
                        ID = (int)TouroperatorComboBox.SelectedValue
                    },
                    Tour = new Tour()
                    {
                        ID = (int)TourComboBox.SelectedValue
                    },
                    DateDeparture = Convert.ToDateTime(DepartureDateTimePicker.Value),
                    DateArrival = Convert.ToDateTime(ArrivalDateTimePicker.Value),
                    Cost = Convert.ToInt32(CostTextBox.Text),
                };

                if (Type == Type.Insert)
                {
                    OrderRepository.Insert(order);
                    MessageBox.Show($"Добавления нового заказа прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CostTextBox.Focus();
                }
                else if (Type == Type.Update)
                {
                    order.ID = OrderID;
                    OrderRepository.Edit(order);
                    MessageBox.Show($"Изменение заказа прошло успешно", @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (OrderDataGridView.RowCount > 0)
            {
                try
                {
                    OrderRepository.Delete(OrderRepository.GetByID(SelectedOrder.ID));
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

        private void OrderSelectionChanged(object sender, EventArgs e)
        {
            SelectedOrder = ((Order)OrderDataGridView.CurrentRow.DataBoundItem);
            Type = Type.Update;
            VisibilityButtons();
            OrderID = SelectedOrder.ID;
            ClientComboBox.SelectedIndex = ClientComboBox.Items.IndexOf(((List<Client>)ClientComboBox.DataSource).First(x => x.ID == SelectedOrder.Client.ID));
            TouroperatorComboBox.SelectedIndex = TouroperatorComboBox.Items.IndexOf(((List<Touroperator>)TouroperatorComboBox.DataSource).First(x => x.ID == SelectedOrder.Touroperator.ID));
            TourComboBox.SelectedIndex = TourComboBox.Items.IndexOf(((List<Tour>)TourComboBox.DataSource).First(x => x.ID == SelectedOrder.Tour.ID));
            DepartureDateTimePicker.Value = SelectedOrder.DateDeparture;
            ArrivalDateTimePicker.Value = SelectedOrder.DateArrival;
            CostTextBox.Text = Convert.ToString(SelectedOrder.Cost);
        }
    }
}
