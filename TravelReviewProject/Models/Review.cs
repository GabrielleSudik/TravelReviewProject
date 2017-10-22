using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Title of Review")]
        public string ReviewTitle { get; set; }
        [DisplayName("User Review")]
        public string UserReview { get; set; }
        //how can you make that date to be automatically today?
        /*[DefaultValue(typeof(DateTime), DateTime.Now.ToString("yyyy-MM-dd")),
            DisplayName("Date of Visit")]*/
        /*is it DateTime.Now.Year, like in the footer?*/
        [DataType(DataType.Date), DisplayName("Date of Visit")]
        public DateTime Date { get; set; }

        [ForeignKey("Destination")]
        public int DestinationID { get; set; }
        [DisplayName("Destination")]
        public virtual Destination Destination { get; set; }

        [ForeignKey("Rating"), DisplayName("Rating")]
        public int RatingID { get; set; }
        [DisplayName("Rating")]
        public virtual Rating Rating { get; set; }

        [ForeignKey("Cost"), DisplayName("Estimated Cost")]
        public int CostID { get; set; }
        [DisplayName("Estimated Cost")]
        public virtual Cost Cost { get; set; }
    }
}