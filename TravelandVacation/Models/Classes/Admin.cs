using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelandVacation.Models.Classes
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        public string adminName { get; set; }

        public string Password { get; set; }
    }
}