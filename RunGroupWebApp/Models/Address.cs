using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}
