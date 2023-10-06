using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Referance
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}