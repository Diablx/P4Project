using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.Models;

namespace MainApp.Forms
{
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
        }

        private async void db_Add_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            Car car = new Car
            {
                VIN = vin_tb.Text,
                Brand = brand_tb.Text,
                Model = model_tb.Text,
                Type = type_cb.Text,
                Engine = Convert.ToInt32(engine_tb.Value),
                HP = Convert.ToInt32(hp_tb.Value),
                ProductionYear = productionYear_tb.Value,
                Mileage = Convert.ToInt32(mileage_tb.Value),
                Combustion = combustion_cb.Text,
                Color = color_tb.Text,
                Condition = condition_cb.Text,
                Gearbox = transmission_cb.Text,
                GPS = gps_b.Checked,
                ESP = esp_b.Checked,
                AC = AC_b.Checked,
                ParkAssist = parkAs_b.Checked,
                Shift_Paddles = paddles_b.Checked
            };

            try
            {
                await ctx.Cars.AddAsync(car);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
