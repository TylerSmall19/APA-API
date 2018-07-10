using System.ComponentModel.DataAnnotations;
using System;

namespace APA_API.Core
{
    public class TeamMatch
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public Team HostTeam { get; set; }
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int WeekNumber { get; set; }
        public bool IsPlayoffMatch { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
