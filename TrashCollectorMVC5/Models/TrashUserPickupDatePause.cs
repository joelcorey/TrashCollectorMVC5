using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.Models
{
    public class TrashUserPickupDatePause
    {
        [Key]
        public int TrashUserPickupDatePauseId { get; set; }
        public DateTime TrashUserPickupStart { get; set; }
        public DateTime TrashUserPickupEnd { get; set; }

        [ForeignKey("TrashUserPickupDatePauseId")]
        public TrashUser TrashUser { get; set; }
    }
}