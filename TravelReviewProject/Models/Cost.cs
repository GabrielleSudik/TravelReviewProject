﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Cost
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Estimated Cost")]
        public string EstimatedCost { get; set; }
    }
}