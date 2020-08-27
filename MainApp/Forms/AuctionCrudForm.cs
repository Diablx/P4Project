using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.Forms
{
    public partial class AuctionCrudForm : Form
    {
        public AuctionCrudForm()
        {
            InitializeComponent();
        }

        public Car ChosenCar { get; set; }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = listBox1.SelectedItem as Car;
            ChosenCar = car;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            Advertisement ad = new Advertisement
            (
                ChosenCar,
                200000f,
            ) ;

            try
            {
                Advertisement.InsertAdvertisement(ad);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                MessageBox.Show("Ad was added!");
            }
            
        }

        private async void db_Add_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            Car car = new Car
            {
                //VIN = vin_tb.Text,
                //Brand = brand_tb.Text,
                //Model = model_tb.Text,
                //Type = type_cb.Text,
                //Engine = Convert.ToInt32(engine_tb.Value),
                //HP = Convert.ToInt32(hp_tb.Value),
                //ProductionYear = productionYear_tb.Value,
                //Mileage = Convert.ToInt32(mileage_tb.Value),
                //Combustion = combustion_cb.Text,
                //Color = color_tb.Text,
                //Condition = condition_cb.Text,
                //Gearbox = transmission_cb.Text,
                //GPS = gps_b.Checked,
                //ESP = esp_b.Checked,
                //AC = AC_b.Checked,
                //ParkAssist = parkAs_b.Checked,
                //Shift_Paddles = paddles_b.Checked
            };
            try
            {
                ctx.Cars.Add(car);
                await ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show($"{car.VIN} was added to db.");
            }
        }
    }
}
