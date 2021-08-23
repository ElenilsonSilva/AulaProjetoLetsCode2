using System;
using System.Collections.Generic;
using System.Linq;


namespace AulaProjetoLetsCode2
{
    public class User : Address
    {

        public int id = 0; 
        public string name { get; set; } 
        public string deliveryAddress { 
            get
            {  
                return $"{address} {secondAddress} {number} {zipCode} {city} {state} {country}";
            }
        } 
        public Address billingAddress { get; set; } 
        public string user { get; set; } 
        public string password { get; set; } 
        public DateTime birthDate { get; set; }
        public override string ToString()
        {
            return $"  | Id: {id} | Nome: {name} | User: {user} |";

        }

    }
}