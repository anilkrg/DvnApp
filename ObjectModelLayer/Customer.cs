using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModelLayer
{
    public class Customer
    {

        public int CustomerId { get; set; } 
        public string? Name { get; set; }    
        public string? Email { get; set; }
        public string? phone { get; set; }
        public string? Gender { get; set; }
        public string? Birthdate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public int PinCode { get; set; }



    }
}
