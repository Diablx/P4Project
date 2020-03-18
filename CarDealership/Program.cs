using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dev usings
using CarDealership.Models;


namespace CarDealership
{
    public class Program
    {
        public static void Main()
        {
            var ad = new Advertisement();
            var car = new Car();
            var person = new Person();

            try
            {
                car.Select();
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Pokazano ... ");
            }
        }
    }
}
