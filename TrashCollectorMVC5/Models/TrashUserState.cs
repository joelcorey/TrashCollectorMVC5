using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrashCollectorMVC5.Models;

namespace TrashCollectorMVC5.Models
{
    public class TrashUserState
    {
        [Key]
        public int TrashUserStateId { get; set; }
        public string TrashUserStateAbbreviated { get; set; }
        public string TrashUserStateFullName { get; set; }

        [ForeignKey("TrashUserStateId")]
        public TrashUser TrashUser { get; set; }
    }
}