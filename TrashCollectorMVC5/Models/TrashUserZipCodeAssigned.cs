using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.Models
{
    public class TrashUserZipCodeAssigned
    {
        public int TrashUserId { get; set; }
        public int TrashUserZipCodeAssignedId { get; set; }

        [ForeignKey("TrashUserId")]
        public TrashUser TrashUser { get; set; }

        [ForeignKey("TrashUserZipCodeAssignedId")]
        public TrashUserZipCode TrashUserZipCode { get; set; }
    }
}