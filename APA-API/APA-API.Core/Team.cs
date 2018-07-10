using System.ComponentModel.DataAnnotations;
using System;

namespace APA_API.Core
{
    public class Team
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int DivisionId { get; set; }
        public int Points { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
