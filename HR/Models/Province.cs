using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Application.Models
{
    public class Province
    {

        public int Id { get; set; }

        public string Code { get; set; }

        public string Khmer { get; set; }

        public string English { get; set; }

        public int KrongId { get; set; }

        public int SrokId { get; set; }

        public int KhanId { get; set; }

        public int CommuneId { get; set; }

        public int SangkatId { get; set; }

        public int VillageId { get; set; }

        public string Reference { get; set; }

        public string Latitute { get; set; }

        public string Longitudes { get; set; }

        public string Abbreviation { get; set; }

        public string EastEn { get; set; }

        public string EastKh { get; set; }

        public string WestEn { get; set; }

        public string WestKh { get; set; }

        public string SouthEn { get; set; }

        public string SouthKh { get; set; }

        public string NorthEn { get; set; }

        public string NorthKh { get; set; }
    }
}