using CarDealership.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CrudForm crudForm = new CrudForm();
        AuctionCrudForm auctionCrudForm = new AuctionCrudForm();


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

        private async void AuctionsViewButton_Click(object sender, System.EventArgs e)
        {
            List<Advertisement> ads = new List<Advertisement>();

            ListView1.Clear();
            ads = await Advertisement.SelectAdvertisements();
            Advertisement.ShowAdvertisements(ads, ListView1);
        }

        private async void RentViewButton_Click(object sender, System.EventArgs e)
        {
            if (auctionCrudForm.IsDisposed)
                auctionCrudForm = new AuctionCrudForm();

            auctionCrudForm.Show();
            auctionCrudForm.BringToFront();
            auctionCrudForm.Activate();

            List<Car> cars = new List<Car>();

            ListView listView1 = (ListView)auctionCrudForm.Controls["listView1"];
            listView1.Clear();
            cars = await Car.SelectCars();
            Car.ShowCarsVinOnly(cars, listView1);
        }

        private void Add_Car_Click(object sender, System.EventArgs e)
        {
            if (crudForm.IsDisposed)
                crudForm = new CrudForm();

            crudForm.Show();
            crudForm.BringToFront();
            crudForm.Activate();
        }
    }
}
