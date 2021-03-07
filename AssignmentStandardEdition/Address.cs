using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStandardEdition
{
    class Address
    {
        public string roadno;
        public string homeno;
        public string city;
        public string country;
        

        
        public Address(string roadno, string homeno,string city,string country)
        {
            this.roadno = roadno;
            this.homeno = homeno;
            this.city = city;
            this.country = country;

        }
        public string Roadno
        {
            set { this.roadno = value; }
            get { return this.roadno; }
        }
       

        public string HomeNo
        {
            set { this.homeno = value; }
            get { return this.homeno; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }
        public void Details()
        {
            Console.WriteLine(value: roadno);
            Console.WriteLine(value: homeno);
            Console.WriteLine(value: city);
            Console.WriteLine(value: country);
        }
    }
}

