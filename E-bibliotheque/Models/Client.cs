using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_librairy.Models
{
    public class Client
    {
        public string Name { get; set; }
        [Key] public string Email { get; set; }
    }
}