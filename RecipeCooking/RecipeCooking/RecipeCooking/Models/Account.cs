using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Models
{
    public class Account
    { 

        public int IdAcc { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avt { get; set; }
        public byte? Status { get; set; }
        public int? IdRol { get; set; }

    }
}

