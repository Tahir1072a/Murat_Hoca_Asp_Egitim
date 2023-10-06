using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
} 