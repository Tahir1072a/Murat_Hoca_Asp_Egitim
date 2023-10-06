using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}