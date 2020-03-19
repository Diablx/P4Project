using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

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
        public Advertisement(Car car, float price, int salesman)
        {
            Car = car;
            Price = price;
            Salesman = salesman;
        }

        public static async Task<Advertisement> InsertAdvertisement()
        {
            Advertisement ad = null;
            try
            {
                Context ctx = new Context();
                ad = new Advertisement(
                    await Car.FindByVin("123asd123asd123"),
                    200000f,
                    await Person.FindPersonByPeselAsync(1111111)
                    );
                await ctx.Advertisements.AddAsync(ad);
                await ctx.SaveChangesAsync();
                return ad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine($"Dodano ogłoszenie {ad.ID}!");
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
                throw ex;
            }
        }

        public static async Task GetAdvertisements(Task<List<Advertisement>> entityAdvertisements)
        {
            var advertisements = await entityAdvertisements;

            foreach (var item in advertisements)
            {
                Console.WriteLine($"{nameof(item.Price)}:{item.Price}" +
                                  $"{nameof(item.Car.Brand)}: {item.Car.Brand}\n" +
                                  $"{nameof(item.Car.VIN)}:{item.Car.VIN}"); 
            }
        }
    }
}
