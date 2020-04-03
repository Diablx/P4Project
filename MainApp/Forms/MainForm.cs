using CarDealership.Models;
using System.Windows.Forms;

namespace MainApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainViewButton_Click(object sender, System.EventArgs e)
        {

        }

        private async void CarsViewButton_Click(object sender, System.EventArgs e)
        {
            var carsCollection = await Car.SelectCars();
            Car.ShowCars(carsCollection, ListView1);
        }

        private void AuctionsViewButton_Click(object sender, System.EventArgs e)
        {

        }

        private void RentViewButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("W trakcie realizacji");
        }
    }
}
