using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.Models
{

    //Class for each vehicle ( cars only ) in Dealership
    public class Car
    {
        //props
        [Key]
        [Required]
        [MaxLength(17)]
        public string VIN { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [MaxLength(6)]
        public int Engine { get; set; }
        [MaxLength(4)]
        public int HP { get; set; }
        public DateTime ProductionYear { get; set; }
        [MaxLength(8)]
        public int Mileage { get; set; }
        public string Combustion { get; set; }
        public string Color { get; set; }
        public string Condition { get; set; }
        public string Gearbox { get; set; }
        public bool GPS { get; set; }
        public bool ESP { get; set; }
        public bool AC { get; set; }
        public bool ParkAssist { get; set; }
        public bool Shift_Paddles { get; set; }

        //default ctor
        public Car()
        {

        }

        //ctor
        public Car(string vIN, string brand, string model, string type, int engine, int hP, DateTime productionYear, int mileage, string combustion, string color, string condition, string gearbox, bool gPS, bool eSP, bool aC, bool parkAssist, bool shift_Paddles)
        {
            VIN = vIN;
            Brand = brand;
            Model = model;
            Type = type;
            Engine = engine;
            HP = hP;
            ProductionYear = productionYear;
            Mileage = mileage;
            Combustion = combustion;
            Color = color;
            Condition = condition;
            Gearbox = gearbox;
            GPS = gPS;
            ESP = eSP;
            AC = aC;
            ParkAssist = parkAssist;
            Shift_Paddles = shift_Paddles;
        }

        /// <summary>
        /// ( async ) Function which returns list of cars from db
        /// </summary>
        /// <returns></returns>
        public async static Task<List<Car>> SelectCars()
        {
            try
            {
                Context ctx = new Context();
                return await ctx.Cars.ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// ( async ) Function to show cars returned from db
        /// </summary> 
        /// <param name="entityCars">Task of list of cars ( easily placed with SelectCars function</param>
        /// <returns>Task</returns>
        public static void ShowCars(List<Car> entityCars, ListView listControl)
        {
            var cars = entityCars;
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    listControl.Items.Add($"Brand: {car.Brand},Model: {car.Model},Condition: {car.Condition},Engine: {car.Engine} cm3");
                }
            }
        }

        //TO DO: TextBox.Text and CheckBox.IsChecked as parameters
        /// <summary>
        /// (async) Creates a car object which is added to , and saves context asynchronously
        /// </summary>
        /// <returns>car object</returns>
        public async static Task<Car> InsertCar(Car car)
        {
            try
            {
                Context context = new Context();

                //adds 'car' to db
                context.Cars.Add(car);
                //saves changes in context and sends to db
                await context.SaveChangesAsync();
                Console.WriteLine("Context saved!");

                return car;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                MessageBox.Show($"Added car {car.VIN}");
            }
        }

        /// <summary>
        /// ( async )Filter list to look for a car with selected vin
        /// </summary>
        /// <returns></returns>
        public async static Task<Car> FindByVin(string filter)
        {
            Context context = new Context();
            //linq query to look for a car with specific parameter ( vin only )
            var searchedCar = await context.Cars.Where(x => x.VIN == filter).FirstOrDefaultAsync();
            return searchedCar;
        }
    }
}
