using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.Models
{
    public class TrashUserPickupDate
    {
        [Key]
        public int TrashUserPickupDateId { get; set; }
        public DateTime TrashUserPickupDateTime { get; set; }

        [ForeignKey("TrashUserPickupDateId")]
        public TrashUser TrashUser { get; set; }
    }
}