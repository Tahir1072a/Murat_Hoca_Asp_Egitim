using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Header
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}