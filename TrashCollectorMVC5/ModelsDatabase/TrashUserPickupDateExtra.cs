using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.ModelsDatabase
{
    public class TrashUserPickupDateExtra
    {
        [Key]
        public int TrashUserPickupDateExtraId { get; set; }
        public DateTime TrashUserPickupDateTime { get; set; }

        [ForeignKey("TrashUserPickupDateExtraId")]
        public TrashUser TrashUser { get; set; }
    }
}