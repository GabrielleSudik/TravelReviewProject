using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("City or Destination")]
        public string City { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
    }
}