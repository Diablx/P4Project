﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq;

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

        public Person CreateEmployee(int iD, string login, string firstname, string lastname, string address, int phoneNumber)
        {
            Person person = new Person(iD, login, firstname, lastname, address, phoneNumber);
            return person;
        }

        public static async Task<int> FindPersonByPeselAsync(int fitler)
        {
            Context ctx = new Context();
            var filteredPerson = await ctx.People.Where(x => x.Pesel == fitler).FirstOrDefaultAsync();

            return filteredPerson.Pesel;
        }
    }
}
