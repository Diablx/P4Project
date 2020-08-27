using CarDealership.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CrudForm form = new CrudForm();

        private void MainViewButton_Click(object sender, System.EventArgs e)
        {

        }

        private async void CarsViewButton_Click(object sender, System.EventArgs e)
        {
            List<Car> cars = new List<Car>();

            ListView1.Clear();
            cars = await Car.SelectCars();
            Car.ShowCars(cars, ListView1);
        }

        private void AuctionsViewButton_Click(object sender, System.EventArgs e)
        {

        }

        private void RentViewButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("W trakcie realizacji");
        }

        private void Add_Car_Click(object sender, System.EventArgs e)
        {
            if (form.IsDisposed)
                form = new CrudForm();

            form.Show();
            form.BringToFront();
            form.Activate();
        }
    }
}
