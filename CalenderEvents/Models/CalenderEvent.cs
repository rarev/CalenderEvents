using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalenderEvents.Models
{
    public class CalenderEvent
    {
        [Key]
        public int EventID { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime EndTime { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Category { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}