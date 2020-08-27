using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//My usings
using CarDealership.Models;

namespace CarDealership
{
    public class Program
    {
        public static void Main()
        {
            //Context ctx = new Context();
            //ctx.Database.EnsureCreated();
            Console.WriteLine($"Database created!");
            //Task.WhenAll(
            //    Car.SelectCars(),
            //    //Car.InsertCar(),
            //    //Car.ShowCars(Car.SelectCars()),
            //    //Car.FindByVin("123asd123asd123"),
            //    Advertisement.InsertAdvertisement()
            //    //Advertisement.GetAdvertisements(Advertisement.SelectAdvertisements())
            //);
            Console.ReadLine();
        }
    }
}
