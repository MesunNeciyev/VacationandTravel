using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelandVacation.Models.Classes
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public string userName { get; set; }

        public string userEmail { get; set; }

        public string Comment { get; set; }

        public Blog Blog { get; set; }
    }
}