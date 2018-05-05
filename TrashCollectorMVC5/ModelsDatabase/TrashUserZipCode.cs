using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.ModelsDatabase
{
    public class TrashUserZipCode
    {
        [Key]
        public int TrashUserZipCodeId { get; set; }
        public int TrashUserZipCodeInt { get; set; }

        [ForeignKey("TrashUserZipCodeId")]
        public TrashUser TrashUser { get; set; }
    }
}