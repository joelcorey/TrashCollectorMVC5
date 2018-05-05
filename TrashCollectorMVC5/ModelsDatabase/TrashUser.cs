using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
//using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.Models
{
    public class TrashUser
    {
        [Key]
        public int TrashUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public int IsEmployee { get; set; }

        [ForeignKey("TrashUserId")]
        public ApplicationUser User { get; set; }
    }
}