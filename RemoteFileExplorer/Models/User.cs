using System.ComponentModel.DataAnnotations;

namespace RemoteFileExplorer.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public double DiskSpace { get; set; } = Math.Pow(1024, 3) * 10;
        public double UsedSpace { get; set; } = 0;
        public string? Avatar { get; set; }
        public List<File>? Files { get; set; }
    }
}
