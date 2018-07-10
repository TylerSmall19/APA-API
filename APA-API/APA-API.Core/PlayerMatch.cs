using System;
using System.ComponentModel.DataAnnotations;

namespace APA_API.Core
{
    public class PlayerMatch
    {
        public int ID { get; set; }
        [Required]
        public int TeamMatchId { get; set; }
        public TeamMatch TeamMatch { get; set; }
        [Required]
        public int PlayerAId { get; set; }
        public Player PlayerA { get; set; }
        [Required]
        public int PlayerBId { get; set; }
        public Player PlayerB { get; set; }
        [Required]
        public int PlayerAMustWin { get; set; }
        [Required]
        public int PlayerBMustWin { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
