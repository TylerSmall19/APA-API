using System.ComponentModel.DataAnnotations;
using System;

namespace APA_API.Core
{
    public class TeamMatch
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public int HostTeamId { get; set; }
        public Team HostTeam { get; set; }
        [Required]
        public int TeamAId { get; set; }
        public Team TeamA { get; set; }
        [Required]
        public int TeamBId { get; set; }
        public Team TeamB { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int WeekNumber { get; set; }
        public bool IsPlayoffMatch { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
