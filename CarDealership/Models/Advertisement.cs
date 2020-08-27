using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.Models
{
    public class Advertisement
    {
        //props
        [Key]
        public int ID { get; set; }
        public Car Car { get; set; }
        [ForeignKey("VIN")]
        public string Car_ID { get; set; }
        public float Price { get; set; }
        public Person Person { get; set; }
        [ForeignKey("Pesel")]
        public int Salesman { get; set; }

        //default ctor
        public Advertisement()
        {

        }

        //ctor
        public Advertisement(Car car, float price)
        {
            Car = car;
            Price = price;
        }

        public static async Task<Advertisement> InsertAdvertisement(Advertisement ad)
        {
            
            try
            {
                Context ctx = new Context();
                ctx.Advertisements.Add(ad);
                await ctx.SaveChangesAsync();
                MessageBox.Show($"Dodano aukcję {ad.ID}!");
                return ad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static async Task<List<Advertisement>> SelectAdvertisements()
        {
            try
            {
                Context ctx = new Context();
                return await ctx.Advertisements.ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void ShowAdvertisements(List<Advertisement> entityAds, ListView listControl)
        {
            var ads = entityAds;
            if (ads.Count > 0)
            {
                foreach (var ad in ads)
                {
                    listControl.Items.Add($"Price: {ad.Price}");
                }
            }
        }
        //public static async Task GetAdvertisements(Task<List<Advertisement>> entityAdvertisements)
        //{
        //    var advertisements = await entityAdvertisements;

        //    foreach (var item in advertisements)
        //    {
        //        Console.WriteLine($"{nameof(item.Price)}:{item.Price}" +
        //                          $"{nameof(item.Car.Brand)}: {item.Car.Brand}\n" +
        //                          $"{nameof(item.Car.VIN)}:{item.Car.VIN}"); 
        //    }
        //}
    }
}
