using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class CustomerViewModel
    {
        public class GetCurrentDayViewModel
        {
            [Required]
            [Display(Name = "Current Day")]
            public string CurrentDay { get; set; }
        }

    }
}