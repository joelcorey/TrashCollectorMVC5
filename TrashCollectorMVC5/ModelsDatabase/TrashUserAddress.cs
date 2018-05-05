using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.ModelsDatabase
{
    public class TrashUserAddress
    {
        [Key]
        public int TrashUserAddressId { get; set; }
        public string PrimaryStreetAddress { get; set; }
        public string SecondaryStreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        [ForeignKey("TrashUserAddressId")]
        public TrashUser TrashUser { get; set; }

    }
}