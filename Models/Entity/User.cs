using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edulu3.Models.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public string Rol { get; set; }
        public DateTime RegisterDate { get; set; }


    }
}