using System.ComponentModel.DataAnnotations;

namespace RemoteFileExplorer.Models
{
    public class File
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type  { get; set; }
        public string AccsessLink { get; set; }
        public double Size { get; set; }
        public Guid UserId { get; set; }
        public Guid ParentId { get; set; }
    }
}
