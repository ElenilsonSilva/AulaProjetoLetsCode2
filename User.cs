using System;
using System.Collections.Generic;
using System.Linq;


namespace AulaProjetoLetsCode2
{
    public class User : IAddress
    {
        public string address { get ; set; }
        public string secondAddress { get ; set ; }
        public int number { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }



        protected List<User> _user;
        public int id = 0; 
        public string name { get; set; } 
        public string deliveryAddress { 
            get
            {  
                return $"{address} {secondAddress} {number} {zipCode} {city} {state} {country}";
            }
        } 
        public string billingAddress { get; set; } 
        public string user { get; set; } 
        public string password { get; set; } 
        public DateTime birthDate { get; set; }
       
        public override string ToString()
        {
            return $"  | Id: {id} | Nome: {name} | User: {user} |\n\n";

        }

    }
}