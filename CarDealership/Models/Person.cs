using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Windows.Forms;

namespace CarDealership.Models
{
    //props
    public class Person
    {
        [Key]
        public int Pesel { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Login { get; set; }

        //defualt ctor
        public Person()
        {

        }

        //ctor
        public Person(int iD, string login, string firstname, string lastname, string address, int phoneNumber)
        {
            Pesel = iD;
            Login = login;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //public Person CreateEmployee(int iD, string login, string firstname, string lastname, string address, int phoneNumber)
        //{
        //    Person person = new Person(iD, login, firstname, lastname, address, phoneNumber);
        //    return person;
        //}


        /// <summary>
        /// Inserts person object to db
        /// </summary>
        /// <returns></returns>
        public static async Task<Person> InsertPerson()
        {
            Person person = null;
            try
            {
                Context ctx = new Context();
                person = new Person(
                    1515232315, 
                    "kajbor", 
                    "kajetan", 
                    "boruta", 
                    "Pszczyna", 
                    515232199
                    );
                //add person to db
                await ctx.AddAsync(person);
                //save changes
                await ctx.SaveChangesAsync();
                return person;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                MessageBox.Show($"Added person: {person.Pesel}");
            }
        }

        /// <summary>
        /// Function to find person by Pesel
        /// </summary>
        /// <param name="fitler"></param>
        /// <returns></returns>
        public static async Task<int> FindPersonByPeselAsync(int fitler)
        {
            Context ctx = new Context();
            var filteredPerson = await ctx.People.Where(x => x.Pesel == fitler).FirstOrDefaultAsync();

            return filteredPerson.Pesel;
        }
    }
}
