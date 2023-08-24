using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Application.Models
{
    public class CustomerType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

}