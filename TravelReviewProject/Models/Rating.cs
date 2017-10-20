using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Rating
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Rating")]
        public string UserRating { get; set; }
    }
}