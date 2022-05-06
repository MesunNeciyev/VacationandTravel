using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelandVacation.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string blogName { get; set; }

        public string blogContent { get; set; }

        public string blogImage { get; set; }

        public DateTime enterDate { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}