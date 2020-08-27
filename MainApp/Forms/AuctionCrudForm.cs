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
        public string ListSelectedItem { get; set; }

        private async void button1_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            if (ListSelectedItem != null && numericUpDown1.Value > 0)
            {
                Advertisement ad = new Advertisement
                (
                    await Car.FindByVin(ListSelectedItem),
                    Convert.ToInt32(numericUpDown1.Value)
                );

                try
                {
                    await Task.Run(async () =>
                    {
                        await Advertisement.InsertAdvertisement(ad);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ad coudln't be added to db. Are you sure that you selected carVin from list ? Maybe price is equal to (or lower) than 0");
            }
           

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListSelectedItem = listView1.SelectedItems[0].Text;
            }
        }
    }
}
