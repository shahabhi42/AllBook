using System.ComponentModel.DataAnnotations;

namespace NewFakeBookMarkIII.Models
{
    public class Interest
    {
        [Key]
        public string InterestName { get; set; }
        public string Description { get; set; }
    }
}