using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollectorMVC5.Models
{
    public class TrashUser
    {
        [Key]
        public int TrashUserId { get; set; }
        public string ApplicationUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public int IsEmployee { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}