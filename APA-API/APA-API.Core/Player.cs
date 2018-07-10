using System.ComponentModel.DataAnnotations;

namespace APA_API.Core
{
    public class Player
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public int SkillLevel { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
