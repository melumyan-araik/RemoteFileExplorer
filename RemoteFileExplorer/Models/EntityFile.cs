namespace RemoteFileExplorer.Models
{
    public class EntityFile
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public string AccsessLink { get; set; } = string.Empty;
        public double Size { get; set; } = 0;
        [Required]
        public string Path { get; set; } = string.Empty;
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ParentId { get; set; }
        public Guid? CildId { get; set; }
    }
}
