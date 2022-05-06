using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelandVacation.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int Id { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }
    }
}