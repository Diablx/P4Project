using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Advertisement(int iD, string car, float price, int salesman)
        {
            
            ID = iD;
            Car_ID = car;
            Price = price;
            Salesman = salesman;
        }

        /// <summary>
        /// Function to add advertisement
        /// </summary>
        /// <param name="id">id of advertisement</param>
        /// <param name="car">car id ( id )</param>
        /// <param name="price">price of car set in advertisement</param>
        /// <param name="salesmanID">id of employee</param>
        /// <returns>Advertisement</returns>
        public Advertisement CreateAdvertisement(int id, string car, float price, int salesmanID)
        {
            Advertisement advertisement = new Advertisement(id,car,price,salesmanID);

            return advertisement;
        }

        public List<Advertisement> Advertisements;

        public List<Advertisement> SelectAdvertisements()
        {
            Advertisements = new List<Advertisement>();
            //string query = 


            return Advertisements;
        }
    }
}
