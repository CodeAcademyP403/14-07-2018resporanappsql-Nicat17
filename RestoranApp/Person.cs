using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranApp
{
    public class Person
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Role role { get; set; }
    }
    public class AllPerson
    {
        public List<Person> People { get; set; }

        public AllPerson()
        {
            People = new List<RestoranApp.Person>();
        }
    }
    public class AllWaiter
    {
        public List<Person> AllPersonWaiters { get; set; }
        public List<Waiter> AllWaiters { get; set; }

        public AllWaiter()
        {
            AllPersonWaiters = new List<RestoranApp.Person>();
            AllWaiters = new List<RestoranApp.Waiter>();
        }
    }
    public class AllMaderator
    {
        public List<Person> AllPersonMaderators { get; set; }
        public List<Maderator> AllMaderators { get; set; }

        public AllMaderator()
        {
            AllPersonMaderators = new List<RestoranApp.Person>();
            AllMaderators = new List<RestoranApp.Maderator>();
        }
    }
    public class AllAdmin
    {
        public List<Person> AllPersonAdmins { get; set; }
        public List<Admin> AllAdmins { get; set; }

        public AllAdmin()
        {
            AllPersonAdmins = new List<RestoranApp.Person>();
            AllAdmins = new List<RestoranApp.Admin>();
        }
    }
}
