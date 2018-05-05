using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.ModelsDatabase
{
    public class TrashUserTelephoneNumber
    {

        [Key]
        public int TrashUserTelephoneNumberId { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("TrashUserTelephoneNumberId")]
        public TrashUser TrashUser { get; set; }
    }
}