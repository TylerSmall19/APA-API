using System;
using System.ComponentModel.DataAnnotations;

namespace APA_API.Core
{
    public class Game
    {
        public int ID { get; set; }
        [Required]
        public int PlayerMatchId { get; set; }
        public PlayerMatch PlayerMatch { get; set; }
        [Required]
        public int Innings { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SpecialLossId { get; set; }
        public SpecialLoss SpecialLoss { get; set; }
        public int PlayerACoaches { get; set; }
        public int PlayerBCoaches { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
