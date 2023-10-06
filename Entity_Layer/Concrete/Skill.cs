using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Value { get; set; }
    }
}