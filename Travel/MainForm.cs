using System;
using System.Windows.Forms;

namespace Travel
{
    public partial class MainForm : Form
    {
        public Timer Timer { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Timer = new Timer
            {
                Interval = 1000
            };
            Timer.Tick += new EventHandler(TimeUpdateTimer_Tick);
            Timer.Start();
        }

        private void TimeUpdateTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"Время: {DateTime.Now.ToLongTimeString()}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPopUp(new ClientForm());
        }

        private void TouroperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPopUp(new TouroperatorForm());
        }

        private void HotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPopUp(new HotelForm());
        }

        private void ShowPopUp<T>(T form) where T : Form
        {
            Hide();
            form.ShowDialog();
            Show();
            form = null;
            GC.Collect();
        }

        private void TourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPopUp(new TourForm());
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPopUp(new OrderForm());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
