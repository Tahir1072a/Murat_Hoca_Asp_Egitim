using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}