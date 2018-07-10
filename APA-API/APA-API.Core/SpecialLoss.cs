using System.ComponentModel.DataAnnotations;

namespace APA_API.Core
{
    public class SpecialLoss
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(75)]
        public string Description { get; set; }
    }
}
