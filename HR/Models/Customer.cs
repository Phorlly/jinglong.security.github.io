using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Application.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lasttname { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }

        public int CustomerTypeId { get; set; }

        [ForeignKey("CustomerTypeId")]

        public virtual CustomerType CustomerType { get; set; }

        public string Note { get; set; }

    }
}