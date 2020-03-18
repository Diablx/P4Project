using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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

        public void Select()
        {
            Context context = new Context();
            var cars = context.Cars.ToList();

            foreach (var car in cars)
            {
                Console.WriteLine($"Car nr:{cars.IndexOf(car)} with {nameof(car.VIN)}:{car.VIN}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"{nameof(car.Brand)}:{car.Brand}\n{nameof(car.Model)}:{nameof(car.Model)}");
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }


        //TO DO: TextBox.Text and checkboxes as parameters
        /// <summary>
        /// Creates a car
        /// </summary>
        /// <returns>car</returns>
        public Car Insert()
        {
            Context context = new Context();
            //new car object
            Car car = new Car(
                "123asd123asd123", //VIN [ vehicle identification number ] 
                "Mitsubishi", //brand [ fiat,mitsubishi,seat ... ]
                "Lancer", //model [ ibiza,tipo,lancer ... ]
                "Sedan", //type [ sedan, coupe, hetchback, SUV, minivan, VAN ] 
                1800, //engine [cm3]
                190, //HP [km]
                new DateTime(2008,10,10), //prodyear [year]
                100000, //mileage [kms]
                "Benzyna", //combustion [petrol,diesel,hybrid,
                "Red", //color []
                "Used", //condition [new,used,broken]
                "Manual", //gearbox [manual, automatic]
                true, //GPS [t/f]
                true, //ESP [t/f]
                true, //AC [t/f]
                true, //parkassist [t/f]
                true //shift paddles [t/f]
            );
            context.Cars.Add(car);
            return car;
        }
        /// <summary>
        /// Update car in DB
        /// </summary>
        /// <returns></returns>
        public Car SelectByVin()
        {
            Context context = new Context();
            var selectedCar = context.Cars.Where(x => x.VIN == "").FirstOrDefault(); 
            return selectedCar;
        }
    }
}
