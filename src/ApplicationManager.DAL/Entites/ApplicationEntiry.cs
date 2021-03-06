using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationManager.DAL.Entites;
namespace ApplicationManager.DAL.Entites
{
    [Table("Applications")]
    public class ApplicationEntiry
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        public string Address { get; set; }
        public int? DistrictId { get; set; }
        public DistrictEntity District { get; set; }
        public int ApplicationStatusId { get; set; }
        public ApplicationStatusEntity ApplicationStatus { get; set; }

    }
}